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
    public partial class notesForm : UserControl
    {
        public notesForm()
        {
            InitializeComponent();
        }

        private void buttonViewNotes_Click(object sender, EventArgs e)
        {
            createNoteControl1.Visible = false;
            viewNotesControl viewNotesControl = viewNotesControl1 as viewNotesControl;
            if (viewNotesControl == null)
            {
                viewNotesControl = new viewNotesControl();
                viewNotesControl1 = viewNotesControl;
            }
            viewNotesControl1.Visible = true;
            viewNotesControl1.ViewNotesForm_Load();
        }

        private void buttonCreateNote_Click(object sender, EventArgs e)
        {
            viewNotesControl1.Visible = false;
            createNoteControl createNoteControl = createNoteControl1 as createNoteControl;
            if (createNoteControl == null)
            {
                createNoteControl = new createNoteControl();
                createNoteControl1 = createNoteControl;

            }
            createNoteControl1.Visible = true;
        }

        private void HubButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
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
