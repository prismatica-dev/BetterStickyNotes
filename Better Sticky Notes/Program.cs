using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Better_Sticky_Notes {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            var mutex = new System.Threading.Mutex(true, "BetterStickyNotes", out bool result);

            if (!result) Process.GetCurrentProcess().Kill();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StickyNote("", true));
            GC.KeepAlive(mutex); }}}
