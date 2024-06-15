using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Timers;
using Hub.Models;
using Hub.Observers;

namespace Hub.Managers
{
    public class ReminderManager
    {
        private List<Reminder> reminders = new List<Reminder>();
        private string filePath = "reminders.csv";
        private List<IReminderObserver> observers = new List<IReminderObserver>();
        private Timer timer;

        public ReminderManager()
        {
            LoadRemindersFromFile();
            SetupTimer();
        }

        // Add the Reminder to Reminder list 
        public void AddReminder(Reminder reminder)
        {
            reminder.UserProfileID = UserProfile.ID;
            reminders.Add(reminder);
            reminders = reminders.OrderBy(r => r.Date).ThenBy(r => r.Time).ToList();
            SaveRemindersToFile();
        }

        public void UpdateReminder(Reminder reminder)
        {
            var index = reminders.FindIndex(r => r.Equals(reminder));
            if (index >= 0)
            {
                reminder.UserProfileID = UserProfile.ID;
                reminders[index] = reminder;
                reminders = reminders.OrderBy(r => r.Date).ThenBy(r => r.Time).ToList();
                SaveRemindersToFile();
            }
        }

        public void DeleteReminder(int index)
        {
            if (index >= 0 && index < reminders.Count)
            {
                reminders.RemoveAt(index);
                reminders = reminders.OrderBy(r => r.Date).ThenBy(r => r.Time).ToList();
                SaveRemindersToFile();
            }
        }

        public List<Reminder> GetReminders()
        {
            return reminders.Where(r => r.UserProfileID == UserProfile.ID).ToList();
        }

        private void LoadRemindersFromFile()
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                reminders = lines
                    .Select(line =>
                    {
                        try
                        {
                            var parts = ParseCsvLine(line);

                            if (parts.Length < 7) // Ensure the parts array has enough elements 
                            {
                                throw new Exception($"Invalid line format: {line}");
                            }

                            int userProfileId = int.Parse(parts[0]);

                            Reminder reminder = null;
                            if (parts[5] == "Meeting")
                            {
                                reminder = new MeetingReminder();
                            }
                            else if (parts[5] == "Task")
                            {
                                reminder = new TaskReminder();
                            }
                            else
                            {
                                throw new Exception($"Unknown reminder type: {parts[5]}");
                            }

                            reminder.UserProfileID = userProfileId;
                            reminder.Date = DateTime.Parse(parts[1]);
                            reminder.Time = TimeSpan.Parse(parts[2]);
                            reminder.Summary = parts[3];
                            reminder.Description = parts[4].Replace("\\n", Environment.NewLine);
                            reminder.LastNotified = string.IsNullOrEmpty(parts[6]) ? (DateTime?)null : DateTime.Parse(parts[6]);

                            return reminder;
                        }
                        catch (Exception ex)
                        {                            
                            Console.WriteLine($"Error processing line: {line}. Error: {ex.Message}");
                        }

                        return null;
                    })
                    .Where(reminder => reminder != null)
                    .OrderBy(r => r.Date)
                    .ThenBy(r => r.Time)
                    .ToList();
            }
        }

        private string[] ParseCsvLine(string line)
        {
            var result = new List<string>();
            var inQuotes = false;
            var value = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                var c = line[i];

                if (c == '"')
                {
                    inQuotes = !inQuotes;
                }
                else if (c == ',' && !inQuotes)
                {
                    result.Add(value.ToString());
                    value.Clear();
                }
                else
                {
                    value.Append(c);
                }
            }

            result.Add(value.ToString());
            return result.ToArray();
        }

        private void SaveRemindersToFile()
        {
            var lines = reminders.Select(reminder =>
                $"{reminder.UserProfileID},{reminder.Date},{reminder.Time},{reminder.Summary},{reminder.Description.Replace(Environment.NewLine, "\\n")},{reminder.GetType().Name.Replace("Reminder", "")},{reminder.LastNotified}");
            File.WriteAllLines(filePath, lines);
        }

        public void AddObserver(IReminderObserver observer)
        {
            observers.Add(observer);
        }

        private void NotifyObservers(Reminder reminder)
        {
            foreach (var observer in observers)
            {
                observer.Update(reminder);
            }
        }

        // Timer will help the Observer to check the date
        private void SetupTimer()
        {
            timer = new Timer(1000);
            timer.Elapsed += TimerElapsed;
            timer.Start();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            CheckReminders();
        }

        private void CheckReminders()
        {
            var now = DateTime.Now;
            var remindersToNotify = reminders
                .Where(r => r.UserProfileID == UserProfile.ID && r.Date.Date == now.Date && r.Time.Hours == now.Hour && r.Time.Minutes == now.Minute && (!r.LastNotified.HasValue || (now - r.LastNotified.Value).TotalSeconds >= 60))
                .ToList();

            foreach (var reminder in remindersToNotify)
            {
                reminder.LastNotified = now; // Update the LastNotified time
                NotifyObservers(reminder);
            }
            SaveRemindersToFile(); // Save the reminders to file to persist the LastNotified time
        }
    }
}
