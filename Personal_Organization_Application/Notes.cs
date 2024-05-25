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
            Hub hub = new Hub();
            hub.Show();
        }

        private void buttonViewNotes_MouseEnter(object sender, EventArgs e)
        {
            buttonViewNotes.Location = new Point(buttonViewNotes.Location.X + 2, buttonViewNotes.Location.Y - 2);
        }

        private void buttonViewNotes_MouseLeave(object sender, EventArgs e)
        {
            buttonViewNotes.Location = new Point(buttonViewNotes.Location.X - 2, buttonViewNotes.Location.Y + 2);
        }

        private void buttonCreateNote_MouseEnter(object sender, EventArgs e)
        {
            buttonCreateNote.Location = new Point(buttonCreateNote.Location.X + 2, buttonCreateNote.Location.Y - 2);
        }

        private void buttonCreateNote_MouseLeave(object sender, EventArgs e)
        {
            buttonCreateNote.Location = new Point(buttonCreateNote.Location.X - 2, buttonCreateNote.Location.Y + 2);
        }

        private void Notes_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 2, pictureBox1.Location.Y - 2);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - 2, pictureBox1.Location.Y + 2);
        }
    }
}
