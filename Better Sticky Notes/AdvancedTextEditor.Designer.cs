
namespace Better_Sticky_Notes {
    partial class AdvancedTextEditor {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedTextEditor));
            this.TopBar = new System.Windows.Forms.Panel();
            this.TitleText = new System.Windows.Forms.Label();
            this.CloseEditor = new System.Windows.Forms.Button();
            this.RawText = new System.Windows.Forms.RichTextBox();
            this.PropertiesTree = new System.Windows.Forms.TableLayoutPanel();
            this.StyleProperties = new System.Windows.Forms.FlowLayoutPanel();
            this.StyleText = new System.Windows.Forms.Label();
            this.StyleSplitter = new System.Windows.Forms.Splitter();
            this.PrimaryColourText = new System.Windows.Forms.Label();
            this.PrimaryColourPreview = new System.Windows.Forms.Panel();
            this.SetPrimaryColour = new System.Windows.Forms.Button();
            this.SecondaryColourText = new System.Windows.Forms.Label();
            this.SecondaryColourPreview = new System.Windows.Forms.Panel();
            this.SetSecondaryColour = new System.Windows.Forms.Button();
            this.StyleBolded = new System.Windows.Forms.CheckBox();
            this.StyleItalic = new System.Windows.Forms.CheckBox();
            this.StyleUnderlined = new System.Windows.Forms.CheckBox();
            this.StyleStrikeout = new System.Windows.Forms.CheckBox();
            this.DataText = new System.Windows.Forms.Label();
            this.DataSplitter = new System.Windows.Forms.Splitter();
            this.DataTypeText = new System.Windows.Forms.Label();
            this.LocationSelection = new System.Windows.Forms.TableLayoutPanel();
            this.FixedSelect = new System.Windows.Forms.RadioButton();
            this.FileSelect = new System.Windows.Forms.RadioButton();
            this.WebSelect = new System.Windows.Forms.RadioButton();
            this.LocationText = new System.Windows.Forms.Label();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.ExtractionDataText = new System.Windows.Forms.Label();
            this.ExtractionDataStart = new System.Windows.Forms.TextBox();
            this.ExtractionDataEnd = new System.Windows.Forms.TextBox();
            this.RefreshIntervalText = new System.Windows.Forms.Label();
            this.RefreshInterval = new System.Windows.Forms.TextBox();
            this.ModificationText = new System.Windows.Forms.Label();
            this.ModificationsComingSoonText = new System.Windows.Forms.Label();
            this.ModificationSelection = new System.Windows.Forms.TableLayoutPanel();
            this.MathModification = new System.Windows.Forms.RadioButton();
            this.RegexModification = new System.Windows.Forms.RadioButton();
            this.AddAsset = new System.Windows.Forms.Button();
            this.AssetBar = new System.Windows.Forms.Panel();
            this.AssetAddImage = new System.Windows.Forms.RadioButton();
            this.AssetAddProgressBar = new System.Windows.Forms.RadioButton();
            this.AssetAddDynamicText = new System.Windows.Forms.RadioButton();
            this.TopBar.SuspendLayout();
            this.PropertiesTree.SuspendLayout();
            this.StyleProperties.SuspendLayout();
            this.LocationSelection.SuspendLayout();
            this.ModificationSelection.SuspendLayout();
            this.AssetBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TopBar.Controls.Add(this.TitleText);
            this.TopBar.Controls.Add(this.CloseEditor);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(789, 46);
            this.TopBar.TabIndex = 0;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // TitleText
            // 
            this.TitleText.AutoSize = true;
            this.TitleText.Font = new System.Drawing.Font("Corbel", 24F);
            this.TitleText.Location = new System.Drawing.Point(3, 4);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(331, 39);
            this.TitleText.TabIndex = 2;
            this.TitleText.Text = "֎ Advanced Text Editor";
            this.TitleText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // CloseEditor
            // 
            this.CloseEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CloseEditor.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseEditor.FlatAppearance.BorderSize = 0;
            this.CloseEditor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CloseEditor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CloseEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseEditor.Font = new System.Drawing.Font("Corbel", 16F);
            this.CloseEditor.Location = new System.Drawing.Point(739, 0);
            this.CloseEditor.Name = "CloseEditor";
            this.CloseEditor.Size = new System.Drawing.Size(50, 46);
            this.CloseEditor.TabIndex = 1;
            this.CloseEditor.Text = "X";
            this.CloseEditor.UseVisualStyleBackColor = false;
            this.CloseEditor.Click += new System.EventHandler(this.CloseEditor_Click);
            // 
            // RawText
            // 
            this.RawText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.RawText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RawText.DetectUrls = false;
            this.RawText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RawText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.RawText.Location = new System.Drawing.Point(417, 46);
            this.RawText.Name = "RawText";
            this.RawText.Size = new System.Drawing.Size(372, 360);
            this.RawText.TabIndex = 2;
            this.RawText.Text = "";
            // 
            // PropertiesTree
            // 
            this.PropertiesTree.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.PropertiesTree.ColumnCount = 1;
            this.PropertiesTree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PropertiesTree.Controls.Add(this.StyleProperties, 0, 0);
            this.PropertiesTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.PropertiesTree.Location = new System.Drawing.Point(200, 46);
            this.PropertiesTree.Name = "PropertiesTree";
            this.PropertiesTree.RowCount = 1;
            this.PropertiesTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.28134F));
            this.PropertiesTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.71866F));
            this.PropertiesTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.PropertiesTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.PropertiesTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.PropertiesTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.PropertiesTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.PropertiesTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.PropertiesTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.PropertiesTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.PropertiesTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.PropertiesTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.PropertiesTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.PropertiesTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.PropertiesTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.PropertiesTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.PropertiesTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.PropertiesTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.PropertiesTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.PropertiesTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.PropertiesTree.Size = new System.Drawing.Size(217, 360);
            this.PropertiesTree.TabIndex = 3;
            // 
            // StyleProperties
            // 
            this.StyleProperties.AutoScroll = true;
            this.StyleProperties.Controls.Add(this.StyleText);
            this.StyleProperties.Controls.Add(this.StyleSplitter);
            this.StyleProperties.Controls.Add(this.PrimaryColourText);
            this.StyleProperties.Controls.Add(this.PrimaryColourPreview);
            this.StyleProperties.Controls.Add(this.SetPrimaryColour);
            this.StyleProperties.Controls.Add(this.SecondaryColourText);
            this.StyleProperties.Controls.Add(this.SecondaryColourPreview);
            this.StyleProperties.Controls.Add(this.SetSecondaryColour);
            this.StyleProperties.Controls.Add(this.StyleBolded);
            this.StyleProperties.Controls.Add(this.StyleItalic);
            this.StyleProperties.Controls.Add(this.StyleUnderlined);
            this.StyleProperties.Controls.Add(this.StyleStrikeout);
            this.StyleProperties.Controls.Add(this.DataText);
            this.StyleProperties.Controls.Add(this.DataSplitter);
            this.StyleProperties.Controls.Add(this.DataTypeText);
            this.StyleProperties.Controls.Add(this.LocationSelection);
            this.StyleProperties.Controls.Add(this.LocationText);
            this.StyleProperties.Controls.Add(this.LocationTextBox);
            this.StyleProperties.Controls.Add(this.ExtractionDataText);
            this.StyleProperties.Controls.Add(this.ExtractionDataStart);
            this.StyleProperties.Controls.Add(this.ExtractionDataEnd);
            this.StyleProperties.Controls.Add(this.RefreshIntervalText);
            this.StyleProperties.Controls.Add(this.RefreshInterval);
            this.StyleProperties.Controls.Add(this.ModificationText);
            this.StyleProperties.Controls.Add(this.ModificationsComingSoonText);
            this.StyleProperties.Controls.Add(this.ModificationSelection);
            this.StyleProperties.Controls.Add(this.AddAsset);
            this.StyleProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StyleProperties.Location = new System.Drawing.Point(1, 1);
            this.StyleProperties.Margin = new System.Windows.Forms.Padding(0);
            this.StyleProperties.Name = "StyleProperties";
            this.StyleProperties.Size = new System.Drawing.Size(215, 358);
            this.StyleProperties.TabIndex = 0;
            // 
            // StyleText
            // 
            this.StyleText.AutoSize = true;
            this.StyleText.Font = new System.Drawing.Font("Corbel", 18F);
            this.StyleText.Location = new System.Drawing.Point(3, 0);
            this.StyleText.Name = "StyleText";
            this.StyleText.Size = new System.Drawing.Size(64, 29);
            this.StyleText.TabIndex = 0;
            this.StyleText.Text = "Style";
            // 
            // StyleSplitter
            // 
            this.StyleSplitter.Location = new System.Drawing.Point(73, 3);
            this.StyleSplitter.Name = "StyleSplitter";
            this.StyleSplitter.Size = new System.Drawing.Size(110, 23);
            this.StyleSplitter.TabIndex = 7;
            this.StyleSplitter.TabStop = false;
            // 
            // PrimaryColourText
            // 
            this.PrimaryColourText.AutoSize = true;
            this.PrimaryColourText.Font = new System.Drawing.Font("Corbel", 12F);
            this.PrimaryColourText.Location = new System.Drawing.Point(3, 29);
            this.PrimaryColourText.Name = "PrimaryColourText";
            this.PrimaryColourText.Size = new System.Drawing.Size(107, 19);
            this.PrimaryColourText.TabIndex = 2;
            this.PrimaryColourText.Text = "Primary Colour";
            // 
            // PrimaryColourPreview
            // 
            this.PrimaryColourPreview.BackColor = System.Drawing.Color.White;
            this.PrimaryColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrimaryColourPreview.Location = new System.Drawing.Point(3, 51);
            this.PrimaryColourPreview.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.PrimaryColourPreview.Name = "PrimaryColourPreview";
            this.PrimaryColourPreview.Size = new System.Drawing.Size(130, 20);
            this.PrimaryColourPreview.TabIndex = 1;
            // 
            // SetPrimaryColour
            // 
            this.SetPrimaryColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SetPrimaryColour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SetPrimaryColour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetPrimaryColour.Font = new System.Drawing.Font("Corbel", 8F);
            this.SetPrimaryColour.Location = new System.Drawing.Point(133, 51);
            this.SetPrimaryColour.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.SetPrimaryColour.Name = "SetPrimaryColour";
            this.SetPrimaryColour.Size = new System.Drawing.Size(62, 20);
            this.SetPrimaryColour.TabIndex = 3;
            this.SetPrimaryColour.Text = ". . .";
            this.SetPrimaryColour.UseVisualStyleBackColor = false;
            this.SetPrimaryColour.Click += new System.EventHandler(this.ChangePrimaryColour);
            // 
            // SecondaryColourText
            // 
            this.SecondaryColourText.AutoSize = true;
            this.SecondaryColourText.Font = new System.Drawing.Font("Corbel", 12F);
            this.SecondaryColourText.Location = new System.Drawing.Point(3, 74);
            this.SecondaryColourText.Name = "SecondaryColourText";
            this.SecondaryColourText.Size = new System.Drawing.Size(126, 19);
            this.SecondaryColourText.TabIndex = 6;
            this.SecondaryColourText.Text = "Secondary Colour";
            // 
            // SecondaryColourPreview
            // 
            this.SecondaryColourPreview.BackColor = System.Drawing.Color.White;
            this.SecondaryColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondaryColourPreview.Location = new System.Drawing.Point(3, 96);
            this.SecondaryColourPreview.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.SecondaryColourPreview.Name = "SecondaryColourPreview";
            this.SecondaryColourPreview.Size = new System.Drawing.Size(130, 20);
            this.SecondaryColourPreview.TabIndex = 4;
            // 
            // SetSecondaryColour
            // 
            this.SetSecondaryColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SetSecondaryColour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SetSecondaryColour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetSecondaryColour.Font = new System.Drawing.Font("Corbel", 8F);
            this.SetSecondaryColour.Location = new System.Drawing.Point(133, 96);
            this.SetSecondaryColour.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.SetSecondaryColour.Name = "SetSecondaryColour";
            this.SetSecondaryColour.Size = new System.Drawing.Size(62, 20);
            this.SetSecondaryColour.TabIndex = 5;
            this.SetSecondaryColour.Text = ". . .";
            this.SetSecondaryColour.UseVisualStyleBackColor = false;
            this.SetSecondaryColour.Click += new System.EventHandler(this.ChangeSecondaryColour);
            // 
            // StyleBolded
            // 
            this.StyleBolded.Appearance = System.Windows.Forms.Appearance.Button;
            this.StyleBolded.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.StyleBolded.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.StyleBolded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StyleBolded.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StyleBolded.Location = new System.Drawing.Point(3, 119);
            this.StyleBolded.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.StyleBolded.Name = "StyleBolded";
            this.StyleBolded.Size = new System.Drawing.Size(40, 40);
            this.StyleBolded.TabIndex = 8;
            this.StyleBolded.Text = "B";
            this.StyleBolded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StyleBolded.UseVisualStyleBackColor = true;
            // 
            // StyleItalic
            // 
            this.StyleItalic.Appearance = System.Windows.Forms.Appearance.Button;
            this.StyleItalic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.StyleItalic.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.StyleItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StyleItalic.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StyleItalic.Location = new System.Drawing.Point(44, 119);
            this.StyleItalic.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.StyleItalic.Name = "StyleItalic";
            this.StyleItalic.Size = new System.Drawing.Size(40, 40);
            this.StyleItalic.TabIndex = 9;
            this.StyleItalic.Text = "i";
            this.StyleItalic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StyleItalic.UseVisualStyleBackColor = true;
            // 
            // StyleUnderlined
            // 
            this.StyleUnderlined.Appearance = System.Windows.Forms.Appearance.Button;
            this.StyleUnderlined.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.StyleUnderlined.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.StyleUnderlined.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StyleUnderlined.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StyleUnderlined.Location = new System.Drawing.Point(85, 119);
            this.StyleUnderlined.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.StyleUnderlined.Name = "StyleUnderlined";
            this.StyleUnderlined.Size = new System.Drawing.Size(40, 40);
            this.StyleUnderlined.TabIndex = 10;
            this.StyleUnderlined.Text = "u";
            this.StyleUnderlined.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StyleUnderlined.UseVisualStyleBackColor = true;
            // 
            // StyleStrikeout
            // 
            this.StyleStrikeout.Appearance = System.Windows.Forms.Appearance.Button;
            this.StyleStrikeout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.StyleStrikeout.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.StyleStrikeout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StyleStrikeout.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StyleStrikeout.Location = new System.Drawing.Point(126, 119);
            this.StyleStrikeout.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.StyleStrikeout.Name = "StyleStrikeout";
            this.StyleStrikeout.Size = new System.Drawing.Size(40, 40);
            this.StyleStrikeout.TabIndex = 11;
            this.StyleStrikeout.Text = "s";
            this.StyleStrikeout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StyleStrikeout.UseVisualStyleBackColor = true;
            // 
            // DataText
            // 
            this.DataText.AutoSize = true;
            this.DataText.Font = new System.Drawing.Font("Corbel", 18F);
            this.DataText.Location = new System.Drawing.Point(3, 159);
            this.DataText.Name = "DataText";
            this.DataText.Size = new System.Drawing.Size(61, 29);
            this.DataText.TabIndex = 12;
            this.DataText.Text = "Data";
            // 
            // DataSplitter
            // 
            this.DataSplitter.Location = new System.Drawing.Point(70, 162);
            this.DataSplitter.Name = "DataSplitter";
            this.DataSplitter.Size = new System.Drawing.Size(113, 23);
            this.DataSplitter.TabIndex = 13;
            this.DataSplitter.TabStop = false;
            // 
            // DataTypeText
            // 
            this.DataTypeText.AutoSize = true;
            this.DataTypeText.Font = new System.Drawing.Font("Corbel", 12F);
            this.DataTypeText.Location = new System.Drawing.Point(3, 188);
            this.DataTypeText.Name = "DataTypeText";
            this.DataTypeText.Size = new System.Drawing.Size(42, 19);
            this.DataTypeText.TabIndex = 14;
            this.DataTypeText.Text = "Type";
            // 
            // LocationSelection
            // 
            this.LocationSelection.ColumnCount = 3;
            this.LocationSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LocationSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LocationSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LocationSelection.Controls.Add(this.FixedSelect, 2, 0);
            this.LocationSelection.Controls.Add(this.FileSelect, 1, 0);
            this.LocationSelection.Controls.Add(this.WebSelect, 0, 0);
            this.LocationSelection.Location = new System.Drawing.Point(3, 210);
            this.LocationSelection.Name = "LocationSelection";
            this.LocationSelection.RowCount = 1;
            this.LocationSelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LocationSelection.Size = new System.Drawing.Size(192, 28);
            this.LocationSelection.TabIndex = 15;
            // 
            // FixedSelect
            // 
            this.FixedSelect.Appearance = System.Windows.Forms.Appearance.Button;
            this.FixedSelect.AutoSize = true;
            this.FixedSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FixedSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.FixedSelect.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.FixedSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FixedSelect.Font = new System.Drawing.Font("Corbel", 10F);
            this.FixedSelect.Location = new System.Drawing.Point(128, 0);
            this.FixedSelect.Margin = new System.Windows.Forms.Padding(0);
            this.FixedSelect.Name = "FixedSelect";
            this.FixedSelect.Size = new System.Drawing.Size(64, 28);
            this.FixedSelect.TabIndex = 2;
            this.FixedSelect.Text = "Fixed";
            this.FixedSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FixedSelect.UseVisualStyleBackColor = true;
            this.FixedSelect.CheckedChanged += new System.EventHandler(this.TypeChanged);
            // 
            // FileSelect
            // 
            this.FileSelect.Appearance = System.Windows.Forms.Appearance.Button;
            this.FileSelect.AutoSize = true;
            this.FileSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.FileSelect.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.FileSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileSelect.Font = new System.Drawing.Font("Corbel", 10F);
            this.FileSelect.Location = new System.Drawing.Point(64, 0);
            this.FileSelect.Margin = new System.Windows.Forms.Padding(0);
            this.FileSelect.Name = "FileSelect";
            this.FileSelect.Size = new System.Drawing.Size(64, 28);
            this.FileSelect.TabIndex = 1;
            this.FileSelect.Text = "File";
            this.FileSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FileSelect.UseVisualStyleBackColor = true;
            this.FileSelect.CheckedChanged += new System.EventHandler(this.TypeChanged);
            // 
            // WebSelect
            // 
            this.WebSelect.Appearance = System.Windows.Forms.Appearance.Button;
            this.WebSelect.AutoSize = true;
            this.WebSelect.Checked = true;
            this.WebSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.WebSelect.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.WebSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WebSelect.Font = new System.Drawing.Font("Corbel", 10F);
            this.WebSelect.Location = new System.Drawing.Point(0, 0);
            this.WebSelect.Margin = new System.Windows.Forms.Padding(0);
            this.WebSelect.Name = "WebSelect";
            this.WebSelect.Size = new System.Drawing.Size(64, 28);
            this.WebSelect.TabIndex = 0;
            this.WebSelect.TabStop = true;
            this.WebSelect.Text = "Web";
            this.WebSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WebSelect.UseVisualStyleBackColor = true;
            this.WebSelect.CheckedChanged += new System.EventHandler(this.TypeChanged);
            // 
            // LocationText
            // 
            this.LocationText.AutoSize = true;
            this.LocationText.Font = new System.Drawing.Font("Corbel", 12F);
            this.LocationText.Location = new System.Drawing.Point(3, 241);
            this.LocationText.Name = "LocationText";
            this.LocationText.Size = new System.Drawing.Size(29, 19);
            this.LocationText.TabIndex = 16;
            this.LocationText.Text = "Url";
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationTextBox.Font = new System.Drawing.Font("Corbel", 12F);
            this.LocationTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.LocationTextBox.Location = new System.Drawing.Point(3, 263);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(192, 27);
            this.LocationTextBox.TabIndex = 17;
            this.LocationTextBox.Text = "https://www.dmbkdevelopment.com/bsnratio.png";
            // 
            // ExtractionDataText
            // 
            this.ExtractionDataText.AutoSize = true;
            this.ExtractionDataText.Font = new System.Drawing.Font("Corbel", 12F);
            this.ExtractionDataText.Location = new System.Drawing.Point(3, 293);
            this.ExtractionDataText.Name = "ExtractionDataText";
            this.ExtractionDataText.Size = new System.Drawing.Size(186, 19);
            this.ExtractionDataText.TabIndex = 18;
            this.ExtractionDataText.Text = "Extraction Data (Optional)";
            // 
            // ExtractionDataStart
            // 
            this.ExtractionDataStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ExtractionDataStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExtractionDataStart.Font = new System.Drawing.Font("Corbel", 12F);
            this.ExtractionDataStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.ExtractionDataStart.Location = new System.Drawing.Point(3, 315);
            this.ExtractionDataStart.Name = "ExtractionDataStart";
            this.ExtractionDataStart.Size = new System.Drawing.Size(93, 27);
            this.ExtractionDataStart.TabIndex = 19;
            this.ExtractionDataStart.Text = "{\"example\": \"";
            // 
            // ExtractionDataEnd
            // 
            this.ExtractionDataEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ExtractionDataEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExtractionDataEnd.Font = new System.Drawing.Font("Corbel", 12F);
            this.ExtractionDataEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.ExtractionDataEnd.Location = new System.Drawing.Point(102, 315);
            this.ExtractionDataEnd.Name = "ExtractionDataEnd";
            this.ExtractionDataEnd.Size = new System.Drawing.Size(93, 27);
            this.ExtractionDataEnd.TabIndex = 20;
            this.ExtractionDataEnd.Text = "\"}";
            // 
            // RefreshIntervalText
            // 
            this.RefreshIntervalText.AutoSize = true;
            this.RefreshIntervalText.Font = new System.Drawing.Font("Corbel", 12F);
            this.RefreshIntervalText.Location = new System.Drawing.Point(3, 345);
            this.RefreshIntervalText.Name = "RefreshIntervalText";
            this.RefreshIntervalText.Size = new System.Drawing.Size(181, 19);
            this.RefreshIntervalText.TabIndex = 21;
            this.RefreshIntervalText.Text = "Refresh Interval (Seconds)";
            // 
            // RefreshInterval
            // 
            this.RefreshInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.RefreshInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RefreshInterval.Font = new System.Drawing.Font("Corbel", 12F);
            this.RefreshInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.RefreshInterval.Location = new System.Drawing.Point(3, 367);
            this.RefreshInterval.MaxLength = 5;
            this.RefreshInterval.Name = "RefreshInterval";
            this.RefreshInterval.Size = new System.Drawing.Size(192, 27);
            this.RefreshInterval.TabIndex = 22;
            this.RefreshInterval.Text = "15";
            this.RefreshInterval.TextChanged += new System.EventHandler(this.RefreshInterval_TextChanged);
            // 
            // ModificationText
            // 
            this.ModificationText.AutoSize = true;
            this.ModificationText.Font = new System.Drawing.Font("Corbel", 18F);
            this.ModificationText.Location = new System.Drawing.Point(3, 397);
            this.ModificationText.Name = "ModificationText";
            this.ModificationText.Size = new System.Drawing.Size(151, 29);
            this.ModificationText.TabIndex = 23;
            this.ModificationText.Text = "Modifications";
            // 
            // ModificationsComingSoonText
            // 
            this.ModificationsComingSoonText.AutoSize = true;
            this.ModificationsComingSoonText.Font = new System.Drawing.Font("Corbel", 12F);
            this.ModificationsComingSoonText.Location = new System.Drawing.Point(3, 426);
            this.ModificationsComingSoonText.Name = "ModificationsComingSoonText";
            this.ModificationsComingSoonText.Size = new System.Drawing.Size(103, 19);
            this.ModificationsComingSoonText.TabIndex = 25;
            this.ModificationsComingSoonText.Text = "Coming Soon!";
            // 
            // ModificationSelection
            // 
            this.ModificationSelection.ColumnCount = 2;
            this.ModificationSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ModificationSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ModificationSelection.Controls.Add(this.MathModification, 1, 0);
            this.ModificationSelection.Controls.Add(this.RegexModification, 0, 0);
            this.ModificationSelection.Location = new System.Drawing.Point(3, 448);
            this.ModificationSelection.Name = "ModificationSelection";
            this.ModificationSelection.RowCount = 1;
            this.ModificationSelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ModificationSelection.Size = new System.Drawing.Size(192, 28);
            this.ModificationSelection.TabIndex = 24;
            // 
            // MathModification
            // 
            this.MathModification.Appearance = System.Windows.Forms.Appearance.Button;
            this.MathModification.AutoSize = true;
            this.MathModification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MathModification.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MathModification.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.MathModification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MathModification.Font = new System.Drawing.Font("Corbel", 10F);
            this.MathModification.Location = new System.Drawing.Point(96, 0);
            this.MathModification.Margin = new System.Windows.Forms.Padding(0);
            this.MathModification.Name = "MathModification";
            this.MathModification.Size = new System.Drawing.Size(96, 28);
            this.MathModification.TabIndex = 1;
            this.MathModification.Text = "Math";
            this.MathModification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MathModification.UseVisualStyleBackColor = true;
            // 
            // RegexModification
            // 
            this.RegexModification.Appearance = System.Windows.Forms.Appearance.Button;
            this.RegexModification.AutoSize = true;
            this.RegexModification.Checked = true;
            this.RegexModification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegexModification.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.RegexModification.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.RegexModification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegexModification.Font = new System.Drawing.Font("Corbel", 10F);
            this.RegexModification.Location = new System.Drawing.Point(0, 0);
            this.RegexModification.Margin = new System.Windows.Forms.Padding(0);
            this.RegexModification.Name = "RegexModification";
            this.RegexModification.Size = new System.Drawing.Size(96, 28);
            this.RegexModification.TabIndex = 0;
            this.RegexModification.TabStop = true;
            this.RegexModification.Text = "Regex";
            this.RegexModification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegexModification.UseVisualStyleBackColor = true;
            // 
            // AddAsset
            // 
            this.AddAsset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.AddAsset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.AddAsset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.AddAsset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAsset.Font = new System.Drawing.Font("Corbel", 14F);
            this.AddAsset.Location = new System.Drawing.Point(3, 479);
            this.AddAsset.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.AddAsset.Name = "AddAsset";
            this.AddAsset.Size = new System.Drawing.Size(192, 35);
            this.AddAsset.TabIndex = 26;
            this.AddAsset.Text = "Insert Asset";
            this.AddAsset.UseVisualStyleBackColor = true;
            this.AddAsset.Click += new System.EventHandler(this.AddRawAsset);
            // 
            // AssetBar
            // 
            this.AssetBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssetBar.Controls.Add(this.AssetAddImage);
            this.AssetBar.Controls.Add(this.AssetAddProgressBar);
            this.AssetBar.Controls.Add(this.AssetAddDynamicText);
            this.AssetBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.AssetBar.Location = new System.Drawing.Point(0, 46);
            this.AssetBar.Name = "AssetBar";
            this.AssetBar.Size = new System.Drawing.Size(200, 360);
            this.AssetBar.TabIndex = 4;
            // 
            // AssetAddImage
            // 
            this.AssetAddImage.Appearance = System.Windows.Forms.Appearance.Button;
            this.AssetAddImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AssetAddImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.AssetAddImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.AssetAddImage.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.AssetAddImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.AssetAddImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.AssetAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssetAddImage.Font = new System.Drawing.Font("Corbel", 16F);
            this.AssetAddImage.Location = new System.Drawing.Point(0, 100);
            this.AssetAddImage.Name = "AssetAddImage";
            this.AssetAddImage.Size = new System.Drawing.Size(198, 50);
            this.AssetAddImage.TabIndex = 7;
            this.AssetAddImage.Text = "▨ Image ▧";
            this.AssetAddImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AssetAddImage.UseVisualStyleBackColor = false;
            // 
            // AssetAddProgressBar
            // 
            this.AssetAddProgressBar.Appearance = System.Windows.Forms.Appearance.Button;
            this.AssetAddProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AssetAddProgressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.AssetAddProgressBar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.AssetAddProgressBar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.AssetAddProgressBar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.AssetAddProgressBar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.AssetAddProgressBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssetAddProgressBar.Font = new System.Drawing.Font("Corbel", 16F);
            this.AssetAddProgressBar.Location = new System.Drawing.Point(0, 50);
            this.AssetAddProgressBar.Name = "AssetAddProgressBar";
            this.AssetAddProgressBar.Size = new System.Drawing.Size(198, 50);
            this.AssetAddProgressBar.TabIndex = 6;
            this.AssetAddProgressBar.Text = " ▰ Progress Bar ▰";
            this.AssetAddProgressBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AssetAddProgressBar.UseVisualStyleBackColor = false;
            // 
            // AssetAddDynamicText
            // 
            this.AssetAddDynamicText.Appearance = System.Windows.Forms.Appearance.Button;
            this.AssetAddDynamicText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AssetAddDynamicText.Checked = true;
            this.AssetAddDynamicText.Dock = System.Windows.Forms.DockStyle.Top;
            this.AssetAddDynamicText.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.AssetAddDynamicText.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.AssetAddDynamicText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.AssetAddDynamicText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.AssetAddDynamicText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssetAddDynamicText.Font = new System.Drawing.Font("Corbel", 16F);
            this.AssetAddDynamicText.Location = new System.Drawing.Point(0, 0);
            this.AssetAddDynamicText.Name = "AssetAddDynamicText";
            this.AssetAddDynamicText.Size = new System.Drawing.Size(198, 50);
            this.AssetAddDynamicText.TabIndex = 5;
            this.AssetAddDynamicText.TabStop = true;
            this.AssetAddDynamicText.Text = "∑ Dynamic Text ±";
            this.AssetAddDynamicText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AssetAddDynamicText.UseVisualStyleBackColor = false;
            // 
            // AdvancedTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(789, 406);
            this.Controls.Add(this.RawText);
            this.Controls.Add(this.PropertiesTree);
            this.Controls.Add(this.AssetBar);
            this.Controls.Add(this.TopBar);
            this.Font = new System.Drawing.Font("Corbel", 16F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdvancedTextEditor";
            this.ShowIcon = false;
            this.Text = "Advanced Text Editor";
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.PropertiesTree.ResumeLayout(false);
            this.StyleProperties.ResumeLayout(false);
            this.StyleProperties.PerformLayout();
            this.LocationSelection.ResumeLayout(false);
            this.LocationSelection.PerformLayout();
            this.ModificationSelection.ResumeLayout(false);
            this.ModificationSelection.PerformLayout();
            this.AssetBar.ResumeLayout(false);
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Button CloseEditor;
        private System.Windows.Forms.RichTextBox RawText;
        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.TableLayoutPanel PropertiesTree;
        private System.Windows.Forms.FlowLayoutPanel StyleProperties;
        private System.Windows.Forms.Label StyleText;
        private System.Windows.Forms.Splitter StyleSplitter;
        private System.Windows.Forms.Label PrimaryColourText;
        private System.Windows.Forms.Panel PrimaryColourPreview;
        private System.Windows.Forms.Button SetPrimaryColour;
        private System.Windows.Forms.Label SecondaryColourText;
        private System.Windows.Forms.Panel SecondaryColourPreview;
        private System.Windows.Forms.Button SetSecondaryColour;
        private System.Windows.Forms.CheckBox StyleBolded;
        private System.Windows.Forms.CheckBox StyleItalic;
        private System.Windows.Forms.CheckBox StyleUnderlined;
        private System.Windows.Forms.CheckBox StyleStrikeout;
        private System.Windows.Forms.Label DataText;
        private System.Windows.Forms.Splitter DataSplitter;
        private System.Windows.Forms.Label DataTypeText;
        private System.Windows.Forms.TableLayoutPanel LocationSelection;
        private System.Windows.Forms.RadioButton FixedSelect;
        private System.Windows.Forms.RadioButton FileSelect;
        private System.Windows.Forms.RadioButton WebSelect;
        private System.Windows.Forms.Label LocationText;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.Label ExtractionDataText;
        private System.Windows.Forms.TextBox ExtractionDataStart;
        private System.Windows.Forms.TextBox ExtractionDataEnd;
        private System.Windows.Forms.Label RefreshIntervalText;
        private System.Windows.Forms.TextBox RefreshInterval;
        private System.Windows.Forms.Panel AssetBar;
        private System.Windows.Forms.RadioButton AssetAddImage;
        private System.Windows.Forms.RadioButton AssetAddProgressBar;
        private System.Windows.Forms.RadioButton AssetAddDynamicText;
        private System.Windows.Forms.Label ModificationText;
        private System.Windows.Forms.Label ModificationsComingSoonText;
        private System.Windows.Forms.TableLayoutPanel ModificationSelection;
        private System.Windows.Forms.RadioButton MathModification;
        private System.Windows.Forms.RadioButton RegexModification;
        private System.Windows.Forms.Button AddAsset;
        }
    }