using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Hub
{
    public partial class viewNotesControl : UserControl
    {
        // Indicates whether changes have been made
        private bool changesMade = false;
        private string lastTitleText = "";
        private string lastContentText = "";
        public viewNotesControl()
        {
            InitializeComponent();
        }

        public void ViewNotesForm_Load()
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
                            listBoxNotes.Items.Add(title);
                        }
                    }
                }
                listBoxNotes.SelectedIndex = -1;
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
                        if (noteParts.Length > 1  && noteParts[0].Trim('"') == UserProfile.ID.ToString())
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

        private void SaveChanges()
        {
            string selectedTitle = textBoxTitle.Text;
            string updatedContent = textBoxContent.Text.Replace(Environment.NewLine, "\\n");
            string oldTitle = listBoxNotes.SelectedItem?.ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(selectedTitle) || string.IsNullOrEmpty(updatedContent))
            {
                MessageBox.Show("Title or content cannot be empty.");
                return;
            }

            if (listBoxNotes.SelectedIndex != -1)
            {
                string[] notes = File.ReadAllLines("notes.csv");
                List<string> updatedNotes = new List<string>();

                foreach (var note in notes)
                {
                    var noteParts = note.Trim('"').Split(new[] { "\",\"" }, 3, StringSplitOptions.None);

                    if (noteParts.Length > 1)
                    {
                        string noteID = noteParts[0].Trim('"');
                        string noteTitle = noteParts[1];

                        if (noteTitle == oldTitle && noteID == UserProfile.ID.ToString())
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
                    if (noteParts.Length > 1 && noteParts[0].Trim('"') == UserProfile.ID.ToString())
                    {
                        listBoxNotes.Items.Add(noteParts[1]);
                    }
                }
                listBoxNotes.SelectedIndex = selectedIndex;

                changesMade = false;
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
            SaveChanges();
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


        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change the screen
            if (listBoxNotes.SelectedItem != null)
            {
                string selectedTitle = listBoxNotes.SelectedItem?.ToString() ?? string.Empty;

                lastTitleText = selectedTitle;

                var notes = File.ReadAllLines("notes.csv");
                foreach (var note in notes)
                {

                    var trimmedNote = note.Trim('"');
                    var noteParts = trimmedNote.Split(new[] { "\",\"" }, 3, StringSplitOptions.None);


                    if (noteParts.Length > 2 && noteParts[1] == selectedTitle)
                    {
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
            this.Visible = false;
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

        private void viewNotesControl_VisibleChanged(object sender, EventArgs e)
        {


            if (changesMade == true)
            {
                // Check if any note is selected
                if (listBoxNotes.SelectedItem != null)
                {
                    DialogResult result = MessageBox.Show("Changes have not been saved. Do you want to save them?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        SaveChanges();
                    }
                    else if (result == DialogResult.No)
                    {

                    }
                }
            }

            changesMade = false;
            textBoxTitle.Text = "";
            textBoxContent.Text = "";
            listBoxNotes.SelectedIndex = -1;
        }
    }
}
