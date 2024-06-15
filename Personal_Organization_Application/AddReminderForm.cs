using System;
using System.Linq;
using System.Windows.Forms;
using Hub.Factories;
using Hub.Managers;
using Hub.Models;

namespace Hub
{
    public partial class AddReminderForm : Form
    {

        private ReminderManager reminderManager;
        public AddReminderForm(ReminderManager reminderManager)
        {
            InitializeComponent();
            this.reminderManager = reminderManager;
        }

        private void ButtonAddReminder_Click(object sender, EventArgs e)
        {
            if (ComboBoxReminderType.SelectedItem == null)
            {
                MessageBox.Show("Please select a reminder type.");
                return;
            }

            if (TextBoxSummary.Text == "")
            {
                MessageBox.Show("Summary cannot be empty");
                return;
            }

            ReminderFactory factory = null;

            if (ComboBoxReminderType.SelectedItem.ToString() == "Meeting")
            {
                factory = new MeetingReminderFactory();
            }
            else if (ComboBoxReminderType.SelectedItem.ToString() == "Task")
            {
                factory = new TaskReminderFactory();
            }

            if (factory != null)
            {
                var newReminderDate = DateTimePickerDate.Value.Date;
                var newReminderSummary = TextBoxSummary.Text;

                // Check if there is a Reminder already in the csv file
                if (reminderManager.GetReminders().Any(r => r.Date.Date == newReminderDate && r.Summary == newReminderSummary))
                {
                    MessageBox.Show("A reminder with the same summary on the same date already exists.");
                    return;
                }

                // Adding the Reminder
                Reminder reminder = factory.CreateReminder();
                reminder.Date = DateTimePickerDate.Value.Date;
                reminder.Time = DateTimePickerTime.Value.TimeOfDay;
                reminder.Summary = TextBoxSummary.Text;
                reminder.Description = TextBoxDescription.Text.Replace("\r\n", "\\n").Replace("\n", "\\n");

                reminderManager.AddReminder(reminder);

                MessageBox.Show("Reminder added successfully!");

                // Clearing the screen
                DateTimePickerDate.Value = DateTime.Now;
                DateTimePickerTime.Value = DateTime.Now;
                TextBoxSummary.Clear();
                TextBoxDescription.Clear();
                ComboBoxReminderType.SelectedIndex = -1;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReminderMain reminderMain = new ReminderMain(reminderManager);
            reminderMain.Show();
            this.Close();
        }

        private void AddReminderForm_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(775, 325);
        }
    }
}
