namespace QUIZ
{
    partial class HelpForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.helpPanel = new System.Windows.Forms.Panel();
            this.helpLabel = new System.Windows.Forms.Label();
            this.helpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(150, 326);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // helpPanel
            // 
            this.helpPanel.AutoScroll = true;
            this.helpPanel.AutoScrollMargin = new System.Drawing.Size(3, 3);
            this.helpPanel.Controls.Add(this.helpLabel);
            this.helpPanel.Location = new System.Drawing.Point(13, 13);
            this.helpPanel.Name = "helpPanel";
            this.helpPanel.Size = new System.Drawing.Size(359, 307);
            this.helpPanel.TabIndex = 2;
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Location = new System.Drawing.Point(4, 4);
            this.helpLabel.Margin = new System.Windows.Forms.Padding(3);
            this.helpLabel.MaximumSize = new System.Drawing.Size(351, 0);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(53, 13);
            this.helpLabel.TabIndex = 0;
            this.helpLabel.Text = "helpLabel";
            // 
            // HelpMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.helpPanel);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpMainForm";
            this.ShowIcon = false;
            this.Text = "Help";
            this.helpPanel.ResumeLayout(false);
            this.helpPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel helpPanel;
        private System.Windows.Forms.Label helpLabel;
    }
}