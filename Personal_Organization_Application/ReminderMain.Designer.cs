namespace Hub
{
    partial class ReminderMain
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddReminder = new System.Windows.Forms.PictureBox();
            this.buttonViewReminders = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAddReminder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonViewReminders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "View Reminders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(105, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Add Reminder";
            // 
            // buttonAddReminder
            // 
            this.buttonAddReminder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddReminder.Image = global::Hub.Properties.Resources.add_reminder_icon;
            this.buttonAddReminder.Location = new System.Drawing.Point(45, 109);
            this.buttonAddReminder.Name = "buttonAddReminder";
            this.buttonAddReminder.Size = new System.Drawing.Size(54, 57);
            this.buttonAddReminder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonAddReminder.TabIndex = 18;
            this.buttonAddReminder.TabStop = false;
            this.buttonAddReminder.Click += new System.EventHandler(this.buttonAddReminder_Click);
            this.buttonAddReminder.MouseEnter += new System.EventHandler(this.buttonAddReminder_MouseEnter);
            this.buttonAddReminder.MouseLeave += new System.EventHandler(this.buttonAddReminder_MouseLeave);
            // 
            // buttonViewReminders
            // 
            this.buttonViewReminders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewReminders.Image = global::Hub.Properties.Resources.view_note_icon;
            this.buttonViewReminders.Location = new System.Drawing.Point(45, 31);
            this.buttonViewReminders.Name = "buttonViewReminders";
            this.buttonViewReminders.Size = new System.Drawing.Size(54, 57);
            this.buttonViewReminders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonViewReminders.TabIndex = 16;
            this.buttonViewReminders.TabStop = false;
            this.buttonViewReminders.Click += new System.EventHandler(this.buttonViewReminders_Click);
            this.buttonViewReminders.MouseEnter += new System.EventHandler(this.buttonViewReminders_MouseEnter);
            this.buttonViewReminders.MouseLeave += new System.EventHandler(this.buttonViewReminders_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Hub.Properties.Resources.back2_icon;
            this.pictureBox1.Location = new System.Drawing.Point(201, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // ReminderMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(297, 273);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddReminder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonViewReminders);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReminderMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReminderMain";
            this.Load += new System.EventHandler(this.ReminderMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonAddReminder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonViewReminders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox buttonViewReminders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox buttonAddReminder;
        private System.Windows.Forms.Label label2;
    }
}

