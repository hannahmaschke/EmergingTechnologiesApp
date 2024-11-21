namespace Interactive_Symposium_App
{
    partial class IntroductionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroductionForm));
            this.introFormLabel = new System.Windows.Forms.Label();
            this.introData = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // introFormLabel
            // 
            this.introFormLabel.AutoSize = true;
            this.introFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.introFormLabel.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introFormLabel.Location = new System.Drawing.Point(364, 22);
            this.introFormLabel.Name = "introFormLabel";
            this.introFormLabel.Size = new System.Drawing.Size(208, 45);
            this.introFormLabel.TabIndex = 0;
            this.introFormLabel.Text = "Introduction";
            // 
            // introData
            // 
            this.introData.AutoSize = true;
            this.introData.BackColor = System.Drawing.Color.Transparent;
            this.introData.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introData.Location = new System.Drawing.Point(12, 121);
            this.introData.Name = "introData";
            this.introData.Size = new System.Drawing.Size(920, 240);
            this.introData.TabIndex = 1;
            this.introData.Text = resources.GetString("introData.Text");
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(17, 447);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(129, 29);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // IntroductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(924, 488);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.introData);
            this.Controls.Add(this.introFormLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IntroductionForm";
            this.Text = "IntroductionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label introFormLabel;
        private System.Windows.Forms.Label introData;
        private System.Windows.Forms.Button cancelButton;
    }
}