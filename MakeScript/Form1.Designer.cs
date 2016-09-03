namespace MakeScript
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sortSelectedLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalizeFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertSpacesToTabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTrialingWhiteCharsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customeReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFinalScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWITHENCRIPTIONToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newDeployToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripFiles = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripParameters = new System.Windows.Forms.ToolStripDropDownButton();
            this.startPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.recentsToolStripMenuItem1 = new RecentsToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolStripMenuItem1,
            this.parseToolStripMenuItem,
            this.editToolStripMenuItem,
            this.buildScriptToolStripMenuItem,
            this.editFinalScriptToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.recentsToolStripMenuItem1,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWrapToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // wordWrapToolStripMenuItem
            // 
            this.wordWrapToolStripMenuItem.CheckOnClick = true;
            this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.wordWrapToolStripMenuItem.Text = "Word wrap";
            this.wordWrapToolStripMenuItem.Click += new System.EventHandler(this.wordWrapToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortSelectedLinesToolStripMenuItem,
            this.normalizeFilesToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem1.Text = "Edit";
            // 
            // sortSelectedLinesToolStripMenuItem
            // 
            this.sortSelectedLinesToolStripMenuItem.Enabled = false;
            this.sortSelectedLinesToolStripMenuItem.Name = "sortSelectedLinesToolStripMenuItem";
            this.sortSelectedLinesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.sortSelectedLinesToolStripMenuItem.Text = "Sort selected lines";
            // 
            // normalizeFilesToolStripMenuItem
            // 
            this.normalizeFilesToolStripMenuItem.Enabled = false;
            this.normalizeFilesToolStripMenuItem.Name = "normalizeFilesToolStripMenuItem";
            this.normalizeFilesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.normalizeFilesToolStripMenuItem.Text = "Normalize files";
            // 
            // parseToolStripMenuItem
            // 
            this.parseToolStripMenuItem.Name = "parseToolStripMenuItem";
            this.parseToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.parseToolStripMenuItem.Text = "Parse";
            this.parseToolStripMenuItem.Click += new System.EventHandler(this.parseToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertSpacesToTabsToolStripMenuItem,
            this.removeTrialingWhiteCharsToolStripMenuItem,
            this.customeReplaceToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.editToolStripMenuItem.Text = "Edit source files";
            // 
            // convertSpacesToTabsToolStripMenuItem
            // 
            this.convertSpacesToTabsToolStripMenuItem.Enabled = false;
            this.convertSpacesToTabsToolStripMenuItem.Name = "convertSpacesToTabsToolStripMenuItem";
            this.convertSpacesToTabsToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.convertSpacesToTabsToolStripMenuItem.Text = "Convert spaces to tabs";
            // 
            // removeTrialingWhiteCharsToolStripMenuItem
            // 
            this.removeTrialingWhiteCharsToolStripMenuItem.Enabled = false;
            this.removeTrialingWhiteCharsToolStripMenuItem.Name = "removeTrialingWhiteCharsToolStripMenuItem";
            this.removeTrialingWhiteCharsToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.removeTrialingWhiteCharsToolStripMenuItem.Text = "Remove trialing white chars";
            // 
            // customeReplaceToolStripMenuItem
            // 
            this.customeReplaceToolStripMenuItem.Enabled = false;
            this.customeReplaceToolStripMenuItem.Name = "customeReplaceToolStripMenuItem";
            this.customeReplaceToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.customeReplaceToolStripMenuItem.Text = "Custom replace";
            // 
            // buildScriptToolStripMenuItem
            // 
            this.buildScriptToolStripMenuItem.Name = "buildScriptToolStripMenuItem";
            this.buildScriptToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.buildScriptToolStripMenuItem.Text = "Build script";
            this.buildScriptToolStripMenuItem.Click += new System.EventHandler(this.buildScriptToolStripMenuItem_Click);
            // 
            // editFinalScriptToolStripMenuItem
            // 
            this.editFinalScriptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWITHENCRIPTIONToolStripMenuItem1,
            this.newDeployToolStripMenuItem1});
            this.editFinalScriptToolStripMenuItem.Name = "editFinalScriptToolStripMenuItem";
            this.editFinalScriptToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.editFinalScriptToolStripMenuItem.Text = "Edit final script";
            // 
            // addWITHENCRIPTIONToolStripMenuItem1
            // 
            this.addWITHENCRIPTIONToolStripMenuItem1.Enabled = false;
            this.addWITHENCRIPTIONToolStripMenuItem1.Name = "addWITHENCRIPTIONToolStripMenuItem1";
            this.addWITHENCRIPTIONToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.addWITHENCRIPTIONToolStripMenuItem1.Text = "Add WITH ENCRIPTION";
            // 
            // newDeployToolStripMenuItem1
            // 
            this.newDeployToolStripMenuItem1.Enabled = false;
            this.newDeployToolStripMenuItem1.Name = "newDeployToolStripMenuItem1";
            this.newDeployToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.newDeployToolStripMenuItem1.Text = "New deploy";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 547);
            this.panel1.TabIndex = 1;
            // 
            // textBoxMain
            // 
            this.textBoxMain.AcceptsReturn = true;
            this.textBoxMain.AcceptsTab = true;
            this.textBoxMain.AllowDrop = true;
            this.textBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMain.HideSelection = false;
            this.textBoxMain.Location = new System.Drawing.Point(0, 0);
            this.textBoxMain.Multiline = true;
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMain.Size = new System.Drawing.Size(838, 547);
            this.textBoxMain.TabIndex = 0;
            this.textBoxMain.WordWrap = false;
            this.textBoxMain.TextChanged += new System.EventHandler(this.textBoxMain_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFiles,
            this.toolStripParameters});
            this.statusStrip1.Location = new System.Drawing.Point(0, 549);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(838, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripFiles
            // 
            this.toolStripFiles.Name = "toolStripFiles";
            this.toolStripFiles.Size = new System.Drawing.Size(55, 20);
            this.toolStripFiles.Text = "Files: 0";
            // 
            // toolStripParameters
            // 
            this.toolStripParameters.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripParameters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startPathToolStripMenuItem,
            this.outputFileToolStripMenuItem,
            this.outputPathToolStripMenuItem});
            this.toolStripParameters.Image = ((System.Drawing.Image)(resources.GetObject("toolStripParameters.Image")));
            this.toolStripParameters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripParameters.Name = "toolStripParameters";
            this.toolStripParameters.Size = new System.Drawing.Size(79, 20);
            this.toolStripParameters.Text = "Parameters";
            // 
            // startPathToolStripMenuItem
            // 
            this.startPathToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.startPathToolStripMenuItem.Name = "startPathToolStripMenuItem";
            this.startPathToolStripMenuItem.ShowShortcutKeys = false;
            this.startPathToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.startPathToolStripMenuItem.Text = "StartPath:";
            // 
            // outputFileToolStripMenuItem
            // 
            this.outputFileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.outputFileToolStripMenuItem.Name = "outputFileToolStripMenuItem";
            this.outputFileToolStripMenuItem.ShowShortcutKeys = false;
            this.outputFileToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.outputFileToolStripMenuItem.Text = "OutputFile:";
            // 
            // outputPathToolStripMenuItem
            // 
            this.outputPathToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.outputPathToolStripMenuItem.Name = "outputPathToolStripMenuItem";
            this.outputPathToolStripMenuItem.ShowShortcutKeys = false;
            this.outputPathToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.outputPathToolStripMenuItem.Text = "OutputPath:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "mas";
            this.openFileDialog1.Filter = "MakeScript file|*.mas|Text file|*.txt|All files|*.*";
            this.openFileDialog1.SupportMultiDottedExtensions = true;
            this.openFileDialog1.Title = "Open MakeScript file";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "mas";
            this.saveFileDialog1.FileName = "Script";
            this.saveFileDialog1.Filter = "MakeScript file|*.mas|Text file|*.txt|All files|*.*";
            this.saveFileDialog1.Title = "Save MakeScript file";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // recentsToolStripMenuItem1
            // 
            this.recentsToolStripMenuItem1.Enabled = false;
            this.recentsToolStripMenuItem1.Name = "recentsToolStripMenuItem1";
            this.recentsToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.recentsToolStripMenuItem1.Text = "Recent";
            this.recentsToolStripMenuItem1.ItemClick += new System.EventHandler(this.recentsToolStripMenuItem1_ItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 571);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MakeScript";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertSpacesToTabsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFinalScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWITHENCRIPTIONToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newDeployToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeTrialingWhiteCharsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customeReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildScriptToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sortSelectedLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parseToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripParameters;
        private System.Windows.Forms.ToolStripMenuItem startPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripFiles;
        private System.Windows.Forms.ToolStripMenuItem outputPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalizeFilesToolStripMenuItem;
        private RecentsToolStripMenuItem recentsToolStripMenuItem1;
    }
}

