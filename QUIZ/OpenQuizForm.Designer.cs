namespace QUIZ
{
    partial class OpenQuizForm
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
            this.questionPanel = new System.Windows.Forms.Panel();
            this.finishButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.previousButton = new System.Windows.Forms.Button();
            this.answerDRadioButton = new System.Windows.Forms.RadioButton();
            this.answerCRadioButton = new System.Windows.Forms.RadioButton();
            this.answerBRadioButton = new System.Windows.Forms.RadioButton();
            this.answerARadioButton = new System.Windows.Forms.RadioButton();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.quizTitleLabel = new System.Windows.Forms.Label();
            this.quizDescriptionLabel = new System.Windows.Forms.Label();
            this.questionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionPanel
            // 
            this.questionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionPanel.Controls.Add(this.finishButton);
            this.questionPanel.Controls.Add(this.nextButton);
            this.questionPanel.Controls.Add(this.questionNumberLabel);
            this.questionPanel.Controls.Add(this.previousButton);
            this.questionPanel.Controls.Add(this.answerDRadioButton);
            this.questionPanel.Controls.Add(this.answerCRadioButton);
            this.questionPanel.Controls.Add(this.answerBRadioButton);
            this.questionPanel.Controls.Add(this.answerARadioButton);
            this.questionPanel.Controls.Add(this.questionTextLabel);
            this.questionPanel.Location = new System.Drawing.Point(12, 66);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(416, 200);
            this.questionPanel.TabIndex = 0;
            this.questionPanel.Tag = "";
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(326, 168);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 7;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(99, 168);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Location = new System.Drawing.Point(15, 2);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(89, 13);
            this.questionNumberLabel.TabIndex = 0;
            this.questionNumberLabel.Text = "Question Number";
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(18, 168);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 5;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // answerDRadioButton
            // 
            this.answerDRadioButton.AutoSize = true;
            this.answerDRadioButton.Location = new System.Drawing.Point(18, 132);
            this.answerDRadioButton.Name = "answerDRadioButton";
            this.answerDRadioButton.Size = new System.Drawing.Size(71, 17);
            this.answerDRadioButton.TabIndex = 4;
            this.answerDRadioButton.Text = "Answer D";
            this.answerDRadioButton.UseVisualStyleBackColor = true;
            // 
            // answerCRadioButton
            // 
            this.answerCRadioButton.AutoSize = true;
            this.answerCRadioButton.Location = new System.Drawing.Point(18, 109);
            this.answerCRadioButton.Name = "answerCRadioButton";
            this.answerCRadioButton.Size = new System.Drawing.Size(70, 17);
            this.answerCRadioButton.TabIndex = 3;
            this.answerCRadioButton.Text = "Answer C";
            this.answerCRadioButton.UseVisualStyleBackColor = true;
            // 
            // answerBRadioButton
            // 
            this.answerBRadioButton.AutoSize = true;
            this.answerBRadioButton.Location = new System.Drawing.Point(18, 86);
            this.answerBRadioButton.Name = "answerBRadioButton";
            this.answerBRadioButton.Size = new System.Drawing.Size(70, 17);
            this.answerBRadioButton.TabIndex = 2;
            this.answerBRadioButton.Text = "Answer B";
            this.answerBRadioButton.UseVisualStyleBackColor = true;
            // 
            // answerARadioButton
            // 
            this.answerARadioButton.AutoSize = true;
            this.answerARadioButton.Location = new System.Drawing.Point(18, 63);
            this.answerARadioButton.Name = "answerARadioButton";
            this.answerARadioButton.Size = new System.Drawing.Size(70, 17);
            this.answerARadioButton.TabIndex = 1;
            this.answerARadioButton.Text = "Answer A";
            this.answerARadioButton.UseVisualStyleBackColor = true;
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Location = new System.Drawing.Point(16, 24);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(73, 13);
            this.questionTextLabel.TabIndex = 0;
            this.questionTextLabel.Text = "Question Text";
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(322, 272);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(25, 23);
            this.helpButton.TabIndex = 13;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(353, 272);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // quizTitleLabel
            // 
            this.quizTitleLabel.AutoSize = true;
            this.quizTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.quizTitleLabel.Name = "quizTitleLabel";
            this.quizTitleLabel.Size = new System.Drawing.Size(51, 13);
            this.quizTitleLabel.TabIndex = 8;
            this.quizTitleLabel.Text = "Quiz Title";
            // 
            // quizDescriptionLabel
            // 
            this.quizDescriptionLabel.AutoSize = true;
            this.quizDescriptionLabel.Location = new System.Drawing.Point(13, 31);
            this.quizDescriptionLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.quizDescriptionLabel.Name = "quizDescriptionLabel";
            this.quizDescriptionLabel.Size = new System.Drawing.Size(84, 13);
            this.quizDescriptionLabel.TabIndex = 9;
            this.quizDescriptionLabel.Text = "Quiz Description";
            // 
            // OpenQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 298);
            this.ControlBox = false;
            this.Controls.Add(this.quizTitleLabel);
            this.Controls.Add(this.quizDescriptionLabel);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.questionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OpenQuizForm";
            this.ShowIcon = false;
            this.Text = "QUIZ";
            this.questionPanel.ResumeLayout(false);
            this.questionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel questionPanel;
        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.RadioButton answerDRadioButton;
        private System.Windows.Forms.RadioButton answerCRadioButton;
        private System.Windows.Forms.RadioButton answerBRadioButton;
        private System.Windows.Forms.RadioButton answerARadioButton;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Label quizTitleLabel;
        private System.Windows.Forms.Label quizDescriptionLabel;
    }
}