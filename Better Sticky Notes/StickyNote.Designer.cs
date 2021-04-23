
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
            this.CycleTheme = new System.Windows.Forms.Button();
            this.CreateNote = new System.Windows.Forms.Button();
            this.DeleteNote = new System.Windows.Forms.Button();
            this.NoteText = new System.Windows.Forms.RichTextBox();
            this.ContentsPanel = new System.Windows.Forms.Panel();
            this.SaveTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseIntegrity = new System.Windows.Forms.Timer(this.components);
            this.TopPanel.SuspendLayout();
            this.ContentsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopPanel.Controls.Add(this.CycleTheme);
            this.TopPanel.Controls.Add(this.CreateNote);
            this.TopPanel.Controls.Add(this.DeleteNote);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.MaximumSize = new System.Drawing.Size(0, 50);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(248, 50);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // CycleTheme
            // 
            this.CycleTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CycleTheme.Dock = System.Windows.Forms.DockStyle.Left;
            this.CycleTheme.FlatAppearance.BorderSize = 0;
            this.CycleTheme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CycleTheme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CycleTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CycleTheme.Font = new System.Drawing.Font("Corbel", 16F);
            this.CycleTheme.Location = new System.Drawing.Point(0, 0);
            this.CycleTheme.Name = "CycleTheme";
            this.CycleTheme.Size = new System.Drawing.Size(50, 50);
            this.CycleTheme.TabIndex = 2;
            this.CycleTheme.Text = "\t︙";
            this.CycleTheme.UseVisualStyleBackColor = false;
            this.CycleTheme.Click += new System.EventHandler(this.CycleVisualTheme);
            // 
            // CreateNote
            // 
            this.CreateNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CreateNote.Dock = System.Windows.Forms.DockStyle.Right;
            this.CreateNote.FlatAppearance.BorderSize = 0;
            this.CreateNote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CreateNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CreateNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNote.Font = new System.Drawing.Font("Corbel", 16F);
            this.CreateNote.Location = new System.Drawing.Point(148, 0);
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
            this.DeleteNote.FlatAppearance.BorderSize = 0;
            this.DeleteNote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DeleteNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DeleteNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteNote.Font = new System.Drawing.Font("Corbel", 16F);
            this.DeleteNote.Location = new System.Drawing.Point(198, 0);
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
            this.NoteText.Location = new System.Drawing.Point(0, 50);
            this.NoteText.Name = "NoteText";
            this.NoteText.Size = new System.Drawing.Size(248, 248);
            this.NoteText.TabIndex = 1;
            this.NoteText.Text = "";
            this.NoteText.TextChanged += new System.EventHandler(this.NoteTextUpdated);
            // 
            // ContentsPanel
            // 
            this.ContentsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentsPanel.Controls.Add(this.NoteText);
            this.ContentsPanel.Controls.Add(this.TopPanel);
            this.ContentsPanel.Location = new System.Drawing.Point(1, 1);
            this.ContentsPanel.Name = "ContentsPanel";
            this.ContentsPanel.Size = new System.Drawing.Size(248, 298);
            this.ContentsPanel.TabIndex = 2;
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
        }
    }

