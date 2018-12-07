namespace BitmapResourceCreator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFontSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFontSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToCCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_characterSelectBox = new System.Windows.Forms.GroupBox();
            this.gb_fontMapPreviewBox = new System.Windows.Forms.GroupBox();
            this.gb_characterPreviewBox = new System.Windows.Forms.GroupBox();
            this.btn_addCharacter = new System.Windows.Forms.Button();
            this.btn_clearCharacter = new System.Windows.Forms.Button();
            this.nud_indexUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_previewBox = new System.Windows.Forms.PictureBox();
            this.btn_invertCharacter = new System.Windows.Forms.Button();
            this.pb_fontMapPreview = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.gb_fontMapPreviewBox.SuspendLayout();
            this.gb_characterPreviewBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_indexUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_previewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fontMapPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFontSetToolStripMenuItem,
            this.saveFontSetToolStripMenuItem,
            this.exportToCCToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // newFontSetToolStripMenuItem
            // 
            this.newFontSetToolStripMenuItem.Name = "newFontSetToolStripMenuItem";
            this.newFontSetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newFontSetToolStripMenuItem.Text = "New Font Set";
            // 
            // saveFontSetToolStripMenuItem
            // 
            this.saveFontSetToolStripMenuItem.Name = "saveFontSetToolStripMenuItem";
            this.saveFontSetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveFontSetToolStripMenuItem.Text = "Save Font Set";
            // 
            // exportToCCToolStripMenuItem
            // 
            this.exportToCCToolStripMenuItem.Name = "exportToCCToolStripMenuItem";
            this.exportToCCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToCCToolStripMenuItem.Text = "Export to C/C++";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // gb_characterSelectBox
            // 
            this.gb_characterSelectBox.AutoSize = true;
            this.gb_characterSelectBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gb_characterSelectBox.Location = new System.Drawing.Point(12, 27);
            this.gb_characterSelectBox.Name = "gb_characterSelectBox";
            this.gb_characterSelectBox.Size = new System.Drawing.Size(6, 19);
            this.gb_characterSelectBox.TabIndex = 1;
            this.gb_characterSelectBox.TabStop = false;
            this.gb_characterSelectBox.Text = "Define Character";
            // 
            // gb_fontMapPreviewBox
            // 
            this.gb_fontMapPreviewBox.AutoSize = true;
            this.gb_fontMapPreviewBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gb_fontMapPreviewBox.Controls.Add(this.pb_fontMapPreview);
            this.gb_fontMapPreviewBox.Location = new System.Drawing.Point(12, 260);
            this.gb_fontMapPreviewBox.Name = "gb_fontMapPreviewBox";
            this.gb_fontMapPreviewBox.Size = new System.Drawing.Size(97, 94);
            this.gb_fontMapPreviewBox.TabIndex = 2;
            this.gb_fontMapPreviewBox.TabStop = false;
            this.gb_fontMapPreviewBox.Text = "Font Map Preview";
            // 
            // gb_characterPreviewBox
            // 
            this.gb_characterPreviewBox.AutoSize = true;
            this.gb_characterPreviewBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gb_characterPreviewBox.Controls.Add(this.pb_previewBox);
            this.gb_characterPreviewBox.Location = new System.Drawing.Point(179, 27);
            this.gb_characterPreviewBox.Name = "gb_characterPreviewBox";
            this.gb_characterPreviewBox.Size = new System.Drawing.Size(142, 216);
            this.gb_characterPreviewBox.TabIndex = 3;
            this.gb_characterPreviewBox.TabStop = false;
            this.gb_characterPreviewBox.Text = "Character Preview";
            // 
            // btn_addCharacter
            // 
            this.btn_addCharacter.Location = new System.Drawing.Point(352, 86);
            this.btn_addCharacter.Name = "btn_addCharacter";
            this.btn_addCharacter.Size = new System.Drawing.Size(109, 35);
            this.btn_addCharacter.TabIndex = 4;
            this.btn_addCharacter.Text = "Add Character";
            this.btn_addCharacter.UseVisualStyleBackColor = true;
            this.btn_addCharacter.Click += new System.EventHandler(this.btn_addCharacterClicked);
            // 
            // btn_clearCharacter
            // 
            this.btn_clearCharacter.Location = new System.Drawing.Point(352, 127);
            this.btn_clearCharacter.Name = "btn_clearCharacter";
            this.btn_clearCharacter.Size = new System.Drawing.Size(109, 34);
            this.btn_clearCharacter.TabIndex = 5;
            this.btn_clearCharacter.Text = "Clear Character";
            this.btn_clearCharacter.UseVisualStyleBackColor = true;
            this.btn_clearCharacter.Click += new System.EventHandler(this.btn_clearSelectBoxes);
            // 
            // nud_indexUpDown
            // 
            this.nud_indexUpDown.Location = new System.Drawing.Point(437, 39);
            this.nud_indexUpDown.Name = "nud_indexUpDown";
            this.nud_indexUpDown.Size = new System.Drawing.Size(54, 20);
            this.nud_indexUpDown.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Character Index";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pb_previewBox
            // 
            this.pb_previewBox.Location = new System.Drawing.Point(6, 19);
            this.pb_previewBox.Name = "pb_previewBox";
            this.pb_previewBox.Size = new System.Drawing.Size(130, 178);
            this.pb_previewBox.TabIndex = 0;
            this.pb_previewBox.TabStop = false;
            // 
            // btn_invertCharacter
            // 
            this.btn_invertCharacter.Location = new System.Drawing.Point(352, 167);
            this.btn_invertCharacter.Name = "btn_invertCharacter";
            this.btn_invertCharacter.Size = new System.Drawing.Size(109, 34);
            this.btn_invertCharacter.TabIndex = 8;
            this.btn_invertCharacter.Text = "Invert Character";
            this.btn_invertCharacter.UseVisualStyleBackColor = true;
            this.btn_invertCharacter.Click += new System.EventHandler(this.btn_invertSelection);
            // 
            // pb_fontMapPreview
            // 
            this.pb_fontMapPreview.Location = new System.Drawing.Point(6, 19);
            this.pb_fontMapPreview.Name = "pb_fontMapPreview";
            this.pb_fontMapPreview.Size = new System.Drawing.Size(85, 56);
            this.pb_fontMapPreview.TabIndex = 0;
            this.pb_fontMapPreview.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(585, 454);
            this.Controls.Add(this.btn_invertCharacter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_indexUpDown);
            this.Controls.Add(this.btn_clearCharacter);
            this.Controls.Add(this.btn_addCharacter);
            this.Controls.Add(this.gb_characterPreviewBox);
            this.Controls.Add(this.gb_fontMapPreviewBox);
            this.Controls.Add(this.gb_characterSelectBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_fontMapPreviewBox.ResumeLayout(false);
            this.gb_characterPreviewBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_indexUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_previewBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fontMapPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFontSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFontSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToCCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox gb_characterSelectBox;
        private System.Windows.Forms.GroupBox gb_fontMapPreviewBox;
        private System.Windows.Forms.GroupBox gb_characterPreviewBox;
        private System.Windows.Forms.Button btn_addCharacter;
        private System.Windows.Forms.Button btn_clearCharacter;
        private System.Windows.Forms.NumericUpDown nud_indexUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_previewBox;
        private System.Windows.Forms.Button btn_invertCharacter;
        private System.Windows.Forms.PictureBox pb_fontMapPreview;
    }
}

