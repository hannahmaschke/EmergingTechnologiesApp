namespace Interactive_Symposium_App
{
    partial class ResearchQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResearchQuestionForm));
            this.researchLabel = new System.Windows.Forms.Label();
            this.researchData = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // researchLabel
            // 
            this.researchLabel.AutoSize = true;
            this.researchLabel.BackColor = System.Drawing.Color.Transparent;
            this.researchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.researchLabel.Location = new System.Drawing.Point(255, 32);
            this.researchLabel.Name = "researchLabel";
            this.researchLabel.Size = new System.Drawing.Size(306, 37);
            this.researchLabel.TabIndex = 0;
            this.researchLabel.Text = "Research Question";
            // 
            // researchData
            // 
            this.researchData.AutoSize = true;
            this.researchData.BackColor = System.Drawing.Color.Transparent;
            this.researchData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.researchData.Location = new System.Drawing.Point(46, 96);
            this.researchData.Name = "researchData";
            this.researchData.Size = new System.Drawing.Size(733, 300);
            this.researchData.TabIndex = 1;
            this.researchData.Text = resources.GetString("researchData.Text");
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.PeachPuff;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 416);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(120, 34);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Go Back";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ResearchQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(819, 462);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.researchData);
            this.Controls.Add(this.researchLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ResearchQuestionForm";
            this.Text = "ResearchQuestionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label researchLabel;
        private System.Windows.Forms.Label researchData;
        private System.Windows.Forms.Button cancelButton;
    }
}