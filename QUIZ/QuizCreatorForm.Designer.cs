namespace QUIZ
{
    partial class QuizCreatorForm
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
            this.helpButton = new System.Windows.Forms.Button();
            this.saveAndCloseButton = new System.Windows.Forms.Button();
            this.closeWithoutSavingButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.sameAsQuizNameBox = new System.Windows.Forms.CheckBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.answerDRadioButton = new System.Windows.Forms.RadioButton();
            this.answerDLabel = new System.Windows.Forms.Label();
            this.answerDTextBox = new System.Windows.Forms.TextBox();
            this.answerCRadioButton = new System.Windows.Forms.RadioButton();
            this.answerCLabel = new System.Windows.Forms.Label();
            this.answerCTextBox = new System.Windows.Forms.TextBox();
            this.answerBRadioButton = new System.Windows.Forms.RadioButton();
            this.answerBLabel = new System.Windows.Forms.Label();
            this.answerBTextBox = new System.Windows.Forms.TextBox();
            this.answerARadioButton = new System.Windows.Forms.RadioButton();
            this.answerALabel = new System.Windows.Forms.Label();
            this.answerATextBox = new System.Windows.Forms.TextBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.questionNumberTextLabel = new System.Windows.Forms.Label();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.addQuestionPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.addQuestionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(230, 350);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(25, 23);
            this.helpButton.TabIndex = 13;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // saveAndCloseButton
            // 
            this.saveAndCloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.saveAndCloseButton.Location = new System.Drawing.Point(261, 350);
            this.saveAndCloseButton.Name = "saveAndCloseButton";
            this.saveAndCloseButton.Size = new System.Drawing.Size(125, 23);
            this.saveAndCloseButton.TabIndex = 12;
            this.saveAndCloseButton.Text = "Save and Close";
            this.saveAndCloseButton.UseVisualStyleBackColor = true;
            this.saveAndCloseButton.Click += new System.EventHandler(this.SaveAndCloseButton_Click);
            // 
            // closeWithoutSavingButton
            // 
            this.closeWithoutSavingButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeWithoutSavingButton.Location = new System.Drawing.Point(392, 350);
            this.closeWithoutSavingButton.Name = "closeWithoutSavingButton";
            this.closeWithoutSavingButton.Size = new System.Drawing.Size(125, 23);
            this.closeWithoutSavingButton.TabIndex = 14;
            this.closeWithoutSavingButton.Text = "Close without Saving";
            this.closeWithoutSavingButton.UseVisualStyleBackColor = true;
            this.closeWithoutSavingButton.Click += new System.EventHandler(this.CloseWithoutSavingButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(62, 13);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Quiz Name:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(80, 6);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(434, 20);
            this.nameBox.TabIndex = 16;
            this.nameBox.TextChanged += new System.EventHandler(this.QuestionTextBox_TextChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(11, 35);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 17;
            this.descriptionLabel.Text = "Description:";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(80, 32);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(434, 20);
            this.descriptionBox.TabIndex = 18;
            // 
            // fileNameBox
            // 
            this.fileNameBox.Location = new System.Drawing.Point(80, 58);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.Size = new System.Drawing.Size(306, 20);
            this.fileNameBox.TabIndex = 20;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(11, 61);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(57, 13);
            this.fileNameLabel.TabIndex = 19;
            this.fileNameLabel.Text = "File Name:";
            // 
            // sameAsQuizNameBox
            // 
            this.sameAsQuizNameBox.AutoSize = true;
            this.sameAsQuizNameBox.Location = new System.Drawing.Point(392, 60);
            this.sameAsQuizNameBox.Name = "sameAsQuizNameBox";
            this.sameAsQuizNameBox.Size = new System.Drawing.Size(122, 17);
            this.sameAsQuizNameBox.TabIndex = 21;
            this.sameAsQuizNameBox.Text = "Same as Quiz Name";
            this.sameAsQuizNameBox.UseVisualStyleBackColor = true;
            this.sameAsQuizNameBox.CheckedChanged += new System.EventHandler(this.SameAsQuizNameBox_CheckedChanged);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(3, 158);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 46);
            this.previousButton.TabIndex = 37;
            this.previousButton.Text = "<< Previous Question";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // answerDRadioButton
            // 
            this.answerDRadioButton.AutoSize = true;
            this.answerDRadioButton.Location = new System.Drawing.Point(80, 135);
            this.answerDRadioButton.Name = "answerDRadioButton";
            this.answerDRadioButton.Size = new System.Drawing.Size(14, 13);
            this.answerDRadioButton.TabIndex = 36;
            this.answerDRadioButton.TabStop = true;
            this.answerDRadioButton.UseVisualStyleBackColor = true;
            // 
            // answerDLabel
            // 
            this.answerDLabel.AutoSize = true;
            this.answerDLabel.Location = new System.Drawing.Point(9, 135);
            this.answerDLabel.Name = "answerDLabel";
            this.answerDLabel.Size = new System.Drawing.Size(56, 13);
            this.answerDLabel.TabIndex = 35;
            this.answerDLabel.Text = "Answer D:";
            // 
            // answerDTextBox
            // 
            this.answerDTextBox.Location = new System.Drawing.Point(100, 132);
            this.answerDTextBox.Name = "answerDTextBox";
            this.answerDTextBox.Size = new System.Drawing.Size(394, 20);
            this.answerDTextBox.TabIndex = 34;
            // 
            // answerCRadioButton
            // 
            this.answerCRadioButton.AutoSize = true;
            this.answerCRadioButton.Location = new System.Drawing.Point(80, 109);
            this.answerCRadioButton.Name = "answerCRadioButton";
            this.answerCRadioButton.Size = new System.Drawing.Size(14, 13);
            this.answerCRadioButton.TabIndex = 33;
            this.answerCRadioButton.TabStop = true;
            this.answerCRadioButton.UseVisualStyleBackColor = true;
            // 
            // answerCLabel
            // 
            this.answerCLabel.AutoSize = true;
            this.answerCLabel.Location = new System.Drawing.Point(9, 109);
            this.answerCLabel.Name = "answerCLabel";
            this.answerCLabel.Size = new System.Drawing.Size(55, 13);
            this.answerCLabel.TabIndex = 32;
            this.answerCLabel.Text = "Answer C:";
            // 
            // answerCTextBox
            // 
            this.answerCTextBox.Location = new System.Drawing.Point(100, 106);
            this.answerCTextBox.Name = "answerCTextBox";
            this.answerCTextBox.Size = new System.Drawing.Size(394, 20);
            this.answerCTextBox.TabIndex = 31;
            // 
            // answerBRadioButton
            // 
            this.answerBRadioButton.AutoSize = true;
            this.answerBRadioButton.Location = new System.Drawing.Point(80, 83);
            this.answerBRadioButton.Name = "answerBRadioButton";
            this.answerBRadioButton.Size = new System.Drawing.Size(14, 13);
            this.answerBRadioButton.TabIndex = 30;
            this.answerBRadioButton.TabStop = true;
            this.answerBRadioButton.UseVisualStyleBackColor = true;
            // 
            // answerBLabel
            // 
            this.answerBLabel.AutoSize = true;
            this.answerBLabel.Location = new System.Drawing.Point(9, 83);
            this.answerBLabel.Name = "answerBLabel";
            this.answerBLabel.Size = new System.Drawing.Size(55, 13);
            this.answerBLabel.TabIndex = 29;
            this.answerBLabel.Text = "Answer B:";
            // 
            // answerBTextBox
            // 
            this.answerBTextBox.Location = new System.Drawing.Point(100, 80);
            this.answerBTextBox.Name = "answerBTextBox";
            this.answerBTextBox.Size = new System.Drawing.Size(394, 20);
            this.answerBTextBox.TabIndex = 28;
            // 
            // answerARadioButton
            // 
            this.answerARadioButton.AutoSize = true;
            this.answerARadioButton.Location = new System.Drawing.Point(80, 57);
            this.answerARadioButton.Name = "answerARadioButton";
            this.answerARadioButton.Size = new System.Drawing.Size(14, 13);
            this.answerARadioButton.TabIndex = 27;
            this.answerARadioButton.TabStop = true;
            this.answerARadioButton.UseVisualStyleBackColor = true;
            // 
            // answerALabel
            // 
            this.answerALabel.AutoSize = true;
            this.answerALabel.Location = new System.Drawing.Point(9, 57);
            this.answerALabel.Name = "answerALabel";
            this.answerALabel.Size = new System.Drawing.Size(55, 13);
            this.answerALabel.TabIndex = 26;
            this.answerALabel.Text = "Answer A:";
            // 
            // answerATextBox
            // 
            this.answerATextBox.Location = new System.Drawing.Point(100, 54);
            this.answerATextBox.Name = "answerATextBox";
            this.answerATextBox.Size = new System.Drawing.Size(394, 20);
            this.answerATextBox.TabIndex = 25;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(9, 21);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(52, 13);
            this.questionLabel.TabIndex = 24;
            this.questionLabel.Text = "Question:";
            // 
            // questionNumberTextLabel
            // 
            this.questionNumberTextLabel.AutoSize = true;
            this.questionNumberTextLabel.Location = new System.Drawing.Point(9, 4);
            this.questionNumberTextLabel.Name = "questionNumberTextLabel";
            this.questionNumberTextLabel.Size = new System.Drawing.Size(92, 13);
            this.questionNumberTextLabel.TabIndex = 23;
            this.questionNumberTextLabel.Text = "Question Number:";
            // 
            // questionTextBox
            // 
            this.questionTextBox.AccessibleName = "";
            this.questionTextBox.Location = new System.Drawing.Point(80, 18);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(414, 20);
            this.questionTextBox.TabIndex = 22;
            this.questionTextBox.TextChanged += new System.EventHandler(this.QuestionTextBox_TextChanged);
            // 
            // addQuestionPanel
            // 
            this.addQuestionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addQuestionPanel.Controls.Add(this.deleteButton);
            this.addQuestionPanel.Controls.Add(this.questionNumberTextLabel);
            this.addQuestionPanel.Controls.Add(this.questionNumberLabel);
            this.addQuestionPanel.Controls.Add(this.questionLabel);
            this.addQuestionPanel.Controls.Add(this.questionTextBox);
            this.addQuestionPanel.Controls.Add(this.answerALabel);
            this.addQuestionPanel.Controls.Add(this.answerARadioButton);
            this.addQuestionPanel.Controls.Add(this.answerATextBox);
            this.addQuestionPanel.Controls.Add(this.answerBLabel);
            this.addQuestionPanel.Controls.Add(this.answerBRadioButton);
            this.addQuestionPanel.Controls.Add(this.answerBTextBox);
            this.addQuestionPanel.Controls.Add(this.answerCLabel);
            this.addQuestionPanel.Controls.Add(this.answerCRadioButton);
            this.addQuestionPanel.Controls.Add(this.answerCTextBox);
            this.addQuestionPanel.Controls.Add(this.answerDLabel);
            this.addQuestionPanel.Controls.Add(this.answerDRadioButton);
            this.addQuestionPanel.Controls.Add(this.answerDTextBox);
            this.addQuestionPanel.Controls.Add(this.previousButton);
            this.addQuestionPanel.Controls.Add(this.saveButton);
            this.addQuestionPanel.Controls.Add(this.nextButton);
            this.addQuestionPanel.Controls.Add(this.messageLabel);
            this.addQuestionPanel.Location = new System.Drawing.Point(12, 92);
            this.addQuestionPanel.Name = "addQuestionPanel";
            this.addQuestionPanel.Size = new System.Drawing.Size(501, 252);
            this.addQuestionPanel.TabIndex = 38;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(257, 158);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 46);
            this.deleteButton.TabIndex = 40;
            this.deleteButton.Text = "Delete Question";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Location = new System.Drawing.Point(102, 4);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(13, 13);
            this.questionNumberLabel.TabIndex = 20;
            this.questionNumberLabel.Text = "0";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(171, 158);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 46);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save Question";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(419, 158);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 46);
            this.nextButton.TabIndex = 17;
            this.nextButton.Text = "Next >> Question";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageLabel.Location = new System.Drawing.Point(3, 207);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(491, 39);
            this.messageLabel.TabIndex = 39;
            // 
            // QuizCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 375);
            this.ControlBox = false;
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.fileNameBox);
            this.Controls.Add(this.sameAsQuizNameBox);
            this.Controls.Add(this.addQuestionPanel);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.saveAndCloseButton);
            this.Controls.Add(this.closeWithoutSavingButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuizCreatorForm";
            this.ShowIcon = false;
            this.Text = "QUIZ Creator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuizCreatorForm_FormClosed);
            this.addQuestionPanel.ResumeLayout(false);
            this.addQuestionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button saveAndCloseButton;
        private System.Windows.Forms.Button closeWithoutSavingButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox fileNameBox;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.CheckBox sameAsQuizNameBox;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.RadioButton answerDRadioButton;
        private System.Windows.Forms.Label answerDLabel;
        private System.Windows.Forms.TextBox answerDTextBox;
        private System.Windows.Forms.RadioButton answerCRadioButton;
        private System.Windows.Forms.Label answerCLabel;
        private System.Windows.Forms.TextBox answerCTextBox;
        private System.Windows.Forms.RadioButton answerBRadioButton;
        private System.Windows.Forms.Label answerBLabel;
        private System.Windows.Forms.TextBox answerBTextBox;
        private System.Windows.Forms.RadioButton answerARadioButton;
        private System.Windows.Forms.Label answerALabel;
        private System.Windows.Forms.TextBox answerATextBox;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label questionNumberTextLabel;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Panel addQuestionPanel;
        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button deleteButton;
    }
}