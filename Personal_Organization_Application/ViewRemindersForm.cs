using Hub.Factories;
using Hub.Managers;
using Hub.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Hub
{
    public partial class ViewRemindersForm : Form
    {

        private ReminderManager reminderManager;

        public ViewRemindersForm(ReminderManager reminderManager)
        {
            InitializeComponent();
            this.reminderManager = reminderManager;
            LoadReminders();
        }

        private void LoadReminders()
        {
            ListBoxMeetingReminders.Items.Clear();
            ListBoxTaskReminders.Items.Clear();

            var reminders = reminderManager.GetReminders();

            var meetingReminders = reminders
                .OfType<MeetingReminder>()
                .OrderBy(r => r.Date)
                .ThenBy(r => r.Time)
                .ToList();

            var taskReminders = reminders
                .OfType<TaskReminder>()
                .OrderBy(r => r.Date)
                .ThenBy(r => r.Time)
                .ToList();

            foreach (var reminder in meetingReminders)
            {
                // Creating DateTime by adding Date and Time to eachother
                // In order to check if the date and time, both are expired
                DateTime reminderDateTime = reminder.Date.Add(reminder.Time);
                string displayText = $"{reminderDateTime:dd.MM.yyyy HH\\:mm} {reminder.Summary}";
                if (reminderDateTime <= DateTime.Now)  
                {
                    displayText = "(Expired) " + displayText;
                }
                ListBoxMeetingReminders.Items.Add(displayText);
            }

            foreach (var reminder in taskReminders)
            {
                DateTime reminderDateTime = reminder.Date.Add(reminder.Time);
                string displayText = $"{reminderDateTime:dd.MM.yyyy HH\\:mm} {reminder.Summary}";
                if (reminderDateTime <= DateTime.Now) 
                {
                    displayText = "(Expired) " + displayText;
                }
                ListBoxTaskReminders.Items.Add(displayText);
            }

            // Find the nearest reminder
            var activeReminders = reminders
                        .Where(r => r.Date.Add(r.Time) > DateTime.Now)
                        .OrderBy(r => r.Date.Add(r.Time))
                        .FirstOrDefault();

            if (activeReminders != null)
            {
                string nearestReminderName = activeReminders.Summary;
                
            }
        }

        private void ListBoxMeetingReminders_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change the screen
            if (ListBoxMeetingReminders.SelectedIndex != -1)
            {
                ListBoxTaskReminders.ClearSelected();
                var selectedReminder = reminderManager.GetReminders().OfType<MeetingReminder>().ElementAt(ListBoxMeetingReminders.SelectedIndex);
                DisplayReminderDetails(selectedReminder);
            }
        }

        private void ListBoxTaskReminders_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change the screen
            if (ListBoxTaskReminders.SelectedIndex != -1)
            {
                ListBoxMeetingReminders.ClearSelected();
                var selectedReminder = reminderManager.GetReminders().OfType<TaskReminder>().ElementAt(ListBoxTaskReminders.SelectedIndex);
                DisplayReminderDetails(selectedReminder);
            }
        }

        private void DisplayReminderDetails(Reminder reminder)
        {
            DateTimePickerDate.Value = reminder.Date;
            DateTimePickerTime.Value = DateTime.Today.Add(reminder.Time);
            TextBoxSummary.Text = reminder.Summary;

            TextBoxDescription.Text = reminder.Description.Replace("\\n", Environment.NewLine);
            ComboBoxReminderType.SelectedItem = reminder is MeetingReminder ? "Meeting" : "Task";

        }

        private void ButtonUpdateReminder_Click(object sender, EventArgs e)
        {
            if (ListBoxMeetingReminders.SelectedIndex != -1)
            {
                var index = ListBoxMeetingReminders.SelectedIndex;
                CreateReminderFromForm(1, index);
                MessageBox.Show("Reminder updated successfully!");
            }
            else if (ListBoxTaskReminders.SelectedIndex != -1)
            {
                var index = ListBoxTaskReminders.SelectedIndex;
                CreateReminderFromForm(2, index);
                MessageBox.Show("Reminder updated successfully!");
            }
            else
            {
                MessageBox.Show("Please choose a reminder.");
            }
            // Clearing the screen after the operation
            DateTimePickerDate.Value = DateTime.Now;
            DateTimePickerTime.Value = DateTime.Now;
            TextBoxSummary.Clear();
            TextBoxDescription.Clear();
            ComboBoxReminderType.SelectedIndex = -1;
            LoadReminders();

        }

        private void ButtonDeleteReminder_Click(object sender, EventArgs e)
        {
            if (ListBoxMeetingReminders.SelectedIndex != -1)
            {
                DeleteReminder(ListBoxMeetingReminders.SelectedIndex, typeof(MeetingReminder));
                MessageBox.Show("Reminder deleted successfully!");
            }
            else if (ListBoxTaskReminders.SelectedIndex != -1)
            {
                DeleteReminder(ListBoxTaskReminders.SelectedIndex, typeof(TaskReminder));
                MessageBox.Show("Reminder deleted successfully!");
            }
            else
            {
                MessageBox.Show("Please choose a reminder.");
            }
            // Clearing the screen after the operation
            DateTimePickerDate.Value = DateTime.Now;
            DateTimePickerTime.Value = DateTime.Now;
            TextBoxSummary.Clear();
            TextBoxDescription.Clear();
            ComboBoxReminderType.SelectedIndex = -1;
            LoadReminders();

        }

        private void DeleteReminder(int index, Type reminderType)
        {
            var reminders = reminderManager.GetReminders();
            var reminder = reminders.Where(r => r.GetType() == reminderType).ElementAt(index);
            reminderManager.DeleteReminder(reminders.IndexOf(reminder));

        }

        private void CreateReminderFromForm(int reminderType, int index)
        {
            string selectedReminderType = ComboBoxReminderType.SelectedItem.ToString();
            Type currentReminderType = reminderType == 1 ? typeof(MeetingReminder) : typeof(TaskReminder);

            // Delete the old reminder first
            // In order to make sure everthing has changed
            DeleteReminder(index, currentReminderType);

            ReminderFactory factory = selectedReminderType == "Meeting" ? (ReminderFactory)new MeetingReminderFactory() : new TaskReminderFactory();
            var reminder = factory.CreateReminder();
            reminder.Date = DateTimePickerDate.Value;
            reminder.Time = DateTimePickerTime.Value.TimeOfDay;
            reminder.Summary = TextBoxSummary.Text;
            reminder.Description = TextBoxDescription.Text.Replace(Environment.NewLine, "\\n");
            reminderManager.AddReminder(reminder);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReminderMain reminderMain = new ReminderMain(reminderManager);
            reminderMain.Show();
            this.Close();
        }

        private void ViewRemindersForm_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(700, 325);
        }
    }
}
