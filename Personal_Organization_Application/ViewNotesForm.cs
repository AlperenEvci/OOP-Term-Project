using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hub
{
    public partial class ViewNotesForm : Form
    {
        private bool changesMade = false; // Indicates whether changes have been made
        private string lastTitleText = "";
        private string lastContentText = "";
        public ViewNotesForm()
        {
            InitializeComponent();
        }

        private void ViewNotesForm_Load(object sender, EventArgs e)
        {
            changesMade = false;
            listBoxNotes.Items.Clear();

            if (File.Exists("notes.csv"))
            {
                var notes = File.ReadAllLines("notes.csv");
                foreach (var note in notes)
                {
                    // Remove quotation marks first and then split with comma
                    var trimmedNote = note.Trim('"');
                    var noteParts = trimmedNote.Split(new[] { "\",\"" }, 3, StringSplitOptions.None);

                    if (noteParts[0].Trim('"') == UserProfile.ID.ToString())
                    {
                        if (noteParts.Length > 1)
                        {
                            string title = noteParts[1];
                            listBoxNotes.Items.Add(title); // Only add the title to the list
                        }
                    }                   
                }
                listBoxNotes.SelectedIndex = -1; // Initially no note is selected
            }
            else
            {
                MessageBox.Show("No notes found.");
            }
        }



        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxNotes.SelectedItem != null)
            {
                string selectedTitle = listBoxNotes.SelectedItem?.ToString() ?? string.Empty;
                var result = MessageBox.Show($"Are you sure you want to delete the note '{selectedTitle}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string[] notes = File.ReadAllLines("notes.csv");
                    List<string> updatedNotes = new List<string>();

                    foreach (var note in notes)
                    {
                        var noteParts = note.Trim('"').Split(new[] { "\",\"" }, 3, StringSplitOptions.None);

                        if (noteParts.Length > 1 && noteParts[1] != selectedTitle)
                        {
                            updatedNotes.Add(note);
                        }
                    }

                    // Write the updated notes to the file
                    File.WriteAllLines("notes.csv", updatedNotes);
                    MessageBox.Show("Note deleted successfully.");

                    listBoxNotes.Items.Clear();
                    // Clear the list box and add the updated notes
                    foreach (var note in updatedNotes)
                    {
                        var noteParts = note.Trim('"').Split(new[] { "\",\"" }, 3, StringSplitOptions.None);
                        if (noteParts.Length > 1)
                        {
                            listBoxNotes.Items.Add(noteParts[1]);
                        }
                    }
                }
                textBoxTitle.Text = "";
                textBoxContent.Text = "";
            }
            else
            {
                MessageBox.Show("No note selected.");
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            string selectedTitle = textBoxTitle.Text;
            string updatedContent = textBoxContent.Text.Replace(Environment.NewLine, "\\n");
            string oldTitle = listBoxNotes.SelectedItem?.ToString() ?? string.Empty;


            if (!string.IsNullOrEmpty(selectedTitle))
            {
                string[] notes = File.ReadAllLines("notes.csv");
                List<string> updatedNotes = new List<string>();

                foreach (var note in notes)
                {
                    var noteParts = note.Trim('"').Split(new[] { "\",\"" }, 3, StringSplitOptions.None);

                    if (noteParts.Length > 1)
                    {
                        string noteTitle = noteParts[1];

                        // If the note title has been updated, check with the updated title
                        if (noteTitle == oldTitle)
                        {
                            updatedNotes.Add($"\"{UserProfile.ID}\",\"{selectedTitle}\",\"{updatedContent}\"");
                        }
                        else
                        {
                            updatedNotes.Add(note);
                        }
                    }
                    else
                    {
                        updatedNotes.Add(note);
                    }
                }

                File.WriteAllLines("notes.csv", updatedNotes);
                MessageBox.Show("Changes saved successfully.");

                int selectedIndex = listBoxNotes.SelectedIndex;
                listBoxNotes.Items.Clear();
                foreach (var note in updatedNotes)
                {
                    var noteParts = note.Trim('"').Split(new[] { "\",\"" }, 3, StringSplitOptions.None);
                    if (noteParts.Length > 1)
                    {
                        listBoxNotes.Items.Add(noteParts[1]);
                    }
                }
                listBoxNotes.SelectedIndex = selectedIndex;
            }
            else
            {
                MessageBox.Show("No note selected.");
            }
            changesMade = false;
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTitle.Text != lastTitleText)
            {
                changesMade = true;
                lastTitleText = textBoxTitle.Text;
            }
            else
            {
                changesMade = false;
            }
        }

        private void textBoxContent_TextChanged(object sender, EventArgs e)
        {
            if (textBoxContent.Text != lastContentText)
            {
                changesMade = true;
                lastTitleText = textBoxTitle.Text;
            }
            else
            {
                changesMade = false;
            }
        }

        private void ViewNotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            // When the user closes the form and changes have been made
            if (changesMade)
            {
                DialogResult result = MessageBox.Show("Changes have not been saved. Do you want to save them?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    buttonSaveChanges_Click(sender, e);
                    changesMade = false;
                }
                else if (result == DialogResult.No)
                {

                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;

                }
            }
        }

        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxNotes.SelectedItem != null)
            {
                string selectedTitle = listBoxNotes.SelectedItem?.ToString() ?? string.Empty;

                lastTitleText = selectedTitle;

                var notes = File.ReadAllLines("notes.csv");
                foreach (var note in notes)
                {

                    var trimmedNote = note.Trim('"');
                    var noteParts = trimmedNote.Split(new[] { "\",\"" }, 3, StringSplitOptions.None);


                    if (noteParts.Length > 1 && noteParts[1] == selectedTitle)
                    {
                        // Handle special characters in the content properly

                        string content = noteParts[2].Replace("\\n", Environment.NewLine);
                        lastContentText = noteParts[2].Replace("\\n", Environment.NewLine);
                        textBoxTitle.Text = noteParts[1];
                        textBoxContent.Text = content;
                        break;
                    }
                }

            }
        }

        private void HubButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveChanges_MouseEnter(object sender, EventArgs e)
        {
            buttonSaveChanges.Location = new Point(buttonSaveChanges.Location.X + 2, buttonSaveChanges.Location.Y - 2);
        }

        private void buttonSaveChanges_MouseLeave(object sender, EventArgs e)
        {
            buttonSaveChanges.Location = new Point(buttonSaveChanges.Location.X - 2, buttonSaveChanges.Location.Y + 2);
        }

        private void buttonDelete_MouseEnter(object sender, EventArgs e)
        {
            buttonDelete.Location = new Point(buttonDelete.Location.X + 2, buttonDelete.Location.Y - 2);
        }

        private void buttonDelete_MouseLeave(object sender, EventArgs e)
        {
            buttonDelete.Location = new Point(buttonDelete.Location.X - 2, buttonDelete.Location.Y + 2);
        }

        private void label1_Click(object sender, EventArgs e)
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
