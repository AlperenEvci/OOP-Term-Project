namespace Hub
{
    partial class Hub
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hub));
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.hh = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.phonebook_form1 = new phonebook_form();
            this.pı1 = new PI();
            this.notesForm1 = new notesForm();
            this.managementForm = new managementcontrolform();
            this.salarycalculaterform1 = new salarycalculaterform();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblReminder = new System.Windows.Forms.Label();
            this.PhoneApp = new System.Windows.Forms.PictureBox();
            this.ReminderApp = new System.Windows.Forms.PictureBox();
            this.SalaryApp = new System.Windows.Forms.PictureBox();
            this.Profile = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.Notes = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.management = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TimerNearestReminder = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReminderApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.management)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerDateTime
            // 
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // hh
            // 
            this.hh.AutoSize = true;
            this.hh.BackColor = System.Drawing.Color.Transparent;
            this.hh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hh.Location = new System.Drawing.Point(374, 9);
            this.hh.Name = "hh";
            this.hh.Size = new System.Drawing.Size(0, 25);
            this.hh.TabIndex = 4;
            // 
            // time
            // 
            this.time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.time.ForeColor = System.Drawing.SystemColors.Control;
            this.time.Location = new System.Drawing.Point(711, 11);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(200, 25);
            this.time.TabIndex = 3;
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.panel3.Controls.Add(this.phonebook_form1);
            this.panel3.Controls.Add(this.pı1);
            this.panel3.Controls.Add(this.notesForm1);
            this.panel3.Controls.Add(this.managementForm);
            this.panel3.Controls.Add(this.salarycalculaterform1);
            this.panel3.Location = new System.Drawing.Point(202, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(935, 559);
            this.panel3.TabIndex = 2;
            // 
            // phonebook_form1
            // 
            this.phonebook_form1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.phonebook_form1.ForeColor = System.Drawing.Color.White;
            this.phonebook_form1.Location = new System.Drawing.Point(272, 27);
            this.phonebook_form1.Name = "phonebook_form1";
            this.phonebook_form1.Size = new System.Drawing.Size(409, 490);
            this.phonebook_form1.TabIndex = 3;
            this.phonebook_form1.Visible = false;
            // 
            // pı1
            // 
            this.pı1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pı1.BackgroundImage")));
            this.pı1.Location = new System.Drawing.Point(0, 0);
            this.pı1.Name = "pı1";
            this.pı1.Size = new System.Drawing.Size(935, 562);
            this.pı1.TabIndex = 5;
            this.pı1.Visible = false;
            // 
            // notesForm1
            // 
            this.notesForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notesForm1.Location = new System.Drawing.Point(0, 0);
            this.notesForm1.Name = "notesForm1";
            this.notesForm1.Size = new System.Drawing.Size(935, 559);
            this.notesForm1.TabIndex = 4;
            this.notesForm1.Visible = false;
            // 
            // managementForm
            // 
            this.managementForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managementForm.Location = new System.Drawing.Point(0, 0);
            this.managementForm.Name = "managementForm";
            this.managementForm.Size = new System.Drawing.Size(935, 559);
            this.managementForm.TabIndex = 2;
            this.managementForm.Visible = false;
            // 
            // salarycalculaterform1
            // 
            this.salarycalculaterform1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.salarycalculaterform1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salarycalculaterform1.Location = new System.Drawing.Point(0, 0);
            this.salarycalculaterform1.Name = "salarycalculaterform1";
            this.salarycalculaterform1.Size = new System.Drawing.Size(935, 559);
            this.salarycalculaterform1.TabIndex = 1;
            this.salarycalculaterform1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(74)))), ((int)(((byte)(91)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblReminder);
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.hh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(202, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 56);
            this.panel1.TabIndex = 7;
            // 
            // lblReminder
            // 
            this.lblReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReminder.ForeColor = System.Drawing.Color.White;
            this.lblReminder.Location = new System.Drawing.Point(19, 13);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(304, 23);
            this.lblReminder.TabIndex = 5;
            // 
            // PhoneApp
            // 
            this.PhoneApp.BackColor = System.Drawing.Color.Transparent;
            this.PhoneApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PhoneApp.Image = global::Hub.Properties.Resources.phonebook_icon;
            this.PhoneApp.Location = new System.Drawing.Point(18, 272);
            this.PhoneApp.Name = "PhoneApp";
            this.PhoneApp.Size = new System.Drawing.Size(73, 76);
            this.PhoneApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhoneApp.TabIndex = 11;
            this.PhoneApp.TabStop = false;
            this.PhoneApp.Click += new System.EventHandler(this.PhoneApp_Click);
            this.PhoneApp.MouseEnter += new System.EventHandler(this.PhoneApp_MouseEnter);
            this.PhoneApp.MouseLeave += new System.EventHandler(this.PhoneApp_MouseLeave);
            // 
            // ReminderApp
            // 
            this.ReminderApp.BackColor = System.Drawing.Color.Transparent;
            this.ReminderApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReminderApp.Image = global::Hub.Properties.Resources.reminder_icon;
            this.ReminderApp.Location = new System.Drawing.Point(18, 368);
            this.ReminderApp.Name = "ReminderApp";
            this.ReminderApp.Size = new System.Drawing.Size(73, 76);
            this.ReminderApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ReminderApp.TabIndex = 10;
            this.ReminderApp.TabStop = false;
            this.ReminderApp.Click += new System.EventHandler(this.ReminderApp_Click);
            this.ReminderApp.MouseEnter += new System.EventHandler(this.ReminderApp_MouseEnter);
            this.ReminderApp.MouseLeave += new System.EventHandler(this.ReminderApp_MouseLeave);
            // 
            // SalaryApp
            // 
            this.SalaryApp.BackColor = System.Drawing.Color.Transparent;
            this.SalaryApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalaryApp.Image = global::Hub.Properties.Resources.calculate_icon;
            this.SalaryApp.Location = new System.Drawing.Point(18, 459);
            this.SalaryApp.Name = "SalaryApp";
            this.SalaryApp.Size = new System.Drawing.Size(73, 76);
            this.SalaryApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalaryApp.TabIndex = 12;
            this.SalaryApp.TabStop = false;
            this.SalaryApp.Click += new System.EventHandler(this.SalaryApp_Click);
            this.SalaryApp.MouseEnter += new System.EventHandler(this.SalaryApp_MouseEnter);
            this.SalaryApp.MouseLeave += new System.EventHandler(this.SalaryApp_MouseLeave);
            // 
            // Profile
            // 
            this.Profile.BackColor = System.Drawing.Color.Transparent;
            this.Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Profile.Image = ((System.Drawing.Image)(resources.GetObject("Profile.Image")));
            this.Profile.Location = new System.Drawing.Point(63, 31);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(73, 76);
            this.Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Profile.TabIndex = 1;
            this.Profile.TabStop = false;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = global::Hub.Properties.Resources.power_icon;
            this.exit.Location = new System.Drawing.Point(143, 556);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(41, 42);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 5;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            // 
            // Notes
            // 
            this.Notes.BackColor = System.Drawing.Color.Transparent;
            this.Notes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Notes.Image = global::Hub.Properties.Resources.notesicon1;
            this.Notes.Location = new System.Drawing.Point(18, 181);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(73, 76);
            this.Notes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Notes.TabIndex = 13;
            this.Notes.TabStop = false;
            this.Notes.Click += new System.EventHandler(this.Notes_Click);
            this.Notes.MouseEnter += new System.EventHandler(this.Notes_MouseEnter);
            this.Notes.MouseLeave += new System.EventHandler(this.Notes_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(114, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Notes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(97, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Reminder";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(93, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 36);
            this.label3.TabIndex = 16;
            this.label3.Text = "Salary Calculator";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // management
            // 
            this.management.BackColor = System.Drawing.Color.Transparent;
            this.management.Cursor = System.Windows.Forms.Cursors.Hand;
            this.management.Image = global::Hub.Properties.Resources.management_icon;
            this.management.Location = new System.Drawing.Point(28, 556);
            this.management.Name = "management";
            this.management.Size = new System.Drawing.Size(41, 42);
            this.management.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.management.TabIndex = 6;
            this.management.TabStop = false;
            this.management.Visible = false;
            this.management.Click += new System.EventHandler(this.management_Click);
            this.management.MouseEnter += new System.EventHandler(this.management_MouseEnter);
            this.management.MouseLeave += new System.EventHandler(this.management_MouseLeave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "Phone Book";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(74)))), ((int)(((byte)(91)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.management);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Notes);
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.Profile);
            this.panel2.Controls.Add(this.SalaryApp);
            this.panel2.Controls.Add(this.ReminderApp);
            this.panel2.Controls.Add(this.PhoneApp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 617);
            this.panel2.TabIndex = 1;
            // 
            // TimerNearestReminder
            // 
            this.TimerNearestReminder.Tick += new System.EventHandler(this.TimerNearestReminder_Tick);
            // 
            // Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Organization App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hub_KeyDown);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReminderApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.management)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label hh;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.Panel panel3;
        private managementcontrolform managementcontrolform1;
        private System.Windows.Forms.Panel panel1;
        private salarycalculaterform salarycalculaterform1;
        private managementcontrolform managementForm;
        private phonebook_form phonebook_form1;
        private notesForm notesForm1;
        private System.Windows.Forms.PictureBox PhoneApp;
        private System.Windows.Forms.PictureBox ReminderApp;
        private System.Windows.Forms.PictureBox SalaryApp;
        private System.Windows.Forms.PictureBox Profile;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox Notes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox management;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private PI pı1;
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.Timer TimerNearestReminder;
    }
}

