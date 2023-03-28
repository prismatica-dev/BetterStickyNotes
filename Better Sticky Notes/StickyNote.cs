using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Better_Sticky_Notes {
    public partial class StickyNote : Form {
        // if u are forking the project set this to your fork so the auto-updater checks your repo!
        // also if in your releases you upload the binary as anything other than 'Better.Sticky.Notes.exe' it will fail to update (or if you have a tag that isn't a valid version)
        private const string repo = "uDMBK/BetterStickyNotes";

        public StickyNote(string args, bool primary) {
            PrimaryNote = primary;

            if (primary) {
                try {
                    string LatestTag = GetLatestTag();
                    if (primary && LatestTag.Length > 0) if (Assembly.GetExecutingAssembly().GetName().Version < Version.Parse(LatestTag)) UpdateProgram(LatestTag);
                    CreateShortcut();
                    CreateStartMenuShortcut();
                } catch {}}
            InitializeComponent();

            SelectionEditor.Height = 0;
            if (primary) {
                string[] Notes = GetNotes();
                foreach (string note in Notes) LoadNote(note);
                if (Notes.Length > 0) NoteShouldntExist = true;
                CloseIntegrity.Start(); } else {
                NoteDirectory = args;
                if (NoteDirectory.Length > 4) {
                    if (File.Exists(args)) try { NoteText.LoadFile(args); } catch (Exception) { }
                    if (File.Exists($"{args.Substring(0, args.Length - 4)}.data")) {
                        string[] NoteData = File.ReadAllText($"{args.Substring(0, args.Length - 4)}.data").Split('\n');
                        if (NoteData.Length == 4 || NoteData.Length == 5) try {
                                Width = Convert.ToInt32(NoteData[0]);
                                Height = Convert.ToInt32(NoteData[1]);
                                StartLeft = Convert.ToInt32(NoteData[2]);
                                StartTop = Convert.ToInt32(NoteData[3]);
                                if (NoteData.Length == 5) // 0.1.0 compatibility
                                    CurrentTheme = NoteTheme.ThemeFromEncodedArray(NoteData[4].Split('|')); } catch (Exception) { /*note is broken but will fix itself*/ } } } } }

        public class NoteTheme {
            public LinearGradientBrush GradientBrush { get; }
            public Color Color1 { get; set; }
            public Color Color2 { get; set; }
            public override string ToString() => $"{Color1.R}|{Color1.G}|{Color1.B}|{Color2.R}|{Color2.G}|{Color2.B}";
            public static NoteTheme ThemeFromEncodedArray(string[] Array) {
                try {
                    return new NoteTheme(Convert.ToInt32(Array[0]), Convert.ToInt32(Array[1]), Convert.ToInt32(Array[2]), Convert.ToInt32(Array[3]), Convert.ToInt32(Array[4]), Convert.ToInt32(Array[5]));
                } catch { return Themes[0]; }}
            public NoteTheme(int Red1, int Green1, int Blue1, int Red2, int Green2, int Blue2) {
                Color1 = Color.FromArgb(Red1, Green1, Blue1);
                Color2 = Color.FromArgb(Red2, Green2, Blue2);
                GradientBrush = new LinearGradientBrush(new PointF(0, 0), new PointF(250, 0), Color1, Color2); } }

        public static NoteTheme[] Themes = {
            new NoteTheme(255, 165, 238, 237, 114, 255),
            new NoteTheme(229, 183, 255, 212, 137, 255),
            new NoteTheme(164, 201, 255, 82, 152, 255),
            new NoteTheme(186, 255, 217, 74, 255, 153),
            new NoteTheme(255, 253, 165, 255, 249, 55),
            new NoteTheme(255, 220, 174, 255, 170, 57),
            new NoteTheme(255, 181, 181, 255, 48, 48) };
        public NoteTheme CurrentTheme = new NoteTheme(255, 165, 238, 237, 114, 255);

        public int StartLeft = -1;
        public int StartTop = -1;
        //public int ThemeIndex = 0;
        public string NoteDirectory = "";
        public bool PrimaryNote = false;
        public bool NoteShouldntExist = false; // this is needed because otherwise c# dies
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public readonly string RoamingAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // global double-buffering
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000;
                cp.ExStyle |= 0x02000000;
                return cp; } }

        // borderless drag
        private void Drag(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); } }

        // borderless window resizing
        protected override void WndProc(ref Message m) {
            const int RESIZE_HANDLE_SIZE = 10;

            switch (m.Msg) {
                case 0x0084:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x01) {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = PointToClient(screenPoint);
                        if (clientPoint.Y <= RESIZE_HANDLE_SIZE) {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)13;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)12;
                            else m.Result = (IntPtr)14; } else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE)) {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)10;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)2;
                            else m.Result = (IntPtr)11;
                        } else {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)16;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)15;
                            else m.Result = (IntPtr)17; } }
                    return; }
            base.WndProc(ref m); }

        private string[] GetNotes() {
            List<string> notes = new List<string>();
            if (!Directory.Exists($"{RoamingAppData}\\dmbk"))
                Directory.CreateDirectory($"{RoamingAppData}\\dmbk");
            if (!Directory.Exists($"{RoamingAppData}\\dmbk\\Better Sticky Notes"))
                Directory.CreateDirectory($"{RoamingAppData}\\dmbk\\Better Sticky Notes");

            foreach (FileInfo file in new DirectoryInfo($"{RoamingAppData}\\dmbk\\Better Sticky Notes").GetFiles())
                if (file.FullName.ToLower().EndsWith(".txt"))
                    notes.Add(file.FullName);
            return notes.ToArray(); }
        private static void CreateShortcut() {
            try {
                using (StreamWriter writer = new StreamWriter($"{Environment.GetFolderPath(Environment.SpecialFolder.Startup)}\\BetterStickyNotes.url")) {
                    string app = Assembly.GetExecutingAssembly().Location;
                    writer.WriteLine("[InternetShortcut]");
                    writer.WriteLine("URL=file:///" + app);
                    writer.WriteLine("IconIndex=0");
                    string icon = app.Replace('\\', '/');
                    writer.WriteLine("IconFile=" + icon);
                    writer.Flush(); } } catch (Exception) { } }
        private static void CreateStartMenuShortcut() {
            try {
                if (!Directory.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.StartMenu)}\\Programs\\dmbk"))
                    Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.StartMenu)}\\Programs\\dmbk");

                using (StreamWriter writer = new StreamWriter($"{Environment.GetFolderPath(Environment.SpecialFolder.StartMenu)}\\Programs\\dmbk\\Better Sticky Notes.url")) {
                    string app = Assembly.GetExecutingAssembly().Location;
                    writer.WriteLine("[InternetShortcut]");
                    writer.WriteLine("URL=file:///" + app);
                    writer.WriteLine("IconIndex=0");
                    string icon = app.Replace('\\', '/');
                    writer.WriteLine("IconFile=" + icon);
                    writer.Flush(); } } catch (Exception) { } }

        private void LoadNote(string NoteDirectory) {
            if (File.Exists(NoteDirectory)) new StickyNote(NoteDirectory, false).Show(); }

        private void NoteLoaded(object sender, EventArgs e) {
            if (NoteShouldntExist) return;
            Bitmap bitmap = new Bitmap(TopPanel.Width, 50);
            using (Graphics g = Graphics.FromImage(bitmap)) {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.FillRectangle(CurrentTheme.GradientBrush, new RectangleF(0, 0, bitmap.Width, bitmap.Height)); }
            TopPanel.BackgroundImage = bitmap;
            CustomTheme1.BackColor = CurrentTheme.Color1;
            CustomTheme2.BackColor = CurrentTheme.Color2;

            int _ = 0;
            foreach (Control c in TopSubPanel.Controls) {
                if (c.Name.StartsWith("Preset")) {
                    LinearGradientBrush lgb = new LinearGradientBrush(new Point(0, 0), new Point(c.Width, c.Height), Themes[_].Color1, Themes[_].Color2);

                    Bitmap bmp = new Bitmap(c.Width, c.Height);
                    using (Graphics g = Graphics.FromImage(bmp)) {
                        g.SmoothingMode = SmoothingMode.HighQuality;
                        g.FillRectangle(lgb, new RectangleF(0, 0, bmp.Width, bmp.Height)); }
                    (c as PictureBox).Image = bmp;
                    _++; }}}

        protected override bool ShowFocusCues => false; // fix border issue
        private void StickyNote_Activated(object sender, EventArgs e) {
            Thread thread = new Thread(new ThreadStart(async delegate { 
                try {
                    foreach (Control control in TopPanel.Controls)
                        control.Invoke((MethodInvoker)delegate { control.Visible = true; });
                    for (int i = 0; i < 8; i++) {
                        if (TopPanel.Height < 50) TopPanel.Invoke((MethodInvoker)delegate { TopPanel.Height += 5; });
                        if (SelectionEditor.Height < 50) SelectionEditor.Invoke((MethodInvoker)delegate { SelectionEditor.Height += 6; });
                        await Task.Delay(10); }
                    TopPanel.Invoke((MethodInvoker)delegate { TopPanel.Height = 50; });
                    SelectionEditor.Invoke((MethodInvoker)delegate { SelectionEditor.Height = 50; }); } catch (Exception) { } }));
            thread.Start(); }

        private void StickyNote_Deactivate(object sender, EventArgs e) {
            Focus();
            Thread thread = new Thread(new ThreadStart(async delegate { 
                try {
                    foreach (Control control in TopPanel.Controls)
                        control.Invoke((MethodInvoker)delegate { control.Visible = false; });
                    for (int i = 0; i < 8; i++) {
                        TopPanel.Invoke((MethodInvoker)delegate { TopPanel.Height -= 5; });
                        SelectionEditor.Invoke((MethodInvoker)delegate { SelectionEditor.Height -= 6; });
                        await Task.Delay(10); }
                    TopPanel.Invoke((MethodInvoker)delegate { TopPanel.Height = 10; });
                    SelectionEditor.Invoke((MethodInvoker)delegate { SelectionEditor.Height = 0; }); } catch (Exception) { } }));
            thread.Start(); }

        private async void NoteShown(object sender, EventArgs e) {
            if (StartLeft >= 0 && StartTop >= 0) Location = new Point(StartLeft, StartTop);
            if (NoteShouldntExist) Hide(); NoteText.Focus();

            await Task.Delay(200);
            StickyNote_Activated(this, new EventArgs()); Focus(); }

        private static string GetBetween(string Source, string Start, string End) {
            int StartI, EndI;
            if (Source.Contains(Start) && Source.Contains(End)) {
                if (Source.Substring(Source.IndexOf(Start)).Contains(End)) {
                    try {
                        StartI = Source.IndexOf(Start, 0) + Start.Length;
                        EndI = Source.IndexOf(End, StartI);
                        return Source.Substring(StartI, EndI - StartI); } catch (ArgumentOutOfRangeException) { return ""; } } else return ""; } else return ""; }

        private bool Edited = false;
        private void NoteTextUpdated(object sender, EventArgs e) { Edited = true; }
        private string GetLatestTag() {
            try {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://api.github.com/repos/{repo}/releases/latest");
                request.Method = "GET"; request.UserAgent = "Better Sticky Notes AutoUpdate"; request.Accept = "application/json";
                StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream());

                return GetBetween(reader.ReadToEnd(), "\"tag_name\":\"", "\""); } catch (Exception e) { Console.WriteLine($"{e.Message}"); }
            return ""; }

        private void UpdateProgram(string TagName) {
            try {
                // download update
                new WebClient().DownloadFile($"https://github.com/{repo}/releases/download/{TagName}/Better.Sticky.Notes.exe", $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\Better Sticky Notes.new.exe");

                // create a batch file to override current version with update then delete itself after 500ms
                File.WriteAllText($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\update.bat", $"@echo off\nping 127.0.0.1 -n 1 -w 500> nul\ndel \"{Assembly.GetExecutingAssembly().Location}\"\nrename \"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\Better Sticky Notes.new.exe\" \"Better Sticky Notes.exe\"\nstart \"\" \"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\Better Sticky Notes.exe\"\n(goto) 2>nul & del \"%~f0\"");

                // run the batch file and immediately terminate process
                Process.Start($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\update.bat");
                Process.GetCurrentProcess().Kill();
            } catch (Exception e) { Console.WriteLine($"failed to auto-update due to {e.Message}!"); } }

        private void StartSave(object sender, EventArgs e) {
            if (NoteShouldntExist) return;
            if (!Edited) return;
            else Edited = false;

            if (!File.Exists(NoteDirectory)) {
                if (!Directory.Exists($"{RoamingAppData}\\dmbk\\Better Sticky Notes"))
                    Directory.CreateDirectory($"{RoamingAppData}\\dmbk\\Better Sticky Notes");

                Random rng = new Random();
                int NoteId = rng.Next(100000000, 1000000000); // allows for 899,999,999 possible notes to exist

                // prevent duplicate notes in the very small chance it already exists, will freeze if you have every possible note already existing, so basically impossible
                while (File.Exists($"{RoamingAppData}\\dmbk\\Better Sticky Notes\\{NoteId}.txt")) NoteId = rng.Next(100000000, 1000000000);
                NoteDirectory = $"{RoamingAppData}\\dmbk\\Better Sticky Notes\\{NoteId}.txt"; }

            File.WriteAllText($"{NoteDirectory.Substring(0, NoteDirectory.Length - 4)}.data", $"{Width}\n{Height}\n{Left}\n{Top}\n{CurrentTheme.ToString()}");
            NoteText.SaveFile(NoteDirectory, RichTextBoxStreamType.RichText); }

        private void DeleteCurrentNote(object sender, EventArgs e) {
            NoteText.Focus();

            if (!Directory.Exists($"{RoamingAppData}\\dmbk"))
                Directory.CreateDirectory($"{RoamingAppData}\\dmbk");
            if (!Directory.Exists($"{RoamingAppData}\\dmbk\\Better Sticky Notes"))
                Directory.CreateDirectory($"{RoamingAppData}\\dmbk\\Better Sticky Notes");

            if (File.Exists(NoteDirectory)) { File.Delete(NoteDirectory); File.Delete($"{NoteDirectory.Substring(0, NoteDirectory.Length - 4)}.data"); }
            Close(); }

        private void NoteUpdated(object sender, EventArgs e) { Edited = true;
            foreach (Control control in SelectionEditor.Controls)
                if (control.GetType() == typeof(CheckBox)) control.Width = (int)Math.Floor(Width / 6f);
                else control.Width = (int)Math.Floor(Width / 12f);

            SelectionEditor.Visible = Height >= 150; }

        private void CreateNewNote(object sender, EventArgs e) {
            NoteText.Focus(); new StickyNote("", false).Show(); }

        private void CycleVisualTheme(object sender, EventArgs e) => TopSubPanel.Visible = !TopSubPanel.Visible;

        /*private void CycleVisualTheme(object sender, EventArgs e) {
            ThemeIndex++; if (Themes.Length <= ThemeIndex) ThemeIndex = 0; Edited = true;
            PathGradientBrush pgb = new PathGradientBrush(new PointF[] { new PointF(0, 0), new PointF(Width, 0), new PointF(Width, 50), new PointF(0, Height) }) {
                CenterColor = Themes[ThemeIndex].Color1,
                CenterPoint = new PointF(0, 0),
                SurroundColors = new Color[] { Themes[ThemeIndex].Color2 }};

            Bitmap bitmap = new Bitmap(TopPanel.Width, 50);
            using (Graphics g = Graphics.FromImage(bitmap)) {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.FillRectangle(pgb, new RectangleF(0, 0, bitmap.Width, bitmap.Height)); }
            TopPanel.BackgroundImage = bitmap; }*/

        private void CloseIntegrity_Tick(object sender, EventArgs e) {
            if (Application.OpenForms.Count <= (NoteShouldntExist ? 1 : 0)) Process.GetCurrentProcess().Kill(); /* if nothing is open, kill it */ }

        float aS = 0;
        bool aR = true;
        private Dictionary<Tuple<Color, Color, float>, Bitmap> AnimationCache = new Dictionary<Tuple<Color, Color, float>, Bitmap>();
        private void AnimationClock_Tick(object sender, EventArgs e) {
            // dispose image (pre-cache solution)
            // if (TopPanel.BackgroundImage != null) TopPanel.BackgroundImage.Dispose();
            try {
                if (!AnimationCache.ContainsKey(new Tuple<Color, Color, float>(CurrentTheme.Color1, CurrentTheme.Color2, aS))) {
                    Bitmap fullbitmap = new Bitmap(TopPanel.Width, 50);
                    using (Bitmap bitmap = new Bitmap(TopPanel.Width, 3)) {
                        using (Graphics g = Graphics.FromImage(bitmap)) {
                            g.SmoothingMode = SmoothingMode.HighQuality;
                            PathGradientBrush pgb = new PathGradientBrush(new PointF[] { new PointF(0, 0), new PointF(Width, 0), new PointF(Width, 2), new PointF(0, 2) }) {
                                CenterColor = CurrentTheme.Color1,
                                CenterPoint = new PointF(TopPanel.Width * aS, 1f),
                                SurroundColors = new Color[] { CurrentTheme.Color2 }, WrapMode = WrapMode.Clamp };
                            g.FillRectangle(pgb, new RectangleF(0, 0, bitmap.Width, bitmap.Height)); }

                        using (Graphics g = Graphics.FromImage(fullbitmap)) {
                            g.SmoothingMode = SmoothingMode.HighSpeed;
                            g.CompositingQuality = CompositingQuality.HighSpeed;
                            g.CompositingMode = CompositingMode.SourceCopy;
                            g.InterpolationMode = InterpolationMode.NearestNeighbor;
                            Bitmap temp = bitmap.Clone(new RectangleF(0, 1, bitmap.Width, 1), bitmap.PixelFormat);
                            g.DrawImage(temp, new RectangleF(0, 0, fullbitmap.Width, fullbitmap.Height));
                            g.DrawImage(temp, new RectangleF(0, fullbitmap.Height / 2, fullbitmap.Width, fullbitmap.Height));
                            temp.Dispose(); } }

                    AnimationCache.Add(new Tuple<Color, Color, float>(CurrentTheme.Color1, CurrentTheme.Color2, aS), fullbitmap);
                    TopPanel.BackgroundImage = fullbitmap;
                } else TopPanel.BackgroundImage = AnimationCache[new Tuple<Color, Color, float>(CurrentTheme.Color1, CurrentTheme.Color2, aS)];
                if (aR) { aS += .05f; aR = aS < 1; } else { aS -= .05f; aR = aS < .05f; }
            } catch {}}

        private void NoteText_SelectionChanged(object sender, EventArgs e) {
            SelectionBolded.Checked = NoteText.SelectionFont.Bold;
            SelectionItalic.Checked = NoteText.SelectionFont.Italic;
            SelectionUnderlined.Checked = NoteText.SelectionFont.Underline;
            SelectionStrikethrough.Checked = NoteText.SelectionFont.Strikeout;
            SelectionBulleted.Checked = NoteText.SelectionBullet;
            SelectionColour.BackColor = NoteText.SelectionColor; }

        private void ToggleStyle(FontStyle Style) {
            FontStyle style = NoteText.SelectionFont.Style & ~Style;
            if (SelectionBolded.Checked) style |= Style;
            NoteText.SelectionFont = new Font(NoteText.SelectionFont, style);
            NoteText.Focus(); }

        private void ToggleBold(object sender, EventArgs e) => ToggleStyle(FontStyle.Bold);
        private void ToggleItalic(object sender, EventArgs e) => ToggleStyle(FontStyle.Italic);
        private void ToggleUnderline(object sender, EventArgs e) => ToggleStyle(FontStyle.Underline);
        private void ToggleStriketrough(object sender, EventArgs e) => ToggleStyle(FontStyle.Strikeout);
        private void ToggleBullet(object sender, EventArgs e) {
            NoteText.SelectionBullet = !NoteText.SelectionBullet;
            NoteText.Focus(); }

        private void StartAdvTextEditing(object sender, EventArgs e) {
            if (MessageBox.Show("the advanced text editor is not complete in any way and does not function. it is highly recommended you do not continue.\n\ncontinue anyway?", "open incomplete advanced text editor?", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            AdvancedTextEditor editor = new AdvancedTextEditor();
            if (editor.ShowDialog() != DialogResult.OK) return; }

        private void ChangeColour(object sender, EventArgs e) {
            ColorDialog cd = new ColorDialog { FullOpen = true, AnyColor = true };
            if (cd.ShowDialog() == DialogResult.OK) {
                SelectionColour.BackColor = cd.Color;
                NoteText.SelectionColor = cd.Color; } }

        private void ChangeBackColour(object sender, EventArgs e) {
            ColorDialog cd = new ColorDialog { FullOpen = true, AnyColor = true };
            if (cd.ShowDialog() == DialogResult.OK) {
                SelectionBackColour.BackColor = cd.Color;
                NoteText.SelectionBackColor = cd.Color; } }

        private void PresetTheme(object sender, EventArgs e) {
            try {
                PictureBox pb = sender as PictureBox;
                int _ = 7 - Convert.ToInt32(pb.Name.Last().ToString());
                Console.WriteLine($"loading theme {_:N0}");
                CurrentTheme = Themes[_];
                Edited = true;
                PathGradientBrush pgb = new PathGradientBrush(new PointF[] { new PointF(0, 0), new PointF(Width, 0), new PointF(Width, 50), new PointF(0, Height) }) {
                    CenterColor = CurrentTheme.Color1,
                    CenterPoint = new PointF(0, 0),
                    SurroundColors = new Color[] { CurrentTheme.Color2 } };
                CustomTheme1.BackColor = CurrentTheme.Color1;
                CustomTheme2.BackColor = CurrentTheme.Color2;

                Bitmap bitmap = new Bitmap(TopPanel.Width, 50);
                using (Graphics g = Graphics.FromImage(bitmap)) {
                    g.SmoothingMode = SmoothingMode.HighQuality;
                    g.FillRectangle(pgb, new RectangleF(0, 0, bitmap.Width, bitmap.Height)); }
                TopPanel.BackgroundImage = bitmap; } catch {}}

        private void CustomThemeSet1(object sender, EventArgs e) {
            ColorDialog cd = new ColorDialog() { FullOpen = true, AnyColor = true, Color = CurrentTheme.Color1 };
            if (cd.ShowDialog() != DialogResult.OK) return;
            CurrentTheme = new NoteTheme(
                cd.Color.R, cd.Color.G, cd.Color.B, 
                CurrentTheme.Color2.R, CurrentTheme.Color2.G, CurrentTheme.Color2.B);
            CustomTheme1.BackColor = cd.Color;
            AnimationClock_Tick(this, e); }

        private void CustomThemeSet2(object sender, EventArgs e) {
            ColorDialog cd = new ColorDialog() { FullOpen = true, AnyColor = true, Color = CurrentTheme.Color2 };
            if (cd.ShowDialog() != DialogResult.OK) return;
            CurrentTheme = new NoteTheme(
                CurrentTheme.Color1.R, CurrentTheme.Color1.G, CurrentTheme.Color1.B,
                cd.Color.R, cd.Color.G, cd.Color.B);
            CustomTheme2.BackColor = cd.Color;
            AnimationClock_Tick(this, e); }

        private void Minimise(object sender, EventArgs e) => WindowState = FormWindowState.Minimized; }}
    