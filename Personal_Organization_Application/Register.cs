using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;
using System.Net;

namespace Hub
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private bool controlEmail()
        {
            string filePath = "userProfiles.csv";

            if (File.Exists(filePath))
            {
                List<string> lines = File.ReadAllLines(filePath).ToList();

                if (lines.Count != 0)
                {
                    for (int i = 0; i < lines.Count; i++)
                    {
                        string satir = lines[i];
                        string[] infos = satir.Split(',');

                        string email = infos[4];

                        if (email == txtEmail.Text)
                        {
                            return true;
                            break;
                        }
                    }
                }
            }
            return false;
        }
        private bool controlPhone()
        {
            string filePath = "userProfiles.csv";

            if (File.Exists(filePath))
            {
                List<string> lines = File.ReadAllLines(filePath).ToList();

                if (lines.Count != 0)
                {
                    for (int i = 0; i < lines.Count; i++)
                    {
                        string satir = lines[i];
                        string[] infos = satir.Split(',');

                        string phoneNo = infos[2];

                        if (phoneNo == txtPhoneNo.Text)
                        {
                            return true;
                            break;
                        }
                    }
                }
            }
            return false;
        }
        private bool controlPassword()
        {
            string filePath = "userProfiles.csv";

            if (File.Exists(filePath))
            {
                List<string> lines = File.ReadAllLines(filePath).ToList();

                if (lines.Count != 0)
                {
                    for (int i = 0; i < lines.Count; i++)
                    {
                        string satir = lines[i];
                        string[] infos = satir.Split(',');

                        string password = infos[5];

                        if (password == txtPassword.Text)
                        {
                            return true;
                            break;
                        }
                    }
                }
            }
            return false;
        }

        private bool IsLet(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }


        public void record(string name, string surname, string phoneNo,string address, string email, string password, string photo,string filepath) 
        {
            cloneUser user = new cloneUser();
            user.Name = name;
            user.Surname = surname;
            user.PhoneNumber = phoneNo;
            user.Address = address; 
            user.Email = email; 
            user.Password = password;
            user.Picture = photo;
            
            string userData = string.Empty;
            int satirSayisi = 0;

            

            try
            {
                FileStream fileStream = File.Open("userProfiles.csv", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                fileStream.Close();
                long fileSize = new FileInfo(filepath).Length;

                using (StreamReader sr = new StreamReader("userProfiles.csv"))
                {
                    while (sr.ReadLine() != null)
                    {
                        satirSayisi++;
                    }
                }

                if (fileSize == 0)
                  {
                      user.Name = "*" + name;
                      string headers = "Name,Surname,PhoneNumber,Address,Email,Password,Salary,ID,Picture\n";
                      File.WriteAllText(filepath, headers); // Write headers to the file

                      userData = $"{user.Name},{user.Surname},{user.PhoneNumber},{user.Address},{user.Email},{user.Password},0,1,{user.Picture}\n"; // Create user data string
                      
                  }
                  else
                  {
                      userData = $"{user.Name},{user.Surname},{user.PhoneNumber},{user.Address},{user.Email},{user.Password},0,{satirSayisi},{user.Picture}\n"; // Create user data string
                      
                  }
                  File.AppendAllText(filepath, userData);
                  MessageBox.Show("Bilgileriniz kayıt edildi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Bir hata oluştu", ex);
            }
            
        }

        private async void buttonKayıt_Click(object sender, EventArgs e)
        {
            string usermail = txtEmail.Text;
            string base64String = string.Empty;

            if (controlEmail() || controlPhone() || controlPassword())
            {
                if (controlEmail())
                {
                    MessageBox.Show("Bu mail adresi daha önce girilmiştir", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Clear();
                }
                if (controlPhone())
                {
                    MessageBox.Show("Bu telefon numarası daha önce girilmiştir", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhoneNo.Clear();
                }
                if (controlPassword())
                {
                    MessageBox.Show("Bu şifre daha önce girilmiştir", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                }                
            }
            else
            {
                if(txtName.Text.Trim() == "" || txtSurname.Text.Trim() == "" || txtPhoneNo.Text.Trim() == "" || txtAddress.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Herhangi bir bilgi eksik bırakılmamalı.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtPhoneNo.Text.Length < 14)
                    {
                        MessageBox.Show("Numaranız eksik veya yanlış.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPhoneNo.Clear();
                    }
                    else
                    {
                        try
                        {
                            if (pictureBox1.Image != null)
                            {
                                base64String = Functions.ImageToBase64(pictureBox1.Image);

                                using (StreamWriter sw = new StreamWriter("images.csv", true))
                                {
                                    sw.WriteLine(base64String);
                                }
                            }

                            string to = txtEmail.Text;
                            string subject = "Hoşgeldiniz!";
                            string body = "Bu mail kayıdınızın başarılı bir şekilde tamamlandığını belirtmektedir!";

                            string Email = "AkarE1521@outlook.com";
                            string Password = "AkarE2021";
                            string Host = "smtp.office365.com";
                            int Port = 587;

                            using (MailMessage mail = new MailMessage(Email, to, subject, body))
                            {
                                using (SmtpClient smtp = new SmtpClient(Host, Port))
                                {
                                    smtp.UseDefaultCredentials = false;
                                    smtp.EnableSsl = true;
                                    smtp.Credentials = new NetworkCredential(Email, Password);

                                    //await smtp.SendMailAsync(mail);

                                    record(txtName.Text, txtSurname.Text, txtPhoneNo.Text, txtAddress.Text, txtEmail.Text, txtPassword.Text, base64String, "userProfiles.csv");
                                    txtName.Clear();
                                    txtSurname.Clear();
                                    txtPhoneNo.Clear();
                                    txtAddress.Clear();
                                    txtEmail.Clear();
                                    txtPassword.Clear();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata: " + ex.Message, "Hata");
                        }
                        Login form = new Login();
                        form.Show();
                        this.Close();
                    }
                }   
            }            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!IsLet(txtName.Text))
            {
                MessageBox.Show(txtName.Text + " is not valid key", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Clear();
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            if (!IsLet(txtSurname.Text))
            {
                MessageBox.Show(txtSurname.Text + " is not valid key", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Clear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private void HubButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
