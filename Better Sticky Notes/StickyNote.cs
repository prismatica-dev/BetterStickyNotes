﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Better_Sticky_Notes {
    public partial class StickyNote : Form {
        // if u are forking the project set this to your fork so the auto-updater checks your repo!
        // also if in your releases you upload the binary as anything other than 'Better.Sticky.Notes.exe' it will fail to update (or if you have a tag that isn't a valid version)
        private const string repo = "uDMBK/BetterStickyNotes";

        public StickyNote(string args, bool primary) { 
            PrimaryNote = primary; 
            string LatestTag = GetLatestTag();
            if (primary && LatestTag.Length > 0) if (Assembly.GetExecutingAssembly().GetName().Version < Version.Parse(LatestTag)) UpdateProgram(LatestTag);
            
            if (primary) {
                CreateShortcut();
                CreateStartMenuShortcut();
                try { using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true)) {
                    key.SetValue("BetterStickyNotes", Assembly.GetExecutingAssembly().Location); }} catch (Exception) {}}
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
                        if (NoteData.Length == 4 || NoteData.Length == 5) try {
                            Width = Convert.ToInt32(NoteData[0]);
                            Height = Convert.ToInt32(NoteData[1]);
                            StartLeft = Convert.ToInt32(NoteData[2]);
                            StartTop = Convert.ToInt32(NoteData[3]);
                            if (NoteData.Length == 5) // 0.1.0 compatibility
                            ThemeIndex = Math.Min(Math.Abs(Convert.ToInt32(NoteData[4])), Themes.Length - 1); } catch(Exception) { /*note is broken but will fix itself*/ }}}}}

        public class NoteTheme {
            public LinearGradientBrush GradientBrush { get; }
            public NoteTheme(int Red1, int Green1, int Blue1, int Red2, int Green2, int Blue2) {
                GradientBrush = new LinearGradientBrush(new PointF(0, 0), new PointF(250, 0), Color.FromArgb(Red1, Green1, Blue1), Color.FromArgb(Red2, Green2, Blue2)); }}

        public NoteTheme[] Themes = { 
            new NoteTheme(255, 165, 238, 237, 114, 255), 
            new NoteTheme(229, 183, 255, 212, 137, 255),
            new NoteTheme(164, 201, 255, 82, 152, 255),
            new NoteTheme(186, 255, 217, 74, 255, 153),
            new NoteTheme(255, 253, 165, 255, 249, 55),
            new NoteTheme(255, 220, 174, 255, 170, 57),
            new NoteTheme(255, 181, 181, 255, 48, 48) };

        public int StartLeft = -1;
        public int StartTop = -1;
        public int ThemeIndex = 0;
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
                using (StreamWriter writer = new StreamWriter($"{Environment.GetFolderPath(Environment.SpecialFolder.Startup)}\\BetterStickyNotes.url")) {
                    string app = Assembly.GetExecutingAssembly().Location;
                    writer.WriteLine("[InternetShortcut]");
                    writer.WriteLine("URL=file:///" + app);
                    writer.WriteLine("IconIndex=0");
                    string icon = app.Replace('\\', '/');
                    writer.WriteLine("IconFile=" + icon); }} catch(Exception) {}}
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
                    writer.WriteLine("IconFile=" + icon); }} catch(Exception) {}}

        private void LoadNote(string NoteDirectory) {
            if (File.Exists(NoteDirectory))
                new StickyNote(NoteDirectory, false).Show(); }

        private void NoteLoaded(object sender, EventArgs e) {
            if (NoteShouldntExist) return;
            Bitmap bitmap = new Bitmap(TopPanel.Width, 50);
            using (Graphics g = Graphics.FromImage(bitmap)) {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.FillRectangle(Themes[ThemeIndex].GradientBrush, new RectangleF(0, 0, bitmap.Width, bitmap.Height)); }
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
            if (NoteShouldntExist) Hide(); NoteText.Focus(); }
        private static string GetBetween(string Source, string Start, string End) {
            int StartI, EndI;
            if (Source.Contains(Start) && Source.Contains(End)) {
                if (Source.Substring(Source.IndexOf(Start)).Contains(End)) {
                    try {
                        StartI = Source.IndexOf(Start, 0) + Start.Length;
                        EndI = Source.IndexOf(End, StartI);
                        return Source.Substring(StartI, EndI - StartI); }
                    catch (ArgumentOutOfRangeException) { return ""; }}
                else return ""; }
            else return ""; }

        private bool Edited = false;
        private void NoteTextUpdated(object sender, EventArgs e) { Edited = true; }
        private string GetLatestTag() {
            try {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://api.github.com/repos/{repo}/releases/latest");
                request.Method = "GET"; request.UserAgent = "Better Sticky Notes Auto-Update"; request.Accept = "application/json";
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
                } catch (Exception e) { Console.WriteLine($"failed to auto-update due to {e.Message}!"); }}

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

            File.WriteAllText($"{NoteDirectory.Substring(0, NoteDirectory.Length - 4)}.data", $"{Width}\n{Height}\n{Left}\n{Top}\n{ThemeIndex}");
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
            NoteText.Focus(); new StickyNote("", false).Show(); }

        private void CycleVisualTheme(object sender, EventArgs e) {
            ThemeIndex++; if (Themes.Length <= ThemeIndex) ThemeIndex = 0; Edited = true;
            
            Bitmap bitmap = new Bitmap(TopPanel.Width, 50);
            using (Graphics g = Graphics.FromImage(bitmap)) {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.FillRectangle(Themes[ThemeIndex].GradientBrush, new RectangleF(0, 0, bitmap.Width, bitmap.Height)); }
            TopPanel.BackgroundImage = bitmap; }}}