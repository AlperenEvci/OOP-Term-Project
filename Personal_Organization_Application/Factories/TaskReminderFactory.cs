using Hub.Models;

namespace Hub.Factories
{
    public class TaskReminderFactory : ReminderFactory
    {
        public override Reminder CreateReminder()
        {
            return new TaskReminder();
        }
    }
}
