using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Better_Sticky_Notes {
    public partial class AdvancedTextEditor : Form {
        public AdvancedTextEditor() { InitializeComponent(); }
        private void CloseEditor_Click(object sender, EventArgs e) { Close(); }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Drag(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); }}

        private void TypeChanged(object sender, EventArgs e) {
            if (WebSelect.Checked) LocationText.Text = "Url";
            else if (FileSelect.Checked) LocationText.Text = "File Path";
            else if (FixedSelect.Checked) LocationText.Text = "Value";
            else LocationText.Text = "Unknown";
            
            if (FixedSelect.Checked) { 
                ExtractionDataText.Visible = false; ExtractionDataStart.Visible = false; ExtractionDataEnd.Visible = false;
                RefreshInterval.Visible = false; RefreshIntervalText.Visible = false; }
            else {
                ExtractionDataText.Visible = true; ExtractionDataStart.Visible = true; ExtractionDataEnd.Visible = true;
                RefreshInterval.Visible = true; RefreshIntervalText.Visible = true; }}

        private void ChangePrimaryColour(object sender, EventArgs e) {
            ColorDialog cd = new ColorDialog { FullOpen = true, AnyColor = true };
            if (cd.ShowDialog() == DialogResult.OK)
                PrimaryColourPreview.BackColor = cd.Color; }

        private void ChangeSecondaryColour(object sender, EventArgs e) {
            ColorDialog cd = new ColorDialog { FullOpen = true, AnyColor = true };
            if (cd.ShowDialog() == DialogResult.OK)
                SecondaryColourPreview.BackColor = cd.Color; }

        private void RefreshInterval_TextChanged(object sender, EventArgs e) {
            RefreshInterval.Text = Regex.Replace(RefreshInterval.Text, "[^.0-9]", ""); }

        private void AddRawAsset(object sender, EventArgs e) {
            Color p = PrimaryColourPreview.BackColor;
            Color s = SecondaryColourPreview.BackColor;

            string asset = $"{(AssetAddDynamicText.Checked?"dynamic-text":(AssetAddImage.Checked?"image":"progress-bar"))}";
            string datatype = $"{(WebSelect.Checked?"web":(FileSelect.Checked?"file":"fixed"))}";

            RawText.Text += 
                $"[֎'asset':'{asset}'," +
                $"'data-type':'{datatype}'," +
                $"'data-location':'{LocationTextBox.Text}'," +
                $"'extraction':'start:{{{{{ExtractionDataStart.Text}}}}},end:{{{{{ExtractionDataEnd.Text}}}}}'," +
                $"'refresh-interval':'{RefreshInterval.Text}'," +
                $"'primary-color':'a:{p.A},r:{p.R},g:{p.G},b:{p.B}'," +
                $"'secondary-color':'a:{s.A},r:{s.R},g:{s.G},b:{s.B}'," +
                $"'style':'bold:{StyleBolded.Checked},italic:{StyleItalic.Checked},underline:{StyleUnderlined.Checked},strikeout:{StyleStrikeout.Checked}']"; }}}
