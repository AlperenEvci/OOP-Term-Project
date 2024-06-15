using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hub
{
    public partial class managementcontrolform : UserControl
    {
        public managementcontrolform()
        {
            InitializeComponent();
        }
        string phone = string.Empty;
        private bool ValidateEmail(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private bool ValidatePhone()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    phone = row.Cells[2].Value.ToString().Replace(" ", "");
                    phone = phone.Replace("(", "").Replace(")", "");

                    if (phone.Length != 10)
                    {
                        MessageBox.Show("Phone number must be 10 digits long.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    foreach (char c in phone)
                    {
                        if (!char.IsDigit(c))
                        {
                            MessageBox.Show("Invalid character, you must enter digits", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }

            return true;
        }
        private string PhoneTransform(string phoneO)
        {
            string newPhone = phoneO.Replace(" ", "");
            newPhone = newPhone.Replace("(", "").Replace(")", "");

            return newPhone;
        }
        private bool TextBoxValidation()
        {
            bool isValid = true;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell is DataGridViewTextBoxCell)
                        {
                            string cellValue = cell.Value?.ToString().Trim();
                            if (string.IsNullOrEmpty(cellValue))
                            {
                                isValid = false;
                                MessageBox.Show("Empty cell!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                            else if (cell.OwningColumn.Name == "İsim" || cell.OwningColumn.Name == "Soyisim")
                            {
                                if (ContainsNumbers(cellValue))
                                {
                                    isValid = false;
                                    MessageBox.Show("Name and surname cannot contain numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            return isValid;
        }

        private bool ContainsNumbers(string text)
        {
            return text.Any(char.IsDigit);
        }

        public void management_Load()
        {
            StreamReader reader = new StreamReader("userProfiles.csv");

            List<string[]> veriler = new List<string[]>();
            while (!reader.EndOfStream)
            {
                string satir = reader.ReadLine();
                string[] veri = satir.Split(',');

                string isim = veri[0];
                string statü = "";/*isim.StartsWith("*") ? "admin" : "user";*/
                if (isim.StartsWith("*"))
                {
                    statü = "admin";
                    veri[0] = isim.Replace("*", "");
                }
                else if (isim.StartsWith("!"))
                {
                    statü = "part-time user";
                    veri[0] = isim.Replace("!", "");
                }
                else
                    statü = "user";
                veriler.Add(new string[] { veri[0], veri[1], veri[2], veri[3], veri[4], veri[5], veri[6], statü });
            }

            reader.Close();

            dataGridView1.Rows.Clear();
            for (int i = 1; i < veriler.Count; i++)
            {
                string[] veri = veriler[i];
                dataGridView1.Rows.Add(veri);
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string rowEmail = row.Cells[4].Value.ToString();

                if (rowEmail == UserProfile.email)
                {
                    row.Cells[6].ReadOnly = true;
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) // Save button
        {
            if (!TextBoxValidation())
            {
                return;
            }
            if (!ValidatePhone())
            {
                return;
            }

            List<string[]> txtVeriler = new List<string[]>();
            using (StreamReader reader = new StreamReader("userProfiles.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string satir = reader.ReadLine();
                    string[] veri = satir.Split(',');
                    if (veri.Length >= 7)
                    {
                        txtVeriler.Add(veri);
                    }
                }
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string[] rowData = new string[row.Cells.Count];
                    string[] user = new string[8];

                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        rowData[i] = row.Cells[i].Value.ToString().Trim();
                    }

                    foreach (var item in txtVeriler)
                    {
                        if (item[4] == rowData[4])
                        {
                            user = item;
                            break;
                        }
                    }

                    string email = rowData[4];
                    string yeniStatu = rowData[7];

                    string flag = PhoneTransform(rowData[2].ToString());

                    if (flag.Length < 14)
                    {
                        rowData[2] = "(" + flag[0] + flag[1] + flag[2] + ")" + flag[3] + flag[4] + flag[5] + " " + flag[6] + flag[7] + " " + flag[8] + flag[9];
                    }

                    if (!ValidateEmail(email))
                    {
                        MessageBox.Show($"Invalid Email: {email}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (yeniStatu == "admin")
                    {
                        rowData[0] = "*" + rowData[0];
                    }


                    if (yeniStatu == "part-time user")
                    {
                        rowData[0] = "!" + rowData[0];
                    }

                    foreach (string[] txtVeri in txtVeriler)
                    {
                        if (txtVeri[4] == email)
                        {
                            txtVeri[0] = rowData[0];

                            for (int i = 1; i < rowData.Length - 1; i++)
                            {
                                txtVeri[i] = rowData[i];
                            }
                            break;
                        }
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter("userProfiles.csv"))
            {
                foreach (string[] veri in txtVeriler)
                {
                    string line = string.Join(",", veri);
                    writer.WriteLine(line);
                }
            }

            MessageBox.Show("Veriler başarıyla güncellendi.");

            this.Visible = false;
        }

        private void HubButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 2, pictureBox1.Location.Y - 2);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - 2, pictureBox1.Location.Y + 2);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<string[]> txtVeriler = new List<string[]>();

            using (StreamReader reader = new StreamReader("userProfiles.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string satir = reader.ReadLine();
                    string[] veri = satir.Split(',');
                    if (veri.Length >= 7)
                    {
                        txtVeriler.Add(veri);
                    }
                }
            }

            int rowCount = dataGridView1.RowCount;
            bool flag = false;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    flag = false;
                    if (row.Index < rowCount - 1)
                    {
                        flag = true;
                        string email = row.Cells[4].Value.ToString();
                        string status = row.Cells[6].Value.ToString();

                        if (status == "admin")
                        {
                            MessageBox.Show("You can't remove admin's informations!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        int index = txtVeriler.FindIndex(x => x[4] == email);
                        if (index != -1)
                        {
                            dataGridView1.Rows.RemoveAt(row.Index);
                            txtVeriler.RemoveAt(index);
                        }
                    }
                }

                using (StreamWriter writer = new StreamWriter("userProfiles.csv"))
                {
                    foreach (string[] veri in txtVeriler)
                    {
                        string line = string.Join(",", veri);
                        writer.WriteLine(line);
                    }
                }
                if (flag)
                {
                    MessageBox.Show("Selected rows have been successfully deleted.");
                }
            }
            else
            {
                MessageBox.Show("No row selected for deletion.");
            }
        }
    }
}
