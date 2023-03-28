
namespace Better_Sticky_Notes {
    partial class StickyNote {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StickyNote));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.AntiFlickerButton = new System.Windows.Forms.Button();
            this.MinimiseNote = new System.Windows.Forms.Button();
            this.CycleTheme = new System.Windows.Forms.Button();
            this.CreateNote = new System.Windows.Forms.Button();
            this.DeleteNote = new System.Windows.Forms.Button();
            this.NoteText = new System.Windows.Forms.RichTextBox();
            this.ContentsPanel = new System.Windows.Forms.Panel();
            this.TopSubPanel = new System.Windows.Forms.Panel();
            this.CustomTheme2 = new System.Windows.Forms.Button();
            this.CustomTheme1 = new System.Windows.Forms.Button();
            this.DividerPreset = new System.Windows.Forms.Panel();
            this.Preset7 = new System.Windows.Forms.PictureBox();
            this.Preset6 = new System.Windows.Forms.PictureBox();
            this.Preset5 = new System.Windows.Forms.PictureBox();
            this.Preset4 = new System.Windows.Forms.PictureBox();
            this.Preset3 = new System.Windows.Forms.PictureBox();
            this.Preset2 = new System.Windows.Forms.PictureBox();
            this.Preset1 = new System.Windows.Forms.PictureBox();
            this.SelectionEditor = new System.Windows.Forms.Panel();
            this.SelectionBackColour = new System.Windows.Forms.Panel();
            this.SelectionColour = new System.Windows.Forms.Panel();
            this.SelectionBulleted = new System.Windows.Forms.CheckBox();
            this.SelectionStrikethrough = new System.Windows.Forms.CheckBox();
            this.SelectionUnderlined = new System.Windows.Forms.CheckBox();
            this.SelectionItalic = new System.Windows.Forms.CheckBox();
            this.SelectionBolded = new System.Windows.Forms.CheckBox();
            this.SaveTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseIntegrity = new System.Windows.Forms.Timer(this.components);
            this.AnimationClock = new System.Windows.Forms.Timer(this.components);
            this.TopPanel.SuspendLayout();
            this.ContentsPanel.SuspendLayout();
            this.TopSubPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Preset7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Preset6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Preset5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Preset4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Preset3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Preset2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Preset1)).BeginInit();
            this.SelectionEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopPanel.Controls.Add(this.AntiFlickerButton);
            this.TopPanel.Controls.Add(this.MinimiseNote);
            this.TopPanel.Controls.Add(this.CycleTheme);
            this.TopPanel.Controls.Add(this.CreateNote);
            this.TopPanel.Controls.Add(this.DeleteNote);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.MaximumSize = new System.Drawing.Size(0, 50);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(243, 50);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // AntiFlickerButton
            // 
            this.AntiFlickerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AntiFlickerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AntiFlickerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AntiFlickerButton.FlatAppearance.BorderSize = 0;
            this.AntiFlickerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AntiFlickerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AntiFlickerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AntiFlickerButton.Font = new System.Drawing.Font("Corbel", 16F);
            this.AntiFlickerButton.Location = new System.Drawing.Point(100, 0);
            this.AntiFlickerButton.Name = "AntiFlickerButton";
            this.AntiFlickerButton.Size = new System.Drawing.Size(43, 50);
            this.AntiFlickerButton.TabIndex = 3;
            this.AntiFlickerButton.Text = "\t";
            this.AntiFlickerButton.UseVisualStyleBackColor = false;
            this.AntiFlickerButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // MinimiseNote
            // 
            this.MinimiseNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MinimiseNote.Dock = System.Windows.Forms.DockStyle.Left;
            this.MinimiseNote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MinimiseNote.FlatAppearance.BorderSize = 0;
            this.MinimiseNote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MinimiseNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MinimiseNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimiseNote.Font = new System.Drawing.Font("Corbel", 16F);
            this.MinimiseNote.Location = new System.Drawing.Point(50, 0);
            this.MinimiseNote.Name = "MinimiseNote";
            this.MinimiseNote.Size = new System.Drawing.Size(50, 50);
            this.MinimiseNote.TabIndex = 4;
            this.MinimiseNote.Text = "🞃";
            this.MinimiseNote.UseVisualStyleBackColor = false;
            this.MinimiseNote.Visible = false;
            this.MinimiseNote.Click += new System.EventHandler(this.Minimise);
            // 
            // CycleTheme
            // 
            this.CycleTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CycleTheme.Dock = System.Windows.Forms.DockStyle.Left;
            this.CycleTheme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CycleTheme.FlatAppearance.BorderSize = 0;
            this.CycleTheme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CycleTheme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CycleTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CycleTheme.Font = new System.Drawing.Font("Corbel", 16F);
            this.CycleTheme.Location = new System.Drawing.Point(0, 0);
            this.CycleTheme.Name = "CycleTheme";
            this.CycleTheme.Size = new System.Drawing.Size(50, 50);
            this.CycleTheme.TabIndex = 2;
            this.CycleTheme.Text = "︙";
            this.CycleTheme.UseVisualStyleBackColor = false;
            this.CycleTheme.Click += new System.EventHandler(this.CycleVisualTheme);
            // 
            // CreateNote
            // 
            this.CreateNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CreateNote.Dock = System.Windows.Forms.DockStyle.Right;
            this.CreateNote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CreateNote.FlatAppearance.BorderSize = 0;
            this.CreateNote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CreateNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CreateNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNote.Font = new System.Drawing.Font("Corbel", 16F);
            this.CreateNote.Location = new System.Drawing.Point(143, 0);
            this.CreateNote.Name = "CreateNote";
            this.CreateNote.Size = new System.Drawing.Size(50, 50);
            this.CreateNote.TabIndex = 1;
            this.CreateNote.Text = "＋";
            this.CreateNote.UseVisualStyleBackColor = false;
            this.CreateNote.Click += new System.EventHandler(this.CreateNewNote);
            // 
            // DeleteNote
            // 
            this.DeleteNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DeleteNote.Dock = System.Windows.Forms.DockStyle.Right;
            this.DeleteNote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DeleteNote.FlatAppearance.BorderSize = 0;
            this.DeleteNote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DeleteNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DeleteNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteNote.Font = new System.Drawing.Font("Corbel", 16F);
            this.DeleteNote.Location = new System.Drawing.Point(193, 0);
            this.DeleteNote.Name = "DeleteNote";
            this.DeleteNote.Size = new System.Drawing.Size(50, 50);
            this.DeleteNote.TabIndex = 0;
            this.DeleteNote.Text = "X";
            this.DeleteNote.UseVisualStyleBackColor = false;
            this.DeleteNote.Click += new System.EventHandler(this.DeleteCurrentNote);
            // 
            // NoteText
            // 
            this.NoteText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NoteText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoteText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoteText.Font = new System.Drawing.Font("Corbel", 14F);
            this.NoteText.ForeColor = System.Drawing.Color.White;
            this.NoteText.Location = new System.Drawing.Point(0, 100);
            this.NoteText.Name = "NoteText";
            this.NoteText.Size = new System.Drawing.Size(243, 143);
            this.NoteText.TabIndex = 1;
            this.NoteText.Text = "";
            this.NoteText.SelectionChanged += new System.EventHandler(this.NoteText_SelectionChanged);
            this.NoteText.TextChanged += new System.EventHandler(this.NoteTextUpdated);
            // 
            // ContentsPanel
            // 
            this.ContentsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentsPanel.Controls.Add(this.NoteText);
            this.ContentsPanel.Controls.Add(this.TopSubPanel);
            this.ContentsPanel.Controls.Add(this.TopPanel);
            this.ContentsPanel.Controls.Add(this.SelectionEditor);
            this.ContentsPanel.Location = new System.Drawing.Point(3, 3);
            this.ContentsPanel.Name = "ContentsPanel";
            this.ContentsPanel.Size = new System.Drawing.Size(243, 293);
            this.ContentsPanel.TabIndex = 2;
            // 
            // TopSubPanel
            // 
            this.TopSubPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.TopSubPanel.Controls.Add(this.CustomTheme2);
            this.TopSubPanel.Controls.Add(this.CustomTheme1);
            this.TopSubPanel.Controls.Add(this.DividerPreset);
            this.TopSubPanel.Controls.Add(this.Preset7);
            this.TopSubPanel.Controls.Add(this.Preset6);
            this.TopSubPanel.Controls.Add(this.Preset5);
            this.TopSubPanel.Controls.Add(this.Preset4);
            this.TopSubPanel.Controls.Add(this.Preset3);
            this.TopSubPanel.Controls.Add(this.Preset2);
            this.TopSubPanel.Controls.Add(this.Preset1);
            this.TopSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopSubPanel.Location = new System.Drawing.Point(0, 50);
            this.TopSubPanel.Name = "TopSubPanel";
            this.TopSubPanel.Size = new System.Drawing.Size(243, 50);
            this.TopSubPanel.TabIndex = 3;
            this.TopSubPanel.Visible = false;
            // 
            // CustomTheme2
            // 
            this.CustomTheme2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomTheme2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CustomTheme2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomTheme2.Location = new System.Drawing.Point(190, 25);
            this.CustomTheme2.Name = "CustomTheme2";
            this.CustomTheme2.Size = new System.Drawing.Size(53, 25);
            this.CustomTheme2.TabIndex = 8;
            this.CustomTheme2.UseVisualStyleBackColor = true;
            this.CustomTheme2.Click += new System.EventHandler(this.CustomThemeSet2);
            // 
            // CustomTheme1
            // 
            this.CustomTheme1.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomTheme1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CustomTheme1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomTheme1.Location = new System.Drawing.Point(190, 0);
            this.CustomTheme1.Name = "CustomTheme1";
            this.CustomTheme1.Size = new System.Drawing.Size(53, 25);
            this.CustomTheme1.TabIndex = 7;
            this.CustomTheme1.UseVisualStyleBackColor = true;
            this.CustomTheme1.Click += new System.EventHandler(this.CustomThemeSet1);
            // 
            // DividerPreset
            // 
            this.DividerPreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DividerPreset.Dock = System.Windows.Forms.DockStyle.Left;
            this.DividerPreset.Location = new System.Drawing.Point(189, 0);
            this.DividerPreset.Name = "DividerPreset";
            this.DividerPreset.Size = new System.Drawing.Size(1, 50);
            this.DividerPreset.TabIndex = 6;
            this.DividerPreset.Visible = false;
            // 
            // Preset7
            // 
            this.Preset7.Dock = System.Windows.Forms.DockStyle.Left;
            this.Preset7.Location = new System.Drawing.Point(162, 0);
            this.Preset7.Name = "Preset7";
            this.Preset7.Size = new System.Drawing.Size(27, 50);
            this.Preset7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Preset7.TabIndex = 9;
            this.Preset7.TabStop = false;
            this.Preset7.Click += new System.EventHandler(this.PresetTheme);
            // 
            // Preset6
            // 
            this.Preset6.Dock = System.Windows.Forms.DockStyle.Left;
            this.Preset6.Location = new System.Drawing.Point(135, 0);
            this.Preset6.Name = "Preset6";
            this.Preset6.Size = new System.Drawing.Size(27, 50);
            this.Preset6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Preset6.TabIndex = 5;
            this.Preset6.TabStop = false;
            this.Preset6.Click += new System.EventHandler(this.PresetTheme);
            // 
            // Preset5
            // 
            this.Preset5.Dock = System.Windows.Forms.DockStyle.Left;
            this.Preset5.Location = new System.Drawing.Point(108, 0);
            this.Preset5.Name = "Preset5";
            this.Preset5.Size = new System.Drawing.Size(27, 50);
            this.Preset5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Preset5.TabIndex = 4;
            this.Preset5.TabStop = false;
            this.Preset5.Click += new System.EventHandler(this.PresetTheme);
            // 
            // Preset4
            // 
            this.Preset4.Dock = System.Windows.Forms.DockStyle.Left;
            this.Preset4.Location = new System.Drawing.Point(81, 0);
            this.Preset4.Name = "Preset4";
            this.Preset4.Size = new System.Drawing.Size(27, 50);
            this.Preset4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Preset4.TabIndex = 3;
            this.Preset4.TabStop = false;
            this.Preset4.Click += new System.EventHandler(this.PresetTheme);
            // 
            // Preset3
            // 
            this.Preset3.Dock = System.Windows.Forms.DockStyle.Left;
            this.Preset3.Location = new System.Drawing.Point(54, 0);
            this.Preset3.Name = "Preset3";
            this.Preset3.Size = new System.Drawing.Size(27, 50);
            this.Preset3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Preset3.TabIndex = 2;
            this.Preset3.TabStop = false;
            this.Preset3.Click += new System.EventHandler(this.PresetTheme);
            // 
            // Preset2
            // 
            this.Preset2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Preset2.Location = new System.Drawing.Point(27, 0);
            this.Preset2.Name = "Preset2";
            this.Preset2.Size = new System.Drawing.Size(27, 50);
            this.Preset2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Preset2.TabIndex = 1;
            this.Preset2.TabStop = false;
            this.Preset2.Click += new System.EventHandler(this.PresetTheme);
            // 
            // Preset1
            // 
            this.Preset1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Preset1.Location = new System.Drawing.Point(0, 0);
            this.Preset1.Name = "Preset1";
            this.Preset1.Size = new System.Drawing.Size(27, 50);
            this.Preset1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Preset1.TabIndex = 0;
            this.Preset1.TabStop = false;
            this.Preset1.Click += new System.EventHandler(this.PresetTheme);
            // 
            // SelectionEditor
            // 
            this.SelectionEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.SelectionEditor.Controls.Add(this.SelectionBackColour);
            this.SelectionEditor.Controls.Add(this.SelectionColour);
            this.SelectionEditor.Controls.Add(this.SelectionBulleted);
            this.SelectionEditor.Controls.Add(this.SelectionStrikethrough);
            this.SelectionEditor.Controls.Add(this.SelectionUnderlined);
            this.SelectionEditor.Controls.Add(this.SelectionItalic);
            this.SelectionEditor.Controls.Add(this.SelectionBolded);
            this.SelectionEditor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SelectionEditor.Location = new System.Drawing.Point(0, 243);
            this.SelectionEditor.Name = "SelectionEditor";
            this.SelectionEditor.Size = new System.Drawing.Size(243, 50);
            this.SelectionEditor.TabIndex = 2;
            // 
            // SelectionBackColour
            // 
            this.SelectionBackColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SelectionBackColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectionBackColour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectionBackColour.Location = new System.Drawing.Point(222, 0);
            this.SelectionBackColour.Name = "SelectionBackColour";
            this.SelectionBackColour.Size = new System.Drawing.Size(21, 50);
            this.SelectionBackColour.TabIndex = 6;
            this.SelectionBackColour.Click += new System.EventHandler(this.ChangeBackColour);
            // 
            // SelectionColour
            // 
            this.SelectionColour.BackColor = System.Drawing.Color.White;
            this.SelectionColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectionColour.Dock = System.Windows.Forms.DockStyle.Left;
            this.SelectionColour.Location = new System.Drawing.Point(200, 0);
            this.SelectionColour.Name = "SelectionColour";
            this.SelectionColour.Size = new System.Drawing.Size(22, 50);
            this.SelectionColour.TabIndex = 5;
            this.SelectionColour.Click += new System.EventHandler(this.ChangeColour);
            // 
            // SelectionBulleted
            // 
            this.SelectionBulleted.Appearance = System.Windows.Forms.Appearance.Button;
            this.SelectionBulleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.SelectionBulleted.Dock = System.Windows.Forms.DockStyle.Left;
            this.SelectionBulleted.FlatAppearance.BorderSize = 0;
            this.SelectionBulleted.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.SelectionBulleted.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.SelectionBulleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectionBulleted.Font = new System.Drawing.Font("Corbel", 14F);
            this.SelectionBulleted.Location = new System.Drawing.Point(160, 0);
            this.SelectionBulleted.Name = "SelectionBulleted";
            this.SelectionBulleted.Size = new System.Drawing.Size(40, 50);
            this.SelectionBulleted.TabIndex = 4;
            this.SelectionBulleted.Text = "•";
            this.SelectionBulleted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelectionBulleted.UseVisualStyleBackColor = false;
            this.SelectionBulleted.Click += new System.EventHandler(this.ToggleBullet);
            // 
            // SelectionStrikethrough
            // 
            this.SelectionStrikethrough.Appearance = System.Windows.Forms.Appearance.Button;
            this.SelectionStrikethrough.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.SelectionStrikethrough.Dock = System.Windows.Forms.DockStyle.Left;
            this.SelectionStrikethrough.FlatAppearance.BorderSize = 0;
            this.SelectionStrikethrough.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.SelectionStrikethrough.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.SelectionStrikethrough.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectionStrikethrough.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionStrikethrough.Location = new System.Drawing.Point(120, 0);
            this.SelectionStrikethrough.Name = "SelectionStrikethrough";
            this.SelectionStrikethrough.Size = new System.Drawing.Size(40, 50);
            this.SelectionStrikethrough.TabIndex = 3;
            this.SelectionStrikethrough.Text = "s";
            this.SelectionStrikethrough.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelectionStrikethrough.UseVisualStyleBackColor = false;
            this.SelectionStrikethrough.Click += new System.EventHandler(this.ToggleStriketrough);
            // 
            // SelectionUnderlined
            // 
            this.SelectionUnderlined.Appearance = System.Windows.Forms.Appearance.Button;
            this.SelectionUnderlined.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.SelectionUnderlined.Dock = System.Windows.Forms.DockStyle.Left;
            this.SelectionUnderlined.FlatAppearance.BorderSize = 0;
            this.SelectionUnderlined.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.SelectionUnderlined.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.SelectionUnderlined.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectionUnderlined.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionUnderlined.Location = new System.Drawing.Point(80, 0);
            this.SelectionUnderlined.Name = "SelectionUnderlined";
            this.SelectionUnderlined.Size = new System.Drawing.Size(40, 50);
            this.SelectionUnderlined.TabIndex = 0;
            this.SelectionUnderlined.Text = "u";
            this.SelectionUnderlined.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelectionUnderlined.UseVisualStyleBackColor = false;
            this.SelectionUnderlined.Click += new System.EventHandler(this.ToggleUnderline);
            // 
            // SelectionItalic
            // 
            this.SelectionItalic.Appearance = System.Windows.Forms.Appearance.Button;
            this.SelectionItalic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.SelectionItalic.Dock = System.Windows.Forms.DockStyle.Left;
            this.SelectionItalic.FlatAppearance.BorderSize = 0;
            this.SelectionItalic.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.SelectionItalic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.SelectionItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectionItalic.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionItalic.Location = new System.Drawing.Point(40, 0);
            this.SelectionItalic.Name = "SelectionItalic";
            this.SelectionItalic.Size = new System.Drawing.Size(40, 50);
            this.SelectionItalic.TabIndex = 2;
            this.SelectionItalic.Text = "i";
            this.SelectionItalic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelectionItalic.UseVisualStyleBackColor = false;
            this.SelectionItalic.Click += new System.EventHandler(this.ToggleItalic);
            // 
            // SelectionBolded
            // 
            this.SelectionBolded.Appearance = System.Windows.Forms.Appearance.Button;
            this.SelectionBolded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.SelectionBolded.Dock = System.Windows.Forms.DockStyle.Left;
            this.SelectionBolded.FlatAppearance.BorderSize = 0;
            this.SelectionBolded.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.SelectionBolded.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.SelectionBolded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectionBolded.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionBolded.Location = new System.Drawing.Point(0, 0);
            this.SelectionBolded.Name = "SelectionBolded";
            this.SelectionBolded.Size = new System.Drawing.Size(40, 50);
            this.SelectionBolded.TabIndex = 1;
            this.SelectionBolded.Text = "B";
            this.SelectionBolded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelectionBolded.UseVisualStyleBackColor = false;
            this.SelectionBolded.Click += new System.EventHandler(this.ToggleBold);
            // 
            // SaveTimer
            // 
            this.SaveTimer.Enabled = true;
            this.SaveTimer.Interval = 1000;
            this.SaveTimer.Tick += new System.EventHandler(this.StartSave);
            // 
            // CloseIntegrity
            // 
            this.CloseIntegrity.Interval = 1000;
            this.CloseIntegrity.Tick += new System.EventHandler(this.CloseIntegrity_Tick);
            // 
            // AnimationClock
            // 
            this.AnimationClock.Enabled = true;
            this.AnimationClock.Interval = 60;
            this.AnimationClock.Tick += new System.EventHandler(this.AnimationClock_Tick);
            // 
            // StickyNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(250, 300);
            this.Controls.Add(this.ContentsPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Corbel", 18F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MinimumSize = new System.Drawing.Size(200, 100);
            this.Name = "StickyNote";
            this.Text = "Sticky Note";
            this.Activated += new System.EventHandler(this.StickyNote_Activated);
            this.Deactivate += new System.EventHandler(this.StickyNote_Deactivate);
            this.Load += new System.EventHandler(this.NoteLoaded);
            this.Shown += new System.EventHandler(this.NoteShown);
            this.Move += new System.EventHandler(this.NoteUpdated);
            this.Resize += new System.EventHandler(this.NoteUpdated);
            this.TopPanel.ResumeLayout(false);
            this.ContentsPanel.ResumeLayout(false);
            this.TopSubPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Preset7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Preset6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Preset5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Preset4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Preset3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Preset2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Preset1)).EndInit();
            this.SelectionEditor.ResumeLayout(false);
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.RichTextBox NoteText;
        private System.Windows.Forms.Panel ContentsPanel;
        private System.Windows.Forms.Button DeleteNote;
        private System.Windows.Forms.Timer SaveTimer;
        private System.Windows.Forms.Button CreateNote;
        private System.Windows.Forms.Button CycleTheme;
        private System.Windows.Forms.Timer CloseIntegrity;
        private System.Windows.Forms.Timer AnimationClock;
        private System.Windows.Forms.Panel SelectionEditor;
        private System.Windows.Forms.CheckBox SelectionUnderlined;
        private System.Windows.Forms.CheckBox SelectionItalic;
        private System.Windows.Forms.CheckBox SelectionBolded;
        private System.Windows.Forms.CheckBox SelectionStrikethrough;
        private System.Windows.Forms.CheckBox SelectionBulleted;
        private System.Windows.Forms.Button AntiFlickerButton;
        private System.Windows.Forms.Button MinimiseNote;
        private System.Windows.Forms.Panel SelectionColour;
        private System.Windows.Forms.Panel SelectionBackColour;
        private System.Windows.Forms.Panel TopSubPanel;
        private System.Windows.Forms.Button CustomTheme2;
        private System.Windows.Forms.Button CustomTheme1;
        private System.Windows.Forms.Panel DividerPreset;
        private System.Windows.Forms.PictureBox Preset6;
        private System.Windows.Forms.PictureBox Preset5;
        private System.Windows.Forms.PictureBox Preset4;
        private System.Windows.Forms.PictureBox Preset3;
        private System.Windows.Forms.PictureBox Preset2;
        private System.Windows.Forms.PictureBox Preset1;
        private System.Windows.Forms.PictureBox Preset7;
    }
    }

