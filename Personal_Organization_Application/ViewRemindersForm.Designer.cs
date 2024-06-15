namespace Hub
{
    partial class ViewRemindersForm
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
            this.ListBoxMeetingReminders = new System.Windows.Forms.ListBox();
            this.labelMeetingReminders = new System.Windows.Forms.Label();
            this.ListBoxTaskReminders = new System.Windows.Forms.ListBox();
            this.labelTaskReminders = new System.Windows.Forms.Label();
            this.DateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.TextBoxSummary = new System.Windows.Forms.TextBox();
            this.labelSummary = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.ComboBoxReminderType = new System.Windows.Forms.ComboBox();
            this.labelReminderType = new System.Windows.Forms.Label();
            this.ButtonUpdateReminder = new System.Windows.Forms.Button();
            this.ButtonDeleteReminder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxMeetingReminders
            // 
            this.ListBoxMeetingReminders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.ListBoxMeetingReminders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBoxMeetingReminders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListBoxMeetingReminders.ForeColor = System.Drawing.Color.White;
            this.ListBoxMeetingReminders.FormattingEnabled = true;
            this.ListBoxMeetingReminders.ItemHeight = 16;
            this.ListBoxMeetingReminders.Location = new System.Drawing.Point(545, 57);
            this.ListBoxMeetingReminders.Margin = new System.Windows.Forms.Padding(2);
            this.ListBoxMeetingReminders.Name = "ListBoxMeetingReminders";
            this.ListBoxMeetingReminders.Size = new System.Drawing.Size(194, 160);
            this.ListBoxMeetingReminders.TabIndex = 0;
            this.ListBoxMeetingReminders.SelectedIndexChanged += new System.EventHandler(this.ListBoxMeetingReminders_SelectedIndexChanged);
            // 
            // labelMeetingReminders
            // 
            this.labelMeetingReminders.AutoSize = true;
            this.labelMeetingReminders.BackColor = System.Drawing.Color.Transparent;
            this.labelMeetingReminders.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMeetingReminders.ForeColor = System.Drawing.Color.White;
            this.labelMeetingReminders.Location = new System.Drawing.Point(542, 25);
            this.labelMeetingReminders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMeetingReminders.Name = "labelMeetingReminders";
            this.labelMeetingReminders.Size = new System.Drawing.Size(183, 18);
            this.labelMeetingReminders.TabIndex = 1;
            this.labelMeetingReminders.Text = "Meeting Reminders:";
            // 
            // ListBoxTaskReminders
            // 
            this.ListBoxTaskReminders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.ListBoxTaskReminders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBoxTaskReminders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListBoxTaskReminders.ForeColor = System.Drawing.Color.White;
            this.ListBoxTaskReminders.FormattingEnabled = true;
            this.ListBoxTaskReminders.ItemHeight = 16;
            this.ListBoxTaskReminders.Location = new System.Drawing.Point(336, 57);
            this.ListBoxTaskReminders.Margin = new System.Windows.Forms.Padding(2);
            this.ListBoxTaskReminders.Name = "ListBoxTaskReminders";
            this.ListBoxTaskReminders.Size = new System.Drawing.Size(194, 160);
            this.ListBoxTaskReminders.TabIndex = 0;
            this.ListBoxTaskReminders.SelectedIndexChanged += new System.EventHandler(this.ListBoxTaskReminders_SelectedIndexChanged);
            // 
            // labelTaskReminders
            // 
            this.labelTaskReminders.AutoSize = true;
            this.labelTaskReminders.BackColor = System.Drawing.Color.Transparent;
            this.labelTaskReminders.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTaskReminders.ForeColor = System.Drawing.Color.White;
            this.labelTaskReminders.Location = new System.Drawing.Point(333, 24);
            this.labelTaskReminders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTaskReminders.Name = "labelTaskReminders";
            this.labelTaskReminders.Size = new System.Drawing.Size(155, 18);
            this.labelTaskReminders.TabIndex = 1;
            this.labelTaskReminders.Text = "Task Reminders:";
            // 
            // DateTimePickerDate
            // 
            this.DateTimePickerDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.DateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerDate.Location = new System.Drawing.Point(545, 237);
            this.DateTimePickerDate.Margin = new System.Windows.Forms.Padding(2);
            this.DateTimePickerDate.Name = "DateTimePickerDate";
            this.DateTimePickerDate.Size = new System.Drawing.Size(170, 20);
            this.DateTimePickerDate.TabIndex = 2;
            // 
            // DateTimePickerTime
            // 
            this.DateTimePickerTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.DateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DateTimePickerTime.Location = new System.Drawing.Point(545, 273);
            this.DateTimePickerTime.Margin = new System.Windows.Forms.Padding(2);
            this.DateTimePickerTime.Name = "DateTimePickerTime";
            this.DateTimePickerTime.ShowUpDown = true;
            this.DateTimePickerTime.Size = new System.Drawing.Size(170, 20);
            this.DateTimePickerTime.TabIndex = 2;
            // 
            // TextBoxSummary
            // 
            this.TextBoxSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.TextBoxSummary.ForeColor = System.Drawing.Color.White;
            this.TextBoxSummary.Location = new System.Drawing.Point(11, 57);
            this.TextBoxSummary.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxSummary.Name = "TextBoxSummary";
            this.TextBoxSummary.Size = new System.Drawing.Size(296, 20);
            this.TextBoxSummary.TabIndex = 3;
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.BackColor = System.Drawing.Color.Transparent;
            this.labelSummary.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSummary.ForeColor = System.Drawing.Color.White;
            this.labelSummary.Location = new System.Drawing.Point(11, 24);
            this.labelSummary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(97, 18);
            this.labelSummary.TabIndex = 1;
            this.labelSummary.Text = "Summary:";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.TextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBoxDescription.ForeColor = System.Drawing.Color.White;
            this.TextBoxDescription.Location = new System.Drawing.Point(14, 135);
            this.TextBoxDescription.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxDescription.Size = new System.Drawing.Size(296, 164);
            this.TextBoxDescription.TabIndex = 4;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDescription.ForeColor = System.Drawing.Color.White;
            this.labelDescription.Location = new System.Drawing.Point(11, 104);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(112, 18);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Description:";
            // 
            // ComboBoxReminderType
            // 
            this.ComboBoxReminderType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.ComboBoxReminderType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxReminderType.FormattingEnabled = true;
            this.ComboBoxReminderType.Items.AddRange(new object[] {
            "Meeting",
            "Task"});
            this.ComboBoxReminderType.Location = new System.Drawing.Point(336, 266);
            this.ComboBoxReminderType.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxReminderType.Name = "ComboBoxReminderType";
            this.ComboBoxReminderType.Size = new System.Drawing.Size(170, 21);
            this.ComboBoxReminderType.TabIndex = 5;
            // 
            // labelReminderType
            // 
            this.labelReminderType.AutoSize = true;
            this.labelReminderType.BackColor = System.Drawing.Color.Transparent;
            this.labelReminderType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelReminderType.ForeColor = System.Drawing.Color.White;
            this.labelReminderType.Location = new System.Drawing.Point(333, 237);
            this.labelReminderType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReminderType.Name = "labelReminderType";
            this.labelReminderType.Size = new System.Drawing.Size(148, 18);
            this.labelReminderType.TabIndex = 1;
            this.labelReminderType.Text = "Reminder Type:";
            // 
            // ButtonUpdateReminder
            // 
            this.ButtonUpdateReminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.ButtonUpdateReminder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonUpdateReminder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonUpdateReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdateReminder.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonUpdateReminder.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdateReminder.Location = new System.Drawing.Point(14, 336);
            this.ButtonUpdateReminder.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonUpdateReminder.Name = "ButtonUpdateReminder";
            this.ButtonUpdateReminder.Size = new System.Drawing.Size(177, 40);
            this.ButtonUpdateReminder.TabIndex = 6;
            this.ButtonUpdateReminder.Text = "Update Reminder";
            this.ButtonUpdateReminder.UseVisualStyleBackColor = false;
            this.ButtonUpdateReminder.Click += new System.EventHandler(this.ButtonUpdateReminder_Click);
            // 
            // ButtonDeleteReminder
            // 
            this.ButtonDeleteReminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.ButtonDeleteReminder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonDeleteReminder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDeleteReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeleteReminder.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonDeleteReminder.Location = new System.Drawing.Point(335, 336);
            this.ButtonDeleteReminder.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonDeleteReminder.Name = "ButtonDeleteReminder";
            this.ButtonDeleteReminder.Size = new System.Drawing.Size(171, 40);
            this.ButtonDeleteReminder.TabIndex = 6;
            this.ButtonDeleteReminder.Text = "Delete Reminder";
            this.ButtonDeleteReminder.UseVisualStyleBackColor = false;
            this.ButtonDeleteReminder.Click += new System.EventHandler(this.ButtonDeleteReminder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Hub.Properties.Resources.back2_icon;
            this.pictureBox1.Location = new System.Drawing.Point(684, 319);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ViewRemindersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(750, 412);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonDeleteReminder);
            this.Controls.Add(this.ButtonUpdateReminder);
            this.Controls.Add(this.ComboBoxReminderType);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.TextBoxSummary);
            this.Controls.Add(this.DateTimePickerTime);
            this.Controls.Add(this.DateTimePickerDate);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelSummary);
            this.Controls.Add(this.labelReminderType);
            this.Controls.Add(this.labelTaskReminders);
            this.Controls.Add(this.labelMeetingReminders);
            this.Controls.Add(this.ListBoxTaskReminders);
            this.Controls.Add(this.ListBoxMeetingReminders);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewRemindersForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewRemindersForm";
            this.Load += new System.EventHandler(this.ViewRemindersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxMeetingReminders;
        private System.Windows.Forms.Label labelMeetingReminders;
        private System.Windows.Forms.ListBox ListBoxTaskReminders;
        private System.Windows.Forms.Label labelTaskReminders;
        private System.Windows.Forms.DateTimePicker DateTimePickerDate;
        private System.Windows.Forms.DateTimePicker DateTimePickerTime;
        private System.Windows.Forms.TextBox TextBoxSummary;
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.ComboBox ComboBoxReminderType;
        private System.Windows.Forms.Label labelReminderType;
        private System.Windows.Forms.Button ButtonUpdateReminder;
        private System.Windows.Forms.Button ButtonDeleteReminder;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}