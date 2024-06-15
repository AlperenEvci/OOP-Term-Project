using System;
using System.Threading;
using System.Windows.Forms;
using Hub.Managers;
using Hub.Models;

namespace Hub.Observers
{
    public class ReminderNotification : IReminderObserver
    {
        private readonly SynchronizationContext synchronizationContext;
        private readonly ReminderManager reminderManager;
        // Making sure shaking done only 1 time
        private static bool hasRunOnce = false; 

        public ReminderNotification(ReminderManager reminderManager)
        {
            synchronizationContext = SynchronizationContext.Current;
            this.reminderManager = reminderManager;
        }

        public void Update(Reminder reminder)
        {
            if (synchronizationContext != null)
            {
                synchronizationContext.Post(new SendOrPostCallback(o =>
                {
                    ShowReminderAlert(reminder);
                }), null);
            }
        }

        private void ShowReminderAlert(Reminder reminder)
        {
            // Open an alert screen
            if (hasRunOnce) return;
            hasRunOnce = true;


            using (var alertForm = new ReminderAlertForm(reminder.Summary))
            {
                ShakeWindows();
                alertForm.ShowDialog();
                hasRunOnce = false;
                // Snooze 5 minutes 
                if (alertForm.Snooze)
                {
                    reminder.Time = reminder.Time.Add(TimeSpan.FromMinutes(5));
                    reminder.LastNotified = null;
                    reminderManager.UpdateReminder(reminder);
                }
            }
        }

        private void ShakeWindows()
        {
           
            foreach (Form form in Application.OpenForms)
            {

                var originalLocation = form.Location;
                var rnd = new Random();
                const int shakeAmplitude = 20;

                form.Invoke(new Action(() =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        var offsetX = rnd.Next(-shakeAmplitude, shakeAmplitude);
                        var offsetY = rnd.Next(-shakeAmplitude, shakeAmplitude);
                        form.Location = new System.Drawing.Point(originalLocation.X + offsetX, originalLocation.Y + offsetY);
                        Thread.Sleep(20);
                    }
                    form.Location = originalLocation;
                }));
            }
        }
    }
}


