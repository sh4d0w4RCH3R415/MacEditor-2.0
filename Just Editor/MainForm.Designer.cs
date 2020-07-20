namespace Just_Editor
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.newFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFile_ = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileAs_ = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.language = new System.Windows.Forms.ToolStripComboBox();
            this.wordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.tabIndentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabIndent = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileDir = new System.Windows.Forms.ToolStripMenuItem();
            this.font = new System.Windows.Forms.ToolStripMenuItem();
            this.fileType = new System.Windows.Forms.ToolStripMenuItem();
            this.indent = new System.Windows.Forms.ToolStripMenuItem();
            this.editor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editor)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(547, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile,
            this.toolStripMenuItem1,
            this.newFile,
            this.toolStripMenuItem2,
            this.saveFile_,
            this.saveFileAs_});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFile.Size = new System.Drawing.Size(238, 22);
            this.openFile.Text = "Open File";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 6);
            // 
            // newFile
            // 
            this.newFile.Name = "newFile";
            this.newFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFile.Size = new System.Drawing.Size(238, 22);
            this.newFile.Text = "New File";
            this.newFile.Click += new System.EventHandler(this.newFile_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 6);
            // 
            // saveFile_
            // 
            this.saveFile_.Name = "saveFile_";
            this.saveFile_.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFile_.Size = new System.Drawing.Size(238, 22);
            this.saveFile_.Text = "Save File";
            this.saveFile_.Click += new System.EventHandler(this.saveFile__Click);
            // 
            // saveFileAs_
            // 
            this.saveFileAs_.Name = "saveFileAs_";
            this.saveFileAs_.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveFileAs_.Size = new System.Drawing.Size(238, 22);
            this.saveFileAs_.Text = "Save File As";
            this.saveFileAs_.Click += new System.EventHandler(this.saveFileAs__Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.wordWrap,
            this.tabIndentToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.language});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // language
            // 
            this.language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.language.Font = new System.Drawing.Font("Roboto", 12F);
            this.language.Items.AddRange(new object[] {
            "CSharp",
            "Custom",
            "HTML",
            "JS",
            "Lua",
            "PHP",
            "SQL",
            "VB",
            "XML"});
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(121, 27);
            this.language.TextChanged += new System.EventHandler(this.language_TextChanged);
            // 
            // wordWrap
            // 
            this.wordWrap.Checked = true;
            this.wordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wordWrap.Name = "wordWrap";
            this.wordWrap.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.wordWrap.Size = new System.Drawing.Size(196, 22);
            this.wordWrap.Text = "Word Wrap";
            this.wordWrap.Click += new System.EventHandler(this.wordWrap_Click);
            // 
            // tabIndentToolStripMenuItem
            // 
            this.tabIndentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabIndent});
            this.tabIndentToolStripMenuItem.Name = "tabIndentToolStripMenuItem";
            this.tabIndentToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.tabIndentToolStripMenuItem.Text = "Tab Indent";
            // 
            // tabIndent
            // 
            this.tabIndent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tabIndent.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.tabIndent.Name = "tabIndent";
            this.tabIndent.Size = new System.Drawing.Size(121, 23);
            this.tabIndent.TextChanged += new System.EventHandler(this.tabIndent_TextChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip2.Font = new System.Drawing.Font("Roboto", 9F);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileDir,
            this.font,
            this.fileType,
            this.indent});
            this.menuStrip2.Location = new System.Drawing.Point(0, 426);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(547, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileDir
            // 
            this.fileDir.Name = "fileDir";
            this.fileDir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.fileDir.Size = new System.Drawing.Size(52, 20);
            this.fileDir.Text = "-none-";
            this.fileDir.Click += new System.EventHandler(this.fileDir_Click);
            // 
            // font
            // 
            this.font.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(110, 20);
            this.font.Text = "Consolas, 9.75pt";
            this.font.Click += new System.EventHandler(this.font_Click);
            // 
            // fileType
            // 
            this.fileType.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.fileType.Name = "fileType";
            this.fileType.Size = new System.Drawing.Size(50, 20);
            this.fileType.Text = "file.cs";
            // 
            // indent
            // 
            this.indent.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.indent.Name = "indent";
            this.indent.Size = new System.Drawing.Size(66, 20);
            this.indent.Text = "Indent: 4";
            // 
            // editor
            // 
            this.editor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.editor.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.editor.AutoScrollMinSize = new System.Drawing.Size(0, 15);
            this.editor.BackBrush = null;
            this.editor.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.editor.CaretBlinking = false;
            this.editor.CharHeight = 15;
            this.editor.CharWidth = 7;
            this.editor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.editor.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.editor.IsReplaceMode = false;
            this.editor.Language = FastColoredTextBoxNS.Language.CSharp;
            this.editor.LeftBracket = '(';
            this.editor.LeftBracket2 = '{';
            this.editor.Location = new System.Drawing.Point(0, 25);
            this.editor.Name = "editor";
            this.editor.Paddings = new System.Windows.Forms.Padding(0);
            this.editor.RightBracket = ')';
            this.editor.RightBracket2 = '}';
            this.editor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.editor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("editor.ServiceColors")));
            this.editor.ShowCaretWhenInactive = true;
            this.editor.Size = new System.Drawing.Size(547, 401);
            this.editor.TabIndex = 2;
            this.editor.WordWrap = true;
            this.editor.Zoom = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.editor);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "MacEditor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveFile_;
        private System.Windows.Forms.ToolStripMenuItem saveFileAs_;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox language;
        private System.Windows.Forms.ToolStripMenuItem wordWrap;
        private System.Windows.Forms.ToolStripMenuItem tabIndentToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tabIndent;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileDir;
        private System.Windows.Forms.ToolStripMenuItem font;
        private FastColoredTextBoxNS.FastColoredTextBox editor;
        private System.Windows.Forms.ToolStripMenuItem fileType;
        private System.Windows.Forms.ToolStripMenuItem indent;
    }
}

