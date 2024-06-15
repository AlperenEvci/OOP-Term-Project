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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;

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

                if (lines.Count > 1)
                {
                    for (int i = 0; i < lines.Count; i++)
                    {
                        string line = lines[i]; 
                        string[] infos = line.Split(',');

                        string email = infos[4];

                        if (email == txtEmail.Text)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        private bool ControlEmptyCell()
        {
            if (txtName.Text.Trim() == "" || txtName.Text.Trim() == "Name")
            {
                return true;
            }
            if (txtSurname.Text.Trim() == "" || txtSurname.Text.Trim() == "Surname")
            {
                return true;
            }
            if (txtAddress.Text.Trim() == "" || txtAddress.Text.Trim() == "Address")
            {
                return true;
            }
            if (txtPassword.Text.Trim() == "" || txtPassword.Text.Trim() == "Password")
            {
                return true;
            }
            return false;
        }
        private bool controlPhoto()
        {
            string photo = string.Empty;
            photo = Functions.ImageToBase64(pictureBox1.Image);

            if(photo.Length < 30000)
            {
                return true;
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
        private bool controlPhone()
        {
            string filePath = "userProfiles.csv";

            if (File.Exists(filePath))
            {
                List<string> lines = File.ReadAllLines(filePath).ToList();

                if (lines.Count > 1)
                {
                    for (int i = 0; i < lines.Count; i++)
                    {
                        string satir = lines[i];
                        string[] infos = satir.Split(',');

                        string phoneNo = infos[2];

                        if (phoneNo == txtPhoneNo.Text)
                        {
                            return true;
                            
                        }
                    }
                }
            }
            return false;
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
            
            try
            {
                FileStream fileStream = File.Open("userProfiles.csv", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                fileStream.Close();
                List<cloneUser> lines = new List<cloneUser>();
                Functions.getData("userProfiles.csv", lines);

                if (lines.Count == 0)
                  {
                      user.Name = "*" + name;
                      string headers = "Name,Surname,PhoneNumber,Address,Email,Password,Salary,ID,Picture\n";
                      File.WriteAllText(filepath, headers); // Write headers to the file

                      userData = $"{user.Name},{user.Surname},{user.PhoneNumber},{user.Address},{user.Email},{user.Password},0,{Functions.idR},{user.Picture}\n"; // Create user data string
                      
                }
                else
                {
                    userData = $"{user.Name},{user.Surname},{user.PhoneNumber},{user.Address},{user.Email},{user.Password},0,{Functions.idR},{user.Picture}\n"; // Create user data string
                    
                }
                File.AppendAllText(filepath, userData);
                MessageBox.Show("Your informations have been recorded!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred", ex);
            }
            
        }
        private const string ValidChars = "1234567890";

        private static readonly Random random = new Random();
        public static string GenerateVerificationCode(int length)
        {
            char[] password = new char[length];

            for (int i = 0; i < length; i++)
            {
                password[i] = ValidChars[random.Next(ValidChars.Length)];
            }

            return new string(password);
        }
        bool ismoved = true;
        string VerificationCode = string.Empty; 
        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            string usermail = txtEmail.Text;
            string base64String = string.Empty;
            txtVerify.Text = "Verify Code";
            VerificationCode = GenerateVerificationCode(6);

            if (ControlEmptyCell())
            {
                MessageBox.Show("Empty cell.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!controlPhoto())
            {
                MessageBox.Show("The size of the photo is larger than the allowed value.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (controlEmail() || controlPhone())
            {
                if (controlEmail())
                {
                    MessageBox.Show("This email address has been used before.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Clear();
                }
                if (controlPhone())
                {
                    MessageBox.Show("This phone number has been used before.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhoneNo.Clear();
                }                
            }
            else
            {
                if(txtName.Text.Trim() == "" || txtSurname.Text.Trim() == "" || txtPhoneNo.Text.Replace(" ","").Length < 12 || txtAddress.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Please fill all the textboxes.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtPhoneNo.Text.Length < 14)
                    {
                        MessageBox.Show("Your number is missing or incorrect.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPhoneNo.Clear();
                    }
                    else
                    {
                        try
                        {
                            string to = txtEmail.Text;                            
                            string subject2 = "Your Verify Code!";  
                            string body2 = "Verify Code: " + VerificationCode;
                            string Email = "mailAdresiniz";
                            string Password = "şifreniz";
                            string Host = "smtp.office365.com";
                            int Port = 587;


                            using (MailMessage mail = new MailMessage(Email, to, subject2, body2))
                            {
                                using (SmtpClient smtp = new SmtpClient(Host, Port))
                                {
                                    smtp.UseDefaultCredentials = false;
                                    smtp.EnableSsl = true;
                                    smtp.Credentials = new NetworkCredential(Email, Password);
                                    await smtp.SendMailAsync(mail);
                                    if (ismoved)
                                    {
                                        ismoved = false;
                                        this.Size = new Size(401, 583);
                                        buttonRegister.Enabled = false;
                                        pictureBox3.Visible = true;
                                        txtVerify.Visible = true;
                                        buttonVerify.Visible = true;
                                    }
                                    
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error");
                        }
                        
                    }
                }   
            }            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            this.Size = new Size(401, 520);
            ismoved = true;
            buttonRegister.Enabled = true;
            if (!IsLet(txtName.Text))
            {
                MessageBox.Show(txtName.Text + " is not valid key", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Clear();
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            this.Size = new Size(401, 520);
            buttonRegister.Enabled = true;
            ismoved = true;
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

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            string usermail = txtEmail.Text;
            string base64String = string.Empty;
            base64String = Functions.ImageToBase64(pictureBox1.Image);
            string to = txtEmail.Text;
            string subject = "Welcome!";
            string body = "This email confirms that your registration has been successfully completed!";
            string Email = "mailAdresiniz";
            string Password = "şifreniz";
            string Host = "smtp.office365.com";
            int Port = 587;
            if (txtVerify.Text == VerificationCode)
            {
                using (MailMessage mail = new MailMessage(Email, to, subject, body))
                {
                    using (SmtpClient smtp = new SmtpClient(Host, Port))
                    {
                        smtp.UseDefaultCredentials = false;
                        smtp.EnableSsl = true;
                        smtp.Credentials = new NetworkCredential(Email, Password);
                        smtp.SendMailAsync(mail);

                        record(txtName.Text, txtSurname.Text, txtPhoneNo.Text, txtAddress.Text, txtEmail.Text, txtPassword.Text, base64String, "userProfiles.csv");
                        txtName.Clear();
                        txtSurname.Clear();
                        txtPhoneNo.Clear();
                        txtAddress.Clear();
                        txtEmail.Clear();
                        txtPassword.Clear();
                    }
                }
                Login form = new Login();
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Verify Code is not true!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X + 2, pictureBox2.Location.Y - 2);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X - 2, pictureBox2.Location.Y + 2);
        }
    
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            this.Size = new Size(401, 520);
            ismoved = true;
            buttonRegister.Enabled = true;
            int score = CalculatePasswordStrength(txtPassword.Text);

            if(score == 0)
            {
                passwordStrength.BackColor = Color.White;
                label2.Text = "";
            }
            if(score == 1)
            {
                passwordStrength.BackColor = Color.Red;
                passwordStrength.Size = new Size(46, 20);
                label2.Text = "Weak Password!";
            }            
            else if (score == 2)
            {
                passwordStrength.BackColor = Color.Orange;
                passwordStrength.Size = new Size(92, 20);
                label2.Text = "Normal Password!";
            }
            else if (score == 3)
            {
                passwordStrength.BackColor = Color.Gold;
                passwordStrength.Size = new Size(138, 20);
                label2.Text = "Strong Password!";
            }
            else if (score == 4)
            {
                passwordStrength.BackColor = Color.Green;
                passwordStrength.Size = new Size(186,20);
                label2.Text = "Very Strong Password!";
            }
            panel2.Visible = true;
            passwordStrength.Visible = true;
        }
        private int CalculatePasswordStrength(string password)
        {
            int score = 0;
            
            if (System.Text.RegularExpressions.Regex.IsMatch(password, @"[a-z]"))
                score++; // Küçük harf kontrolü

            if (System.Text.RegularExpressions.Regex.IsMatch(password, @"[A-Z]"))
                score++; // Büyük harf kontrolü

            if (System.Text.RegularExpressions.Regex.IsMatch(password, @"[0-9]"))
                score++; // Rakam kontrolü

            if (System.Text.RegularExpressions.Regex.IsMatch(password, @"[!@#$%^&*(),.?""\\:{}|<>]"))
                score++; // Özel karakter kontrolü

            return score;
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.Clear();
        }

        private void txtSurname_Click(object sender, EventArgs e)
        {
            txtSurname.Clear();
        }

        private void txtPhoneNo_Click(object sender, EventArgs e)
        {
            txtPhoneNo.Clear();
        }

        private void txtAddress_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }
        
        private void txtVerify_Click(object sender, EventArgs e)
        {
            txtVerify.Clear();
        }

        private void txtPhoneNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.Size = new Size(401, 520);
            buttonRegister.Enabled = true;
        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {
            this.Size = new Size(401, 520);
            ismoved = true;
            buttonRegister.Enabled = true;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            this.Size = new Size(401, 520);
            ismoved = true;
            buttonRegister.Enabled = true;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            this.Size = new Size(401, 520);
            ismoved = true;
            buttonRegister.Enabled = true;
        }

        private void txtPhoneNo_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {
            ismoved = true;
            buttonRegister.Enabled = true;
        }
    }
}
