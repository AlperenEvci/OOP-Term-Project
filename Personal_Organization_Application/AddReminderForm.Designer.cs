namespace Hub
{
    partial class AddReminderForm
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
            this.DateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.TextBoxSummary = new System.Windows.Forms.TextBox();
            this.labelSummary = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.DateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.ComboBoxReminderType = new System.Windows.Forms.ComboBox();
            this.labelReminderType = new System.Windows.Forms.Label();
            this.ButtonAddReminder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimePickerDate
            // 
            this.DateTimePickerDate.CustomFormat = "dd/MM/yyyy";
            this.DateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerDate.Location = new System.Drawing.Point(32, 50);
            this.DateTimePickerDate.Margin = new System.Windows.Forms.Padding(2);
            this.DateTimePickerDate.Name = "DateTimePickerDate";
            this.DateTimePickerDate.Size = new System.Drawing.Size(135, 20);
            this.DateTimePickerDate.TabIndex = 0;
            // 
            // TextBoxSummary
            // 
            this.TextBoxSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.TextBoxSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBoxSummary.ForeColor = System.Drawing.Color.White;
            this.TextBoxSummary.Location = new System.Drawing.Point(260, 49);
            this.TextBoxSummary.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxSummary.Name = "TextBoxSummary";
            this.TextBoxSummary.Size = new System.Drawing.Size(266, 26);
            this.TextBoxSummary.TabIndex = 2;
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSummary.ForeColor = System.Drawing.Color.White;
            this.labelSummary.Location = new System.Drawing.Point(257, 26);
            this.labelSummary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(97, 18);
            this.labelSummary.TabIndex = 3;
            this.labelSummary.Text = "Summary:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDescription.ForeColor = System.Drawing.Color.White;
            this.labelDescription.Location = new System.Drawing.Point(257, 88);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(112, 18);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description:";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.TextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBoxDescription.ForeColor = System.Drawing.Color.White;
            this.TextBoxDescription.Location = new System.Drawing.Point(260, 112);
            this.TextBoxDescription.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxDescription.Size = new System.Drawing.Size(266, 124);
            this.TextBoxDescription.TabIndex = 4;
            // 
            // DateTimePickerTime
            // 
            this.DateTimePickerTime.CustomFormat = "HH:mm";
            this.DateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerTime.Location = new System.Drawing.Point(32, 84);
            this.DateTimePickerTime.Margin = new System.Windows.Forms.Padding(2);
            this.DateTimePickerTime.Name = "DateTimePickerTime";
            this.DateTimePickerTime.ShowUpDown = true;
            this.DateTimePickerTime.Size = new System.Drawing.Size(135, 20);
            this.DateTimePickerTime.TabIndex = 1;
            // 
            // ComboBoxReminderType
            // 
            this.ComboBoxReminderType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.ComboBoxReminderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComboBoxReminderType.ForeColor = System.Drawing.Color.White;
            this.ComboBoxReminderType.FormattingEnabled = true;
            this.ComboBoxReminderType.Items.AddRange(new object[] {
            "Meeting",
            "Task"});
            this.ComboBoxReminderType.Location = new System.Drawing.Point(32, 154);
            this.ComboBoxReminderType.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxReminderType.Name = "ComboBoxReminderType";
            this.ComboBoxReminderType.Size = new System.Drawing.Size(135, 28);
            this.ComboBoxReminderType.TabIndex = 5;
            // 
            // labelReminderType
            // 
            this.labelReminderType.AutoSize = true;
            this.labelReminderType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelReminderType.ForeColor = System.Drawing.Color.White;
            this.labelReminderType.Location = new System.Drawing.Point(29, 124);
            this.labelReminderType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReminderType.Name = "labelReminderType";
            this.labelReminderType.Size = new System.Drawing.Size(148, 18);
            this.labelReminderType.TabIndex = 3;
            this.labelReminderType.Text = "Reminder Type:";
            // 
            // ButtonAddReminder
            // 
            this.ButtonAddReminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.ButtonAddReminder.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonAddReminder.Location = new System.Drawing.Point(260, 257);
            this.ButtonAddReminder.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonAddReminder.Name = "ButtonAddReminder";
            this.ButtonAddReminder.Size = new System.Drawing.Size(266, 37);
            this.ButtonAddReminder.TabIndex = 6;
            this.ButtonAddReminder.Text = "Add Reminder";
            this.ButtonAddReminder.UseVisualStyleBackColor = false;
            this.ButtonAddReminder.Click += new System.EventHandler(this.ButtonAddReminder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Hub.Properties.Resources.back2_icon;
            this.pictureBox1.Location = new System.Drawing.Point(472, 308);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddReminderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(561, 382);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonAddReminder);
            this.Controls.Add(this.ComboBoxReminderType);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.labelReminderType);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelSummary);
            this.Controls.Add(this.TextBoxSummary);
            this.Controls.Add(this.DateTimePickerTime);
            this.Controls.Add(this.DateTimePickerDate);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddReminderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddReminderForm";
            this.Load += new System.EventHandler(this.AddReminderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePickerDate;
        private System.Windows.Forms.TextBox TextBoxSummary;
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.DateTimePicker DateTimePickerTime;
        private System.Windows.Forms.ComboBox ComboBoxReminderType;
        private System.Windows.Forms.Label labelReminderType;
        private System.Windows.Forms.Button ButtonAddReminder;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}