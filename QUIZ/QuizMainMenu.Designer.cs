namespace QUIZ
{
    partial class QuizMainMenu
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
            this.quizFilesListBox = new System.Windows.Forms.ListBox();
            this.filesListHeaderLabel = new System.Windows.Forms.Label();
            this.detailsHeaderLabel = new System.Windows.Forms.Label();
            this.openButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.folderButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.detailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // quizFilesListBox
            // 
            this.quizFilesListBox.FormattingEnabled = true;
            this.quizFilesListBox.Location = new System.Drawing.Point(15, 25);
            this.quizFilesListBox.Name = "quizFilesListBox";
            this.quizFilesListBox.Size = new System.Drawing.Size(220, 82);
            this.quizFilesListBox.TabIndex = 0;
            this.quizFilesListBox.SelectedIndexChanged += new System.EventHandler(this.quizFilesListBox_SelectedIndexChanged);
            this.quizFilesListBox.DoubleClick += new System.EventHandler(this.quizFilesListBox_DoubleClick);
            // 
            // filesListHeaderLabel
            // 
            this.filesListHeaderLabel.AutoSize = true;
            this.filesListHeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.filesListHeaderLabel.Name = "filesListHeaderLabel";
            this.filesListHeaderLabel.Size = new System.Drawing.Size(52, 13);
            this.filesListHeaderLabel.TabIndex = 2;
            this.filesListHeaderLabel.Text = "Quiz Files";
            // 
            // detailsHeaderLabel
            // 
            this.detailsHeaderLabel.AutoSize = true;
            this.detailsHeaderLabel.Location = new System.Drawing.Point(12, 110);
            this.detailsHeaderLabel.Name = "detailsHeaderLabel";
            this.detailsHeaderLabel.Size = new System.Drawing.Size(39, 13);
            this.detailsHeaderLabel.TabIndex = 3;
            this.detailsHeaderLabel.Text = "Details";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(241, 54);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 4;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(241, 25);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // detailsPanel
            // 
            this.detailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailsPanel.Controls.Add(this.DetailsLabel);
            this.detailsPanel.Location = new System.Drawing.Point(16, 126);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(300, 75);
            this.detailsPanel.TabIndex = 7;
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Location = new System.Drawing.Point(4, 4);
            this.DetailsLabel.MaximumSize = new System.Drawing.Size(292, 0);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(45, 13);
            this.DetailsLabel.TabIndex = 0;
            this.DetailsLabel.Text = "(Details)";
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(241, 83);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(75, 23);
            this.folderButton.TabIndex = 9;
            this.folderButton.Text = "Folder";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(241, 207);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(210, 207);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(25, 23);
            this.helpButton.TabIndex = 11;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // QuizMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 237);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.detailsHeaderLabel);
            this.Controls.Add(this.filesListHeaderLabel);
            this.Controls.Add(this.quizFilesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuizMainMenu";
            this.ShowIcon = false;
            this.Text = "QUIZ Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox quizFilesListBox;
        private System.Windows.Forms.Label filesListHeaderLabel;
        private System.Windows.Forms.Label detailsHeaderLabel;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

