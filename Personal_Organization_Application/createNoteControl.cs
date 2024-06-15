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
    public partial class createNoteControl : UserControl
    {
        public createNoteControl()
        {
            InitializeComponent();
        }

        private void buttonSaveNote_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string content = textBoxContent.Text.Replace(Environment.NewLine, "\\n");

            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(content))
            {
              
                if (!File.Exists("notes.csv"))
                {
                    
                    string note = $"\"{UserProfile.ID}\",\"{title}\",\"{content}\"";
                    File.AppendAllText("notes.csv", note + Environment.NewLine);
                }
                else
                {
                    
                    string[] existingTitles = File.ReadAllLines("notes.csv")
                        .Select(line => line.Split(',')[1].Trim('"'))
                        .ToArray();

                    // Creating the notes that have the same Title as "note1, note2, note3..."
                    if (existingTitles.Contains(title))
                    {
                        int suffix = 1;
                        string newTitle = $"{title}{suffix}";

                        // "note1, note2, note3
                        while (existingTitles.Contains(newTitle))
                        {
                            suffix++;
                            newTitle = $"{title}{suffix}";
                        }

                        // Ask the user if he/she wants to change the title 
                        DialogResult result = MessageBox.Show($"A note with the title '{title}' already exists. Would you like to save it as '{newTitle}'?", "Note Exists", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            
                            string note = $"\"{UserProfile.ID}\",\"{newTitle}\",\"{content}\"";
                            File.AppendAllText("notes.csv", note + Environment.NewLine);
                        }
                        else
                        {
                            
                            MessageBox.Show("Note not saved.");
                            return;
                        }
                    }
                    else
                    {
                        string note = $"\"{UserProfile.ID}\",\"{title}\",\"{content}\"";
                        File.AppendAllText("notes.csv", note + Environment.NewLine);
                    }
                }

                textBoxTitle.Clear();
                textBoxContent.Clear();
                MessageBox.Show("Note added successfully.");
            }
            else
            {
                if (string.IsNullOrEmpty(title))
                {
                    if (string.IsNullOrEmpty(content))
                    {
                        MessageBox.Show("Title and content cannot be empty.");
                    }
                    else
                    {
                        MessageBox.Show("Title cannot be empty.");
                    }

                }
                else if (string.IsNullOrEmpty(content))
                {
                    MessageBox.Show("Content cannot be empty.");
                }
            }
        }

        private void HubButton_Click(object sender, EventArgs e)
        {
            this.Visible = false; 
        }

        private void buttonSaveNote_MouseEnter(object sender, EventArgs e)
        {
            buttonSaveNote.Location = new Point(buttonSaveNote.Location.X + 2, buttonSaveNote.Location.Y - 2);
        }

        private void buttonSaveNote_MouseLeave(object sender, EventArgs e)
        {
            buttonSaveNote.Location = new Point(buttonSaveNote.Location.X - 2, buttonSaveNote.Location.Y + 2);
        }

    }
}

