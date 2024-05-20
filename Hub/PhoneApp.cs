using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Net.Mail;
using Hub;
using PI;

namespace PhoneAppV2
{
    public partial class PhoneApp : Form
    {
        List<Contacts> ContactList = new List<Contacts>();
        //I want a unique id for each contact
        static int ids = 0;

        public PhoneApp()
        {
            InitializeComponent();
            
        }
        
        private bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void SaveDataToCsv(string filePath,List<Contacts> list)
        {
            //clearin csv file
            File.WriteAllText(filePath, string.Empty);
            //writing the headers
            string headers = "Name,Surname,PhoneNumber,Address,Email,Description,ID\n";
            File.WriteAllText(filePath, headers);
            for(int i = 0; i < list.Count; i++)
            {
                Contacts person = list[i];
                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        // Verileri virgülle ayrılmış bir satır olarak dosyaya yaz
                        writer.WriteLine($"{person.name},{person.surname},{person.phone},{person.address},{person.email},{person.description},{person.id}");
                    }
                }
                catch (Exception ex)
                {
                    // Hata yönetimi burada yapılabilir
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }    
        }

        private void getData(string filePath)
        {
            DataTable dt = new DataTable();
            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length > 0)
            {
                // İlk satırı başlık olarak kullan
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                // Verileri satır satır oku
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Contacts contact = new Contacts
                    {
                        name = row["Name"].ToString(),
                        surname = row["Surname"].ToString(),
                        phone = row["PhoneNumber"].ToString(),
                        email = row["Email"].ToString(),
                        address = row["Address"].ToString(),
                        description = row["Description"].ToString(),
                        id = Convert.ToInt32(row["ID"]),
                    };
                    ids = contact.id + 1;
                    ContactList.Add(contact);
                }
            }

        }

        private void PhoneApp_Load(object sender, EventArgs e)
        {
            //check if the file exists 
            string filePath = "phonebook.csv";
            if (!File.Exists(filePath))
            {
                //create the file
                File.Create(filePath).Close();
                string headers = "Name,Surname,PhoneNumber,Address,Email,Description,ID\n";
                File.WriteAllText("phonebook.csv", headers);
            }
            
            //if file is empty write the headers
            if (new FileInfo("phonebook.csv").Length == 0)
            {
                string headers = "Name,Surname,PhoneNumber,Address,Email,Description,ID\n";
                File.WriteAllText("phonebook.csv", headers);
            }
            //checking if the file is first line is headers 
            //if its not write the headers to first line
            else
            {
                string firstLine = File.ReadLines("phonebook.csv").First();
                if (firstLine != "Name,Surname,PhoneNumber,Address,Email,Description,ID")
                {
                    string headers = "Name,Surname,PhoneNumber,Address,Email,Description,ID\n";
                    File.WriteAllText("phonebook.csv", headers);
                }
            }
            getData(filePath);
            foreach (Contacts contact in ContactList)
            {
                //adding ContactList to the list
                ListViewItem item = new ListViewItem(contact.name);
                item.SubItems.Add(contact.surname);
                item.SubItems.Add(contact.phone);
                item.SubItems.Add(contact.email);
                item.SubItems.Add(contact.address);
                item.SubItems.Add(contact.description);
                item.SubItems.Add(contact.id.ToString());
                contactPreview.Items.Add(item);
            }
            contactPreview.ContextMenuStrip = options;
        }

        private void contactAdder_Click(object sender, EventArgs e)
        {
            TabMenu.SelectedTab = TabMenu.TabPages[1];
        }

        private void editRecorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //checking if the contactlist is empty
            if (ContactList.Count == 0)
            {
                MessageBox.Show("No contacts to edit");
                return;
            }
            //checking if the contact is selected
            if (contactPreview.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a contact to edit");
                return;
            }

            TabMenu.SelectedTab = TabMenu.TabPages[2];
            //getting the selected item
            ListViewItem item = contactPreview.SelectedItems[0];
            NameTxt.Text = item.SubItems[0].Text;
            SurnameTxt.Text = item.SubItems[1].Text;
            PhoneNumberTxt.Text = item.SubItems[2].Text;
            EmailTxt.Text = item.SubItems[3].Text;
            AddressTxt.Text = item.SubItems[4].Text;
            DescriptionTxt.Text = item.SubItems[5].Text;
        }

        private void AddBackButton_Click(object sender, EventArgs e)
        {
            ContactList.Clear();
            contactPreview.Items.Clear();
            PhoneApp_Load(sender, e);
            TabMenu.SelectedTab = TabMenu.TabPages[0];

            //clearing all the textboxes
            AddName.Text = "";
            AddSurname.Text = "";
            AddPhone.Text = "";
            AddEmail.Text = "";
            AddAddress.Text = "";
            AddDescription.Text = "";

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ContactList.Clear();
            contactPreview.Items.Clear();
            PhoneApp_Load(sender, e);
            TabMenu.SelectedTab = TabMenu.TabPages[0];
            //clearing all the textboxes
            NameTxt.Text = "";
            SurnameTxt.Text = "";
            PhoneNumberTxt.Text = "";
            EmailTxt.Text = "";
            AddressTxt.Text = "";
            DescriptionTxt.Text = "";
               
        }

        private void AddSaveButton_Click(object sender, EventArgs e)
        {
            //adding person to list
            //checking if the email is valid and all of textboxes are filled
            if (AddName.Text == "" || AddSurname.Text == "" || AddPhone.Text == "" || AddEmail.Text == "" || AddAddress.Text == "" || AddDescription.Text == "")
            {
                MessageBox.Show("Please fill all the textboxes");
                return;
            }
            if (!Functions.IsValidEmail(AddEmail.Text))
            {
                MessageBox.Show("Invalid Email");
                return;
            }
            Contacts person = new Contacts
            {
                name = AddName.Text,
                surname = AddSurname.Text,
                phone = AddPhone.Text,
                email = AddEmail.Text,
                address = AddAddress.Text,
                description = AddDescription.Text,
                id = ids,
            };
            ids++;
            ContactList.Add(person);
            SaveDataToCsv("phonebook.csv", ContactList);
            ContactList.Clear();
            contactPreview.Items.Clear();
            PhoneApp_Load(sender, e);
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //checking if the contactlist is empty
            if (ContactList.Count == 0)
            {
                MessageBox.Show("No contacts to edit");
                return;
            }
            //checking if the contact is selected
            if (contactPreview.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a contact to edit");
                return;
            }
            //deleting selected item in the list
            for(int i = 0; i < ContactList.Count; i++)
            {
                if (ContactList[i].id == Convert.ToInt32(contactPreview.SelectedItems[0].SubItems[6].Text))
                {
                    ContactList.RemoveAt(i);
                    break;
                }
            }
            contactPreview.Items.Clear();
            SaveDataToCsv("phonebook.csv", ContactList);
            ContactList.Clear();
            PhoneApp_Load(sender, e);



        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //change the information of the selected contact
            for(int i = 0; i < ContactList.Count ; i++)
            {
                if (ContactList[i].id == Convert.ToInt32(contactPreview.SelectedItems[0].SubItems[6].Text))
                {
                    ContactList[i].name = NameTxt.Text;
                    ContactList[i].surname = SurnameTxt.Text;
                    ContactList[i].phone = PhoneNumberTxt.Text;
                    if (!IsValidEmail(EmailTxt.Text))
                    {
                        MessageBox.Show("Invalid Email");
                        return;
                    }
                    else
                    {
                        ContactList[i].email = EmailTxt.Text;
                    }
                    ContactList[i].address = AddressTxt.Text;
                    ContactList[i].description = DescriptionTxt.Text;
                    break;
                }
            }
            contactPreview.Items.Clear();
            SaveDataToCsv("phonebook.csv", ContactList);
            ContactList.Clear();
            PhoneApp_Load(sender, e);


        }

        private void HubButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Hub.Hub hub = new Hub.Hub();
            hub.Show();

        }
    }
}
