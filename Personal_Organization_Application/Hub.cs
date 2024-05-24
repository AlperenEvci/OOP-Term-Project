using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hub
{
    public partial class Hub : Form
    {
        public Hub()
        {
            InitializeComponent();            
            this.FormClosing += MainForm_FormClosing;

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {

                DialogResult result = MessageBox.Show("Do you want to close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerDateTime.Start();
            hh.Text ="Hello, "+ UserProfile.name;
            if(UserProfile.statue == "admin")
            {
                management.Visible = true;
            }

            Image image = Functions.Base64ToImage(UserProfile.picture);
            Profile.Image = image;
        }

        

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss");
        }

        private void PhoneApp_Click(object sender, EventArgs e)
        {
            PhoneApp phoneApp = new PhoneApp();
            phoneApp.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void PhoneApp_MouseEnter(object sender, EventArgs e)
        {
            PhoneApp.Location = new Point(PhoneApp.Location.X + 2, PhoneApp.Location.Y-2);
        }

        private void PhoneApp_MouseLeave(object sender, EventArgs e)
        {
            PhoneApp.Location = new Point(PhoneApp.Location.X-2, PhoneApp.Location.Y + 2);
        }

        private void Notes_MouseEnter(object sender, EventArgs e)
        {
            Notes.Location = new Point(Notes.Location.X + 2, Notes.Location.Y - 2);
        }

        private void Notes_MouseLeave(object sender, EventArgs e)
        {
            Notes.Location = new Point(Notes.Location.X - 2, Notes.Location.Y + 2);
        }

        private void ReminderApp_MouseEnter(object sender, EventArgs e)
        {
            ReminderApp.Location = new Point(ReminderApp.Location.X + 2, ReminderApp.Location.Y - 2);
        }

        private void ReminderApp_MouseLeave(object sender, EventArgs e)
        {
            ReminderApp.Location = new Point(ReminderApp.Location.X - 2, ReminderApp.Location.Y + 2);
        }

        private void SalaryApp_MouseEnter(object sender, EventArgs e)
        {
            SalaryApp.Location = new Point(SalaryApp.Location.X + 2, SalaryApp.Location.Y - 2);
        }

        private void SalaryApp_MouseLeave(object sender, EventArgs e)
        {
            SalaryApp.Location = new Point(SalaryApp.Location.X - 2, SalaryApp.Location.Y + 2);
        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.Location = new Point(exit.Location.X + 2, exit.Location.Y - 2);
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.Location = new Point(exit.Location.X - 2, exit.Location.Y + 2);
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            PersonalInformations personalInformation = new PersonalInformations();
            personalInformation.Show();
            this.Hide();
        }

        private void SalaryApp_Click(object sender, EventArgs e)
        {
            SalaryCalculator salaryCalculator = new SalaryCalculator();
            salaryCalculator.Show();
            this.Hide();
        }

        private void Notes_Click(object sender, EventArgs e)
        {
            Notes noteBook = new Notes();
            noteBook.Show();
            this.Hide();

        }

        private void time_Click(object sender, EventArgs e)
        {

        }

        private void management_Click(object sender, EventArgs e)
        {
            management management = new management();
            management.Show();
            this.Hide();
        }

        private void management_MouseEnter(object sender, EventArgs e)
        {
            management.Location = new Point(management.Location.X + 2, management.Location.Y - 2);
        }

        private void management_MouseLeave(object sender, EventArgs e)
        {
            management.Location = new Point(management.Location.X - 2, management.Location.Y + 2);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
