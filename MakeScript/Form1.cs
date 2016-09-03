using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MakeScript
{
    public partial class MainForm : Form
    {        
        private string currentFileName;
        private bool currentIsFileEdited;
        private List<string> sourceFiles;
        private List<string> sourceFilesExisting;
        private string outputPathFile;

        public MainForm()
        {
            InitializeComponent();
            recentsToolStripMenuItem1.UpdateList();
            sourceFiles = new List<string>();
            sourceFilesExisting = new List<string>();
        }

        public void ParseFiles()
        {
            MakeScriptParser msp = new MakeScriptParser(currentFileName);
            msp.Parse(textBoxMain.Text);
            
            toolStripFiles.Text = "Files: " + msp.FilesCount;
            startPathToolStripMenuItem.Text =   "StartPath:  " + msp.StartPath;
            outputPathToolStripMenuItem.Text =  "OutputPath: " + msp.OutputPath;
            outputFileToolStripMenuItem.Text =  "OutputFile: " + msp.OutputFile;

            sourceFiles = msp.Files;
            sourceFilesExisting.Clear();
            outputPathFile = msp.OutputPathFile;

            toolStripFiles.DropDownItems.Clear();

            if (msp.FilesCount > 0)
            {
                for (int i = 0; i < msp.FilesCount; i++)
                {
                    ToolStripMenuItem menuItem = new ToolStripMenuItem();
                    menuItem.Text = msp.Files[i];

                    if (File.Exists(msp.Files[i]))
                    {
                        sourceFilesExisting.Add(msp.Files[i]);
                        menuItem.ForeColor = System.Drawing.Color.Black;
                    }
                    else
                        menuItem.ForeColor = System.Drawing.Color.Red;

                    toolStripFiles.DropDownItems.Add(menuItem);
                }
            }
        }

        private string BuildTitle (string fileName, bool isFileEdited)
        {
            string title = "";
            const string titleConst = "MakeScript";
            const string titleSeparator = " - ";
            string titleMarker;
            StringBuilder sb = new StringBuilder();

            if (isFileEdited)
                titleMarker = "* ";
            else
                titleMarker = "";

            if (fileName != null && fileName.Length > 0)
                sb.Append(titleMarker).Append(fileName).Append(titleSeparator).Append(titleConst);
            else
                sb.Append(titleMarker).Append(titleConst);

            title = sb.ToString();

            return title;
        }

        private void OpenMakeScriptFile(string fileName)
        {
            textBoxMain.Text = File.ReadAllText(fileName);
            textBoxMain.Select(0, 0);
            saveToolStripMenuItem.Enabled = true;
            currentFileName = fileName;
            currentIsFileEdited = false;
            Text = BuildTitle(currentFileName, currentIsFileEdited);
            recentsToolStripMenuItem1.AddRecentItem(fileName);
        }

        #region Events
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenMakeScriptFile(openFileDialog1.FileName);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(saveFileDialog1.FileName, textBoxMain.Text);
            saveToolStripMenuItem.Enabled = true;
            currentFileName = saveFileDialog1.FileName;
            currentIsFileEdited = false;
            Text = BuildTitle(currentFileName, currentIsFileEdited);
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxMain.WordWrap)
            {
                textBoxMain.WordWrap = false;
            }
            else
            {
                textBoxMain.WordWrap = true;
            }
        }

        private void parseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParseFiles();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(currentFileName, textBoxMain.Text);
            currentIsFileEdited = false;
            Text = BuildTitle(currentFileName, currentIsFileEdited);
        }

        private void textBoxMain_TextChanged(object sender, EventArgs e)
        {
            if (!currentIsFileEdited)
            {
                currentIsFileEdited = true;
                Text = BuildTitle(currentFileName, currentIsFileEdited);
            }
        }

        private void buildScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = DialogResult.Yes;

            ParseFiles();

            if (sourceFiles.Count != sourceFilesExisting.Count)
            {
                dr = MessageBox.Show("Not existing file(s) were detected, if you proceed they will be ommited in final scrip.\nDo you wish to procced?", "Warning - Not existing file(s)", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);                
            }

            if (dr == DialogResult.Yes)
            {
                MakeScriptBuilder builder = new MakeScriptBuilder(sourceFilesExisting, outputPathFile);
                builder.Build();
            }
        }
        private void recentsToolStripMenuItem1_ItemClick(object sender, EventArgs e)
        {
            ToolStripMenuItem fileClicked = (ToolStripMenuItem)sender;
            OpenMakeScriptFile(fileClicked.Text);
        }
        #endregion
    }
}
