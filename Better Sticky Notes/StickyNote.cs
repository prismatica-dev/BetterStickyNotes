using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Better_Sticky_Notes {
    public partial class StickyNote : Form {
        public StickyNote(string args, bool primary) { 
            PrimaryNote = primary; 
            CreateShortcut();
            try { using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true)) {
                key.SetValue("AdRework", System.Reflection.Assembly.GetExecutingAssembly().Location); }} catch (Exception) {}
            InitializeComponent();

            if (primary) {
                string[] Notes = GetNotes();
                foreach (string note in Notes) LoadNote(note);
                if (Notes.Length > 0) NoteShouldntExist = true; }
            else { 
                NoteDirectory = args;
                if (NoteDirectory.Length > 4) {
                    if (File.Exists(args)) NoteText.Text = File.ReadAllText(args); 
                    if (File.Exists($"{args.Substring(0, args.Length - 4)}.data")) {
                        string[] NoteData = File.ReadAllText($"{args.Substring(0, args.Length - 4)}.data").Split('\n');
                        if (NoteData.Length == 4) try {
                            Width = Convert.ToInt32(NoteData[0]);
                            Height = Convert.ToInt32(NoteData[1]);
                            StartLeft = Convert.ToInt32(NoteData[2]);
                            StartTop = Convert.ToInt32(NoteData[3]); } catch(Exception) { /*note is broken*/ }}}}}

        public int StartLeft = -1;
        public int StartTop = -1;
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
        private void Drag(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); }}

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
                            else m.Result = (IntPtr)14; }
                        else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE)) {
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
                            else m.Result = (IntPtr)17; }}
                    return; }
            base.WndProc(ref m); }

        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000;
                cp.ExStyle |= 0x02000000; 
                return cp; }}

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
                string deskDir = Environment.GetFolderPath(Environment.SpecialFolder.Startup);

                using (StreamWriter writer = new StreamWriter($"{Environment.GetFolderPath(Environment.SpecialFolder.Startup)}\\BetterStickyNotes.url")) {
                    string app = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    writer.WriteLine("[InternetShortcut]");
                    writer.WriteLine("URL=file:///" + app);
                    writer.WriteLine("IconIndex=0");
                    string icon = app.Replace('\\', '/');
                    writer.WriteLine("IconFile=" + icon); }} catch(Exception) {}}

        private void LoadNote(string NoteDirectory) {
            if (File.Exists(NoteDirectory))
                new StickyNote(NoteDirectory, false).Show(); }

        private void NoteLoaded(object sender, EventArgs e) {
            if (NoteShouldntExist) return;
            Bitmap bitmap = new Bitmap(TopPanel.Width, 50);
            using (Graphics g = Graphics.FromImage(bitmap)) {
                g.SmoothingMode = SmoothingMode.HighQuality;
                LinearGradientBrush gb = new LinearGradientBrush(new PointF(0, 0), new PointF(Width, TopPanel.Height), Color.FromArgb(255, 165, 238), Color.FromArgb(237, 114, 255));
                g.FillRectangle(gb, new RectangleF(0, 0, bitmap.Width, bitmap.Height)); }
            TopPanel.BackgroundImage = bitmap; }

        private void StickyNote_Activated(object sender, EventArgs e) {
            Thread thread = new Thread(new ThreadStart(delegate { try { 
                for (int i = 0; i < 8; i++) { 
                    TopPanel.Invoke((MethodInvoker)delegate { TopPanel.Height += 5; });
                    Thread.Sleep(10); } 
                    TopPanel.Invoke((MethodInvoker)delegate { TopPanel.Height = 50; }); } catch (Exception) {}}));
            thread.Start(); }

        private void StickyNote_Deactivate(object sender, EventArgs e) {
            Thread thread = new Thread(new ThreadStart(delegate { try {
                for (int i = 0; i < 8; i++) { 
                    TopPanel.Invoke((MethodInvoker)delegate { TopPanel.Height -= 5; });
                    Thread.Sleep(10); } 
                    TopPanel.Invoke((MethodInvoker)delegate { TopPanel.Height = 10; }); } catch (Exception) {}}));
            thread.Start(); }

        private void NoteShown(object sender, EventArgs e) { 
            if (StartLeft >= 0 && StartTop >= 0) Location = new Point(StartLeft, StartTop);
            if (NoteShouldntExist) Hide(); }

        private bool Edited = false;
        private void NoteTextUpdated(object sender, EventArgs e) { Edited = true; }

        private void StartSave(object sender, EventArgs e) {
            if (NoteShouldntExist) return;
            if (!Edited) return;
            else Edited = false;

            if (!File.Exists(NoteDirectory)) {
                if (!Directory.Exists($"{RoamingAppData}\\dmbk"))
                    Directory.CreateDirectory($"{RoamingAppData}\\dmbk");
                if (!Directory.Exists($"{RoamingAppData}\\dmbk\\Better Sticky Notes"))
                    Directory.CreateDirectory($"{RoamingAppData}\\dmbk\\Better Sticky Notes");

                Random rng = new Random();
                int NoteId = rng.Next(100000000, 1000000000); // allows for 899,999,999 possible notes to exist

                // prevent duplicate notes in the very small chance it already exists, will freeze if you have every possible note already existing, so basically impossible
                while (File.Exists($"{RoamingAppData}\\dmbk\\Better Sticky Notes\\{NoteId}.txt")) NoteId = rng.Next(100000000, 1000000000);
                NoteDirectory = $"{RoamingAppData}\\dmbk\\Better Sticky Notes\\{NoteId}.txt"; }

            File.WriteAllText($"{NoteDirectory.Substring(0, NoteDirectory.Length - 4)}.data", $"{Width}\n{Height}\n{Left}\n{Top}");
            File.WriteAllText(NoteDirectory, NoteText.Text); }

        private void DeleteCurrentNote(object sender, EventArgs e) {
            NoteText.Focus(); 

            if (!Directory.Exists($"{RoamingAppData}\\dmbk"))
                Directory.CreateDirectory($"{RoamingAppData}\\dmbk");
            if (!Directory.Exists($"{RoamingAppData}\\dmbk\\Better Sticky Notes"))
                Directory.CreateDirectory($"{RoamingAppData}\\dmbk\\Better Sticky Notes");

            if (File.Exists(NoteDirectory)) { File.Delete(NoteDirectory); File.Delete($"{NoteDirectory.Substring(0, NoteDirectory.Length - 4)}.data"); }
            Close(); }

        private void NoteUpdated(object sender, EventArgs e) { Edited = true; }

        private void CreateNewNote(object sender, EventArgs e) {
            NoteText.Focus(); new StickyNote("", false).Show(); }}}