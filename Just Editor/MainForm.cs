using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Just_Editor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            if (File.Exists(Application.StartupPath + "\\kernel32.dll"))
            {
                InitializeComponent();
                Timer timer = new Timer();
                timer.Interval = 1;
                language.Text = "CSharp";
                tabIndent.Text = "4";
                timer.Tick += delegate (object sender, EventArgs e)
                {
                    language_TextChanged(sender, e);
                    tabIndent_TextChanged(sender, e);
                    font.Text = editor.Font.Name + ", " + editor.Font.Size + "pt";
                };
                timer.Start();
            }
            else if (!File.Exists(Application.StartupPath + "\\kernel32.dll"))
            {
                MessageBox.Show(
                    "Failed to load application, do you have the required components:\n\n" +
                    " - kernel32.dll\n\n" +
                    "If these components are not in the SAME EXACT directory as the application,\n" +
                    "it will fail to load."
                    );
                Close();
            }
        }

        private string File_ = "-none-";
        private string FileSaveType = ".file";

        private void openFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Open File",
                FileName = "file" + FileSaveType,
                Filter = "All Files|*.*",
                FilterIndex = 0
            })
                if (ofd.ShowDialog() == DialogResult.OK)
                    using (StreamReader r = new StreamReader(ofd.FileName))
                    {
                        editor.Text = r.ReadToEnd();
                        fileDir.Text = ofd.FileName;
                        File_ = fileDir.Text;
                        r.Close();
                    }
        }
        private void newFile_Click(object sender, EventArgs e)
        {
            if (editor.Text == "")
            {
                File_ = "-none-"; fileDir.Text = "-none-";
            }
            else if (editor.Text != "")
            {
                var q = MessageBox.Show(
                    "Warning!\n\n" +
                    "You have unsaved changes in the editor.\n" +
                    "Would you like the save them in a file before starting from scratch?\n\n" +
                    " - [ Yes: Save First ] - [ No: Start From Scratch ] - ",
                    "",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                    );
                if (q == DialogResult.Yes)
                {
                    using (SaveFileDialog sfd = new SaveFileDialog()
                    {
                        Title = "Save File",
                        FileName = "file" + FileSaveType,
                        Filter = "All Files|*.*",
                        FilterIndex = 0
                    })
                        if (sfd.ShowDialog() == DialogResult.OK)
                            using (StreamWriter w = new StreamWriter(sfd.FileName))
                            {
                                w.Write(editor.Text);
                                File_ = sfd.FileName;
                                fileDir.Text = File_;
                                w.Close();
                            }
                }
                else if (q == DialogResult.No)
                    editor.Text = ""; fileDir.Text = "-none-"; File_ = "-none-";
            }
        }
        private void saveFile__Click(object sender, EventArgs e)
        {
            if (fileDir.Text == "-none-" & File_ == fileDir.Text & editor.Text != "")
            {
                using (SaveFileDialog sfd = new SaveFileDialog()
                {
                    Title = "Save File",
                    FileName = "file" + FileSaveType,
                    Filter = "All Files|*.*",
                    FilterIndex = 0
                })
                    if (sfd.ShowDialog() == DialogResult.OK)
                        using (StreamWriter w = new StreamWriter(sfd.FileName))
                        {
                            w.Write(editor.Text);
                            File_ = sfd.FileName;
                            fileDir.Text = File_;
                            w.Close();
                        }
            } else if (fileDir.Text != "-none-" & File_ == fileDir.Text & editor.Text != "")
            {
                using (StreamWriter w = new StreamWriter(File_))
                {
                    w.Write(editor.Text);
                    w.Close();
                }
            } else if (fileDir.Text != "-none-" & File_ == fileDir.Text & editor.Text == "")
            {
                using (StreamWriter w = new StreamWriter(File_))
                {
                    w.Write(editor.Text);
                    w.Close();
                }
            } else if (fileDir.Text == "-none-" & File_ == fileDir.Text & editor.Text == "")
            {
                using (SaveFileDialog sfd = new SaveFileDialog()
                {
                    Title = "Save Blank File",
                    FileName = "file.blank",
                    Filter = "Blank File|*.blank; *.empty",
                    FilterIndex = 0
                })
                    if (sfd.ShowDialog() == DialogResult.OK)
                        using (StreamWriter w = new StreamWriter(sfd.FileName))
                        {
                            w.Write(editor.Text);
                            File_ = sfd.FileName;
                            fileDir.Text = File_;
                            w.Close();
                        }
            }
        }
        private void saveFileAs__Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Title = "Save File As",
                FileName = "file" + FileSaveType,
                Filter = "All Files|*.*",
                FilterIndex = 0
            })
                if (sfd.ShowDialog() == DialogResult.OK)
                    using (StreamWriter w = new StreamWriter(sfd.FileName))
                    {
                        w.Write(editor.Text);
                        File_ = sfd.FileName;
                        fileDir.Text = File_;
                        w.Close();
                    }
        }
        private void wordWrap_Click(object sender, EventArgs e)
        {
            wordWrap.Checked = !wordWrap.Checked;
            editor.WordWrap = wordWrap.Checked;
        }
        private void tabIndent_TextChanged(object sender, EventArgs e)
        {
            editor.TabLength = Convert.ToInt32(tabIndent.Text);
            indent.Text = "Indent: " + editor.TabLength;
        }
        private void language_TextChanged(object sender, EventArgs e)
        {
            switch (language.Text)
            {
                case "CSharp":
                    editor.Language = Language.CSharp;
                    FileSaveType = ".cs";
                    fileType.Text = "file.cs";
                    break;

                case "Custom":
                    editor.Language = Language.Custom;
                    FileSaveType = ".*";
                    fileType.Text = "file.*";
                    break;

                case "HTML":
                    editor.Language = Language.HTML;
                    FileSaveType = ".html";
                    fileType.Text = "file.html";
                    break;

                case "JS":
                    editor.Language = Language.JS;
                    FileSaveType = ".js";
                    fileType.Text = "file.js";
                    break;

                case "Lua":
                    editor.Language = Language.Lua;
                    FileSaveType = ".lua";
                    fileType.Text = "file.lua";
                    break;

                case "PHP":
                    editor.Language = Language.PHP;
                    FileSaveType = ".php";
                    fileType.Text = "file.php";
                    break;

                case "SQL":
                    editor.Language = Language.SQL;
                    FileSaveType = ".sql";
                    fileType.Text = "file.sql";
                    break;

                case "VB":
                    editor.Language = Language.VB;
                    FileSaveType = ".vb";
                    fileType.Text = "file.vb";
                    break;

                case "XML":
                    editor.Language = Language.XML;
                    FileSaveType = ".xml";
                    fileType.Text = "file.xml";
                    break;
            }
        }
        private void font_Click(object sender, EventArgs e)
        {
            using (FontDialog fd = new FontDialog()
            {
                AllowScriptChange = false,
                AllowSimulations = true,
                AllowVectorFonts = true,
                AllowVerticalFonts = false,
                ShowApply = true,
                Color = editor.ForeColor,
                FontMustExist = true,
                Font = new Font("Consolas", 9.75F),
                MaxSize = 12,
                MinSize = 8,
                FixedPitchOnly = true,
                ScriptsOnly = false,
                ShowColor = false,
                ShowEffects = false
            })
            {
                if (fd.ShowDialog() == DialogResult.OK)
                    editor.Font = fd.Font;
                fd.Apply += delegate (object sender_, EventArgs e_)
                { editor.Font = fd.Font; };
            }
        }
        private void fileDir_Click(object sender, EventArgs e)
        {
            if (fileDir.Text != "-none-")
                Process.Start(new ProcessStartInfo("explorer.exe", Path.GetDirectoryName(File_)));
            else if (fileDir.Text == "-none-")
                Process.Start(new ProcessStartInfo("explorer.exe", "C:\\"));
        }
    }
}
