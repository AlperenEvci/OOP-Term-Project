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
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Notes = new System.Windows.Forms.PictureBox();
            this.SalaryApp = new System.Windows.Forms.PictureBox();
            this.ReminderApp = new System.Windows.Forms.PictureBox();
            this.PhoneApp = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.management = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.hh = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.Profile = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReminderApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneApp)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.management)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).BeginInit();
            this.SuspendLayout();
            // 
            // timerDateTime
            // 
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Notes);
            this.panel2.Controls.Add(this.SalaryApp);
            this.panel2.Controls.Add(this.ReminderApp);
            this.panel2.Controls.Add(this.PhoneApp);
            this.panel2.Location = new System.Drawing.Point(12, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 127);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "Phone Book";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(405, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 36);
            this.label3.TabIndex = 16;
            this.label3.Text = "Salary Calculator";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(292, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 14);
            this.label4.TabIndex = 15;
            this.label4.Text = "Reminder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(179, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "Notes";
            // 
            // Notes
            // 
            this.Notes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Notes.Image = global::Hub.Properties.Resources.notes1;
            this.Notes.Location = new System.Drawing.Point(166, 12);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(73, 76);
            this.Notes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Notes.TabIndex = 13;
            this.Notes.TabStop = false;
            this.Notes.Click += new System.EventHandler(this.Notes_Click);
            this.Notes.MouseEnter += new System.EventHandler(this.Notes_MouseEnter);
            this.Notes.MouseLeave += new System.EventHandler(this.Notes_MouseLeave);
            // 
            // SalaryApp
            // 
            this.SalaryApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalaryApp.Image = global::Hub.Properties.Resources.calculation;
            this.SalaryApp.Location = new System.Drawing.Point(408, 12);
            this.SalaryApp.Name = "SalaryApp";
            this.SalaryApp.Size = new System.Drawing.Size(73, 76);
            this.SalaryApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalaryApp.TabIndex = 12;
            this.SalaryApp.TabStop = false;
            this.SalaryApp.Click += new System.EventHandler(this.SalaryApp_Click);
            this.SalaryApp.MouseEnter += new System.EventHandler(this.SalaryApp_MouseEnter);
            this.SalaryApp.MouseLeave += new System.EventHandler(this.SalaryApp_MouseLeave);
            // 
            // ReminderApp
            // 
            this.ReminderApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReminderApp.Image = global::Hub.Properties.Resources.notification;
            this.ReminderApp.Location = new System.Drawing.Point(289, 12);
            this.ReminderApp.Name = "ReminderApp";
            this.ReminderApp.Size = new System.Drawing.Size(73, 76);
            this.ReminderApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ReminderApp.TabIndex = 10;
            this.ReminderApp.TabStop = false;
            this.ReminderApp.MouseEnter += new System.EventHandler(this.ReminderApp_MouseEnter);
            this.ReminderApp.MouseLeave += new System.EventHandler(this.ReminderApp_MouseLeave);
            // 
            // PhoneApp
            // 
            this.PhoneApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PhoneApp.Image = global::Hub.Properties.Resources.bgg;
            this.PhoneApp.Location = new System.Drawing.Point(43, 12);
            this.PhoneApp.Name = "PhoneApp";
            this.PhoneApp.Size = new System.Drawing.Size(73, 76);
            this.PhoneApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhoneApp.TabIndex = 11;
            this.PhoneApp.TabStop = false;
            this.PhoneApp.Click += new System.EventHandler(this.PhoneApp_Click);
            this.PhoneApp.MouseEnter += new System.EventHandler(this.PhoneApp_MouseEnter);
            this.PhoneApp.MouseLeave += new System.EventHandler(this.PhoneApp_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BackgroundImage = global::Hub.Properties.Resources.asdasdasdas1;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.management);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.hh);
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.Profile);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 172);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // management
            // 
            this.management.BackColor = System.Drawing.Color.Transparent;
            this.management.Cursor = System.Windows.Forms.Cursors.Hand;
            this.management.Image = global::Hub.Properties.Resources.setting;
            this.management.Location = new System.Drawing.Point(75, 12);
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
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = global::Hub.Properties.Resources.power;
            this.exit.Location = new System.Drawing.Point(12, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(41, 42);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 5;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            // 
            // hh
            // 
            this.hh.AutoSize = true;
            this.hh.BackColor = System.Drawing.Color.Transparent;
            this.hh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hh.Location = new System.Drawing.Point(177, 48);
            this.hh.Name = "hh";
            this.hh.Size = new System.Drawing.Size(161, 25);
            this.hh.TabIndex = 4;
            this.hh.Text = "Hello, Alperen";
            // 
            // time
            // 
            this.time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.time.ForeColor = System.Drawing.SystemColors.Control;
            this.time.Location = new System.Drawing.Point(151, 73);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(200, 25);
            this.time.TabIndex = 3;
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.time.Click += new System.EventHandler(this.time_Click);
            // 
            // Profile
            // 
            this.Profile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Profile.Image = global::Hub.Properties.Resources.Contacts;
            this.Profile.Location = new System.Drawing.Point(423, 12);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(73, 76);
            this.Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Profile.TabIndex = 1;
            this.Profile.TabStop = false;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 331);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Organization App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReminderApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneApp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.management)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Profile;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label hh;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Notes;
        private System.Windows.Forms.PictureBox SalaryApp;
        private System.Windows.Forms.PictureBox ReminderApp;
        private System.Windows.Forms.PictureBox PhoneApp;
        private System.Windows.Forms.PictureBox management;
    }
}

