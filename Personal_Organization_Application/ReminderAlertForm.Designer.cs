namespace Hub
{
    partial class ReminderAlertForm
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
            this.labelSummary = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonSnooze = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Location = new System.Drawing.Point(119, 62);
            this.labelSummary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(0, 13);
            this.labelSummary.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(74)))), ((int)(((byte)(91)))));
            this.buttonOK.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(35, 123);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(85, 31);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonSnooze
            // 
            this.buttonSnooze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(74)))), ((int)(((byte)(91)))));
            this.buttonSnooze.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSnooze.ForeColor = System.Drawing.Color.White;
            this.buttonSnooze.Location = new System.Drawing.Point(152, 123);
            this.buttonSnooze.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSnooze.Name = "buttonSnooze";
            this.buttonSnooze.Size = new System.Drawing.Size(85, 31);
            this.buttonSnooze.TabIndex = 1;
            this.buttonSnooze.Text = "Snooze";
            this.buttonSnooze.UseVisualStyleBackColor = false;
            this.buttonSnooze.Click += new System.EventHandler(this.buttonSnooze_Click);
            // 
            // ReminderAlertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(278, 202);
            this.Controls.Add(this.buttonSnooze);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelSummary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReminderAlertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReminderAlertForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonSnooze;
    }
}