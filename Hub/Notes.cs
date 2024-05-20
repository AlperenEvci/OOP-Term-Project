using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBook
{
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
            
        }
        

        private void buttonViewNotes_Click(object sender, EventArgs e)
        {
            ViewNotesForm viewNotesForm = new ViewNotesForm();
            this.Hide();
            viewNotesForm.ShowDialog();
            this.Show();
        }

        private void buttonCreateNote_Click(object sender, EventArgs e)
        {
            CreateNoteForm createNoteForm = new CreateNoteForm();
            this.Hide();
            createNoteForm.ShowDialog();
            this.Show();
        }

        private void HubButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Hub.Hub hub = new Hub.Hub();
            hub.Show();
        }
    }
}
