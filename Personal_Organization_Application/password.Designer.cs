namespace Hub
{
    partial class password
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.buttonGiriş = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.HubButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Email:";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(31, 38);
            this.textBoxMail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(166, 20);
            this.textBoxMail.TabIndex = 8;
            // 
            // buttonGiriş
            // 
            this.buttonGiriş.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonGiriş.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGiriş.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGiriş.Location = new System.Drawing.Point(31, 117);
            this.buttonGiriş.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGiriş.Name = "buttonGiriş";
            this.buttonGiriş.Size = new System.Drawing.Size(166, 40);
            this.buttonGiriş.TabIndex = 7;
            this.buttonGiriş.Text = "Send Password";
            this.buttonGiriş.UseVisualStyleBackColor = false;
            this.buttonGiriş.Click += new System.EventHandler(this.buttonGiriş_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(31, 82);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(166, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // HubButton
            // 
            this.HubButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HubButton.Location = new System.Drawing.Point(215, 117);
            this.HubButton.Name = "HubButton";
            this.HubButton.Size = new System.Drawing.Size(104, 40);
            this.HubButton.TabIndex = 26;
            this.HubButton.Text = "Back Login";
            this.HubButton.UseVisualStyleBackColor = true;
            this.HubButton.Click += new System.EventHandler(this.HubButton_Click);
            // 
            // password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 173);
            this.Controls.Add(this.HubButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.buttonGiriş);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Button buttonGiriş;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button HubButton;
    }
}