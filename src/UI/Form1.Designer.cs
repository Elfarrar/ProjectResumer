namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnReset = new Button();
            txtDescription = new TextBox();
            label2 = new Label();
            txtAppName = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            btnOutput = new Button();
            btnSource = new Button();
            txtOutputDir = new TextBox();
            txtSourceDir = new TextBox();
            groupBox3 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            txtIgnoredFolders = new TextBox();
            txtExtensions = new TextBox();
            groupBox4 = new GroupBox();
            txtStatus = new TextBox();
            label9 = new Label();
            ltbFilesProcessed = new ListBox();
            txtFilesCount = new TextBox();
            label8 = new Label();
            txtFoldersCount = new TextBox();
            label7 = new Label();
            btnRun = new Button();
            pbLoad = new ProgressBar();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAppName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(854, 158);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Application Info";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(6, 67);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(67, 85);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(79, 45);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(769, 107);
            txtDescription.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 49);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Description:";
            // 
            // txtAppName
            // 
            txtAppName.Location = new Point(79, 16);
            txtAppName.Name = "txtAppName";
            txtAppName.Size = new Size(769, 23);
            txtAppName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "App Info:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnOutput);
            groupBox2.Controls.Add(btnSource);
            groupBox2.Controls.Add(txtOutputDir);
            groupBox2.Controls.Add(txtSourceDir);
            groupBox2.Location = new Point(15, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(854, 91);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Paths";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 54);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 5;
            label4.Text = "Output Directory:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 26);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 4;
            label3.Text = "Source Directory:";
            // 
            // btnOutput
            // 
            btnOutput.Location = new Point(773, 51);
            btnOutput.Name = "btnOutput";
            btnOutput.Size = new Size(75, 23);
            btnOutput.TabIndex = 3;
            btnOutput.Text = "Browse...";
            btnOutput.UseVisualStyleBackColor = true;
            btnOutput.Click += btnOutput_Click;
            // 
            // btnSource
            // 
            btnSource.Location = new Point(773, 22);
            btnSource.Name = "btnSource";
            btnSource.Size = new Size(75, 23);
            btnSource.TabIndex = 2;
            btnSource.Text = "Browse...";
            btnSource.UseVisualStyleBackColor = true;
            btnSource.Click += btnSource_Click;
            // 
            // txtOutputDir
            // 
            txtOutputDir.Location = new Point(118, 52);
            txtOutputDir.Name = "txtOutputDir";
            txtOutputDir.ReadOnly = true;
            txtOutputDir.Size = new Size(649, 23);
            txtOutputDir.TabIndex = 1;
            // 
            // txtSourceDir
            // 
            txtSourceDir.Location = new Point(118, 23);
            txtSourceDir.Name = "txtSourceDir";
            txtSourceDir.ReadOnly = true;
            txtSourceDir.Size = new Size(649, 23);
            txtSourceDir.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtIgnoredFolders);
            groupBox3.Controls.Add(txtExtensions);
            groupBox3.Location = new Point(15, 276);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(854, 90);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Search Rules";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 54);
            label6.Name = "label6";
            label6.Size = new Size(144, 15);
            label6.TabIndex = 3;
            label6.Text = "Ignored Folders (optional)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 25);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 2;
            label5.Text = "File Types (extensions)";
            // 
            // txtIgnoredFolders
            // 
            txtIgnoredFolders.Location = new Point(156, 51);
            txtIgnoredFolders.Name = "txtIgnoredFolders";
            txtIgnoredFolders.PlaceholderText = ".git, obj, bin";
            txtIgnoredFolders.Size = new Size(692, 23);
            txtIgnoredFolders.TabIndex = 1;
            // 
            // txtExtensions
            // 
            txtExtensions.Location = new Point(156, 22);
            txtExtensions.Name = "txtExtensions";
            txtExtensions.PlaceholderText = ".cs, .js, .json";
            txtExtensions.Size = new Size(692, 23);
            txtExtensions.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtStatus);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(ltbFilesProcessed);
            groupBox4.Controls.Add(txtFilesCount);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(txtFoldersCount);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(btnRun);
            groupBox4.Controls.Add(pbLoad);
            groupBox4.Location = new Point(15, 372);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(854, 174);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Run";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(111, 80);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(104, 23);
            txtStatus.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 83);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 7;
            label9.Text = "Status";
            // 
            // ltbFilesProcessed
            // 
            ltbFilesProcessed.FormattingEnabled = true;
            ltbFilesProcessed.Location = new Point(236, 22);
            ltbFilesProcessed.Name = "ltbFilesProcessed";
            ltbFilesProcessed.ScrollAlwaysVisible = true;
            ltbFilesProcessed.SelectionMode = SelectionMode.None;
            ltbFilesProcessed.Size = new Size(612, 79);
            ltbFilesProcessed.TabIndex = 6;
            // 
            // txtFilesCount
            // 
            txtFilesCount.Location = new Point(111, 51);
            txtFilesCount.Name = "txtFilesCount";
            txtFilesCount.ReadOnly = true;
            txtFilesCount.Size = new Size(104, 23);
            txtFilesCount.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 54);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 4;
            label8.Text = "Files Founded:";
            // 
            // txtFoldersCount
            // 
            txtFoldersCount.Location = new Point(111, 22);
            txtFoldersCount.Name = "txtFoldersCount";
            txtFoldersCount.ReadOnly = true;
            txtFoldersCount.Size = new Size(104, 23);
            txtFoldersCount.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 25);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 2;
            label7.Text = "Folders Searched:";
            // 
            // btnRun
            // 
            btnRun.Location = new Point(6, 116);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(842, 23);
            btnRun.TabIndex = 1;
            btnRun.Text = "Execute";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // pbLoad
            // 
            pbLoad.Location = new Point(6, 145);
            pbLoad.Name = "pbLoad";
            pbLoad.Size = new Size(842, 23);
            pbLoad.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Padding = new Padding(12);
            Text = "File Collector";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;

        private TextBox txtAppName;
        private TextBox txtDescription;
        private TextBox txtSourceDir;
        private TextBox txtOutputDir;
        private TextBox txtExtensions;
        private TextBox txtIgnoredFolders;
        private TextBox txtFoldersCount;
        private TextBox txtFilesCount;
        private TextBox txtStatus;

        private Button btnSource;
        private Button btnOutput;
        private Button btnRun;

        private ProgressBar pbLoad;
        
        private ListBox ltbFilesProcessed;
        private Button btnReset;
    }
}
