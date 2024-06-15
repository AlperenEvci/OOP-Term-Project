using Hub.Models;

namespace Hub.Factories
{
    public class MeetingReminderFactory : ReminderFactory
    {
        public override Reminder CreateReminder()
        {
            return new MeetingReminder();
        }
    }
}
