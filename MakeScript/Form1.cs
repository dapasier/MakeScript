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

        public MainForm()
        {
            InitializeComponent();
        }

        public void ParseFiles ()
        {
            MakeScriptParser msp = new MakeScriptParser(currentFileName);
            msp.Parse(textBoxMain.Text);
            
            toolStripFiles.Text = "Files: " + msp.FilesCount;
            startPathToolStripMenuItem.Text =   "StartPath:  " + msp.StartPath;
            outputPathToolStripMenuItem.Text =  "OutputPath: " + msp.OutputPath;
            outputFileToolStripMenuItem.Text =  "OutputFile: " + msp.OutputFile;

            toolStripFiles.DropDownItems.Clear();

            if (msp.FilesCount > 0)
            {
                for (int i = 0; i < msp.FilesCount; i++)
                {
                    toolStripFiles.DropDownItems.Add(msp.Files[i]);
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

        #region Events
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBoxMain.Text = File.ReadAllText(openFileDialog1.FileName);
            textBoxMain.Select(0, 0);
            saveToolStripMenuItem.Enabled = true;
            currentFileName = openFileDialog1.FileName;
            currentIsFileEdited = false;
            Text = BuildTitle(currentFileName, currentIsFileEdited);
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
        #endregion
    }
}
