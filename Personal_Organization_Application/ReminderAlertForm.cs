using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hub
{
    public partial class ReminderAlertForm : Form
    {
        public bool Snooze { get; private set; }

        public ReminderAlertForm(string reminderSummary)
        {
            InitializeComponent();
            labelSummary.Text = reminderSummary;
            Snooze = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            
            Snooze = false;
            this.Close();
        }

        private void buttonSnooze_Click(object sender, EventArgs e)
        {
            Snooze = true;
            this.Close();
        }
    }
}
