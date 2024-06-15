using Hub.Models;

namespace Hub.Observers
{
    public interface IReminderObserver
    {
        void Update(Reminder reminder);
    }
}
