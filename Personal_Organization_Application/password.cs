using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Threading;

namespace Hub
{
    public partial class password : Form
    {
        public password()
        {
            InitializeComponent();
        }
        List<cloneUser> cloneUsers = new List<cloneUser>();
        private const string ValidChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890$&*_+-=<>?";

        private static readonly Random random = new Random();
        public static string GeneratePassword(int length)
        {
            char[] password = new char[length];

            for (int i = 0; i < length; i++)
            {
                password[i] = ValidChars[random.Next(ValidChars.Length)];
            }

            return new string(password);
        }

        private void buttonGiriş_Click(object sender, EventArgs e)
        {
            
            string filePath = "userProfiles.csv";
            string newPassword = string.Empty;
            bool passwordChanged = false;
            bool userFound = false;
            FileInfo fileInfo1 = new FileInfo(filePath);

            if (!File.Exists(filePath) || fileInfo1.Length == 0)
            {
                MessageBox.Show("There is currently no user account.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxMail.Text = string.Empty;                
                return;
            }

            Functions.getData(filePath, cloneUsers);

            foreach (cloneUser user in cloneUsers)
            {
                if (user.Email == textBoxMail.Text)
                {
                    UserProfile.name = user.Name;
                    UserProfile.surname = user.Surname;
                    UserProfile.phone = user.PhoneNumber;
                    UserProfile.address = user.Address;
                    UserProfile.email = user.Email;
                    UserProfile.password = user.Password;
                    UserProfile.ID = user.ID;
                    UserProfile.picture = user.Picture;

                    if (UserProfile.name.StartsWith("*"))
                    {
                        UserProfile.statue = "admin";

                        UserProfile.name = UserProfile.name.Replace("*", "");
                        
                    }
                    else if (UserProfile.name.StartsWith("!"))
                    {
                        UserProfile.statue = "part-time user";

                        UserProfile.name = UserProfile.name.Replace("!", "");
                    }
                    else
                    {
                        UserProfile.statue = "user";
                    }
                    break;
                }
            }

            if (UserProfile.email == textBoxMail.Text) userFound = true;

            if (userFound)
            {
                buttonForgot.Enabled = false;
                string usermail = textBoxMail.Text;
                passwordChanged = true;
                newPassword = GeneratePassword(6);

                string to = textBoxMail.Text;
                string subject = "New Password";
                string body = "New Password: " + newPassword;

                UserProfile.password = newPassword;

                string Email = "mailAdresiniz";
                string Password = "şifreniz";
                string Host = "smtp.office365.com";
                int Port = 587;

                using (MailMessage mail = new MailMessage(Email, to, subject, body))
                {
                    using (SmtpClient smtp = new SmtpClient(Host, Port))
                    {
                        smtp.UseDefaultCredentials = false;
                        smtp.EnableSsl = true;
                        smtp.Credentials = new NetworkCredential(Email, Password);
                        for (int i = 0; i <= 100; i++)
                        {
                            progressBar1.Value = i;
                            Thread.Sleep(50);
                        }
                        smtp.Send(mail);
                        MessageBox.Show("Your new password has been sent to your email address!", "Success");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxMail.Clear();
                
            }
            if (passwordChanged)
            {
                List<cloneUser> usersClone = new List<cloneUser>();
                Functions.edit(usersClone, UserProfile.name, UserProfile.surname, UserProfile.phone, UserProfile.address, UserProfile.email, newPassword, UserProfile.picture, UserProfile.statue,UserProfile.salary);
                Login form = new Login();
                form.Show();
                this.Close();
            }
        }

        private void HubButton_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Close();
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
