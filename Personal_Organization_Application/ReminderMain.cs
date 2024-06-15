using System;
using System.Drawing;
using System.Windows.Forms;
using Hub.Managers;
using Hub.Observers;

namespace Hub
{
    public partial class ReminderMain : Form
    {
        private ReminderManager reminderManager;
        private ReminderNotification reminderNotification;

        public ReminderMain(ReminderManager manager)
        {
            InitializeComponent();
            reminderManager = manager;
            reminderNotification = new ReminderNotification(reminderManager);
            reminderManager.AddObserver(reminderNotification);
        }

        private void buttonViewReminders_Click(object sender, EventArgs e)
        {
            ViewRemindersForm viewRemindersForm = new ViewRemindersForm(reminderManager);
            viewRemindersForm.Show();
            this.Close();
        }

        private void buttonAddReminder_Click(object sender, EventArgs e)
        {
            AddReminderForm addReminderForm = new AddReminderForm(reminderManager);
            addReminderForm.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Hub.isOpen = false;
        }

        private void buttonViewReminders_MouseEnter(object sender, EventArgs e)
        {
            buttonViewReminders.Location = new Point(buttonViewReminders.Location.X + 2, buttonViewReminders.Location.Y - 2);
        }

        private void buttonViewReminders_MouseLeave(object sender, EventArgs e)
        {
            buttonViewReminders.Location = new Point(buttonViewReminders.Location.X - 2, buttonViewReminders.Location.Y + 2);
        }

        private void buttonAddReminder_MouseEnter(object sender, EventArgs e)
        {
            buttonAddReminder.Location = new Point(buttonAddReminder.Location.X + 2, buttonAddReminder.Location.Y - 2);
        }

        private void buttonAddReminder_MouseLeave(object sender, EventArgs e)
        {
            buttonAddReminder.Location = new Point(buttonAddReminder.Location.X - 2, buttonAddReminder.Location.Y + 2);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - 2, pictureBox1.Location.Y + 2);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 2, pictureBox1.Location.Y - 2);
        }

        private void ReminderMain_Load(object sender, EventArgs e)
        {
            this.Location = new Point(900,400);
        }
    }
}
