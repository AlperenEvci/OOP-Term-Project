using System;

namespace Hub.Models
{
    public abstract class Reminder
    {
        public int UserProfileID { get; set; } 
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }

        // Check if the reminder is expired
        public DateTime? LastNotified { get; set; } 


    }
}
