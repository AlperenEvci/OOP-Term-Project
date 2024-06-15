using Hub.Managers;
using Hub.Observers;
using Hub;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Hub.phonebook_form;

namespace Hub
{
    public partial class Hub : Form
    {
        static ReminderManager reminderManager = new ReminderManager();
        ReminderNotification reminderNotification = new ReminderNotification(reminderManager);

        public static bool isOpen = false;

        ReminderMain reminderMain;
        public Hub()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Hub_KeyDown);
            reminderManager.AddObserver(reminderNotification);
            TimerNearestReminder = new Timer();
            TimerNearestReminder.Interval = 1000; 
            TimerNearestReminder.Tick += new EventHandler(TimerNearestReminder_Tick);
            TimerNearestReminder.Start();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
           
            timerDateTime.Start();
            hh.Text ="Hello, "+ UserProfile.name.ToUpper();

            if(UserProfile.statue == "admin")
            {
                management.Visible = true;
            }

            Image image = Functions.Base64ToImage(UserProfile.picture);
            Profile.Image = image;
            UpdateNearestReminderLabel();
        }
        
        public void UpdateNearestReminderLabel()
        {
            var nearestReminder = GetNearestActiveReminder();
            if (!string.IsNullOrEmpty(nearestReminder))
            {
                lblReminder.Text = $"Nearest reminder: {nearestReminder}";
            }
            else
            {
                lblReminder.Text = "";
            }
        }

        private string GetNearestActiveReminder()
        {
            var reminders = reminderManager.GetReminders();
            var activeReminders = reminders
                .Where(r => r.Date.Add(r.Time) > DateTime.Now)
                .OrderBy(r => r.Date.Add(r.Time))
                .FirstOrDefault();
            
            return activeReminders?.Summary;
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss");
        }

        private void PhoneApp_Click(object sender, EventArgs e)
        {
            
            salarycalculaterform1.Visible = false;
            managementForm.Visible = false;
            notesForm1.Visible = false;
            pı1.Visible = false;

            phonebook_form phoneForm = phonebook_form1 as phonebook_form;
            if (phoneForm == null)
            {
                phoneForm = new phonebook_form();
                phonebook_form1 = phoneForm;
                phonebook_form1.PhoneApp_Load();
            }
            
            phonebook_form1.Visible = true;

        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Logout?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(isOpen)
            {
                MessageBox.Show("You have to close Reminder App befores Logout", "ERROR!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (result == DialogResult.Yes)
            {                
                Login login = new Login();
                login.Show();
                this.Close();
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
           
            salarycalculaterform1.Visible = false;
            managementForm.Visible = false;
            notesForm1.Visible = false;
            phonebook_form1.Visible = false;
            pı1.Visible = true;
        }

        private void SalaryApp_Click(object sender, EventArgs e)
        {
            
            salarycalculaterform1.Visible = true;
            managementForm.Visible = false;
            notesForm1.Visible = false;
            phonebook_form1.Visible = false;
            pı1.Visible = false;
        }

        private void Notes_Click(object sender, EventArgs e)
        {
           
            salarycalculaterform1.Visible = false;
            managementForm.Visible = false;
            phonebook_form1.Visible = false;
            pı1.Visible = false;
            notesForm notesForm = notesForm1 as notesForm;
            if (notesForm == null)
            {
                notesForm = new notesForm();
                notesForm1 = notesForm;
            }
            notesForm1.Visible = true;

        }

        private void management_Click(object sender, EventArgs e)
        {
            
            salarycalculaterform1.Visible = false;
            notesForm1.Visible = false;
            phonebook_form1.Visible = false;
            pı1.Visible = false;
            managementcontrolform manageform = managementForm as managementcontrolform;
            if (manageform == null)
            {
                manageform = new managementcontrolform();
                managementcontrolform1 = manageform;
            }
            managementForm.Visible = true;
            managementForm.management_Load();
        }

        private void management_MouseEnter(object sender, EventArgs e)
        {
            management.Location = new Point(management.Location.X + 2, management.Location.Y - 2);
        }

        private void management_MouseLeave(object sender, EventArgs e)
        {
            management.Location = new Point(management.Location.X - 2, management.Location.Y + 2);
        }
        private void ReminderApp_Click(object sender, EventArgs e)
        {
           
            salarycalculaterform1.Visible = false;
            managementForm.Visible = false;
            notesForm1.Visible = false;
            phonebook_form1.Visible = false;
            pı1.Visible = false;

            if (!isOpen)
            {
                reminderMain = new ReminderMain(reminderManager);
                reminderMain.Show();
                isOpen = true;
            }
            else
            {
                if (Application.OpenForms["ReminderMain"] != null)
                {
                    Application.OpenForms["ReminderMain"].Focus();
                }

                if (Application.OpenForms["ViewRemindersForm"] != null)
                {
                    Application.OpenForms["ViewRemindersForm"].Focus();
                }

                if (Application.OpenForms["AddReminderForm"] != null)
                {
                    Application.OpenForms["AddReminderForm"].Focus();
                }
            }
        }
        private void Hub_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                pı1.Undo();
            }
            else if (e.Control && e.KeyCode == Keys.Y)
            {
                pı1.Redo();
            }
        }

        private void TimerNearestReminder_Tick(object sender, EventArgs e)
        {
            UpdateNearestReminderLabel();
        }
    }
}
