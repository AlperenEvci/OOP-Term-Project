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

namespace NoteBook
{
    public partial class CreateNoteForm : Form
    {
        public CreateNoteForm()
        {
            InitializeComponent();
        }

        private void buttonSaveNote_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string content = textBoxContent.Text.Replace(Environment.NewLine, "\\n");

            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(content))
            {
                // Dosyanın varlığını kontrol et
                if (!File.Exists("notes.csv"))
                {
                    // Dosya yoksa, dosyayı oluştur ve notu ekleyerek dosyayı yaz
                    string note = $"\"{title}\",\"{content}\"";
                    File.WriteAllText("notes.csv", note + Environment.NewLine);
                }
                else
                {
                    // Mevcut başlıkları kontrol et
                    string[] existingTitles = File.ReadAllLines("notes.csv")
                        .Select(line => line.Split(',')[0].Trim('"'))
                        .ToArray();

                    // Aynı başlığın daha önce kullanılıp kullanılmadığını kontrol et
                    if (existingTitles.Contains(title))
                    {
                        int suffix = 1;
                        string newTitle = $"{title} {suffix}";

                        // Başlığın sonuna bir sonek ekleyerek farklı bir başlık oluştur
                        while (existingTitles.Contains(newTitle))
                        {
                            suffix++;
                            newTitle = $"{title} {suffix}";
                        }

                        // Kullanıcıya yeni başlığı kaydetmek isteyip istemediğini sor
                        DialogResult result = MessageBox.Show($"A note with the title '{title}' already exists. Would you like to save it as '{newTitle}'?", "Note Exists", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            // Yeni başlıkla notu dosyaya ekleyerek dosyayı güncelle
                            string note = $"\"{newTitle}\",\"{content}\"";
                            File.AppendAllText("notes.csv", note + Environment.NewLine);
                        }
                        else
                        {
                            // Kullanıcı hayır derse kaydetme işlemi yapılmaz
                            MessageBox.Show("Note not saved.");
                            return;
                        }
                    }
                    else
                    {
                        // Aynı başlık yoksa, yeni notu dosyaya ekleyerek dosyayı güncelle
                        string note = $"\"{title}\",\"{content}\"";
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
            this.Close();   
        }
    }
}
