using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hub
{
    public partial class Login : Form
    {

        List<cloneUser> cloneUsers = new List<cloneUser>();

        public Login()
        {
            InitializeComponent();
        }
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

        private void labelUnuttum_Click(object sender, EventArgs e)
        {
            password pass = new password();
            pass.Show();
            this.Hide();
        }

        private void buttonKayıt_Click(object sender, EventArgs e)
        {
            Register kayıt = new Register();
            kayıt.Show();
            this.Hide();
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
                textBoxPassword.Text = string.Empty;
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
                    UserProfile.picture = user.Picture;
                    UserProfile.ID = user.ID;

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

            

            if (UserProfile.email == textBoxMail.Text && UserProfile.password == textBoxPassword.Text)
            {
                userFound = true;
            }

            if (UserProfile.email == textBoxMail.Text && UserProfile.password != textBoxPassword.Text)
            {                
                string to = textBoxMail.Text;
                string subject = "Unauthorized Entry!";
                DateTime now = DateTime.Now;

                string body = "There was an unauthorized login attempt to your account on " + now + " !";
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
                        smtp.Send(mail);
                    }
                }
            }

            if (!userFound)
            {
                MessageBox.Show("Invalid email or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxMail.Clear();
                textBoxPassword.Clear();
                File.WriteAllText("remember.txt", string.Empty);
            }
            else
            {
                if (chckRemember.Checked)
                {
                    string textToWrite = textBoxMail.Text + "\n" + textBoxPassword.Text;
                    File.WriteAllText("remember.txt", textToWrite);
                }
                else
                {
                    File.WriteAllText("remember.txt", string.Empty);
                }
                Hub hub = new Hub();
                hub.Show();
                this.Hide();
            }

            
        }

        private void Login_Load(object sender, EventArgs e)
        {

            if (File.Exists("remember.txt"))
            {
                string[] lines = File.ReadAllLines("remember.txt");

                if (lines.Length > 0)
                {
                    textBoxMail.Text = lines.Length > 0 ? lines[0] : string.Empty;
                    textBoxPassword.Text = lines.Length > 1 ? lines[1] : string.Empty;
                }
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.Location = new Point(exit.Location.X + 2, exit.Location.Y - 2);
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.Location = new Point(exit.Location.X - 2, exit.Location.Y + 2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        bool passwordVisible = false;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //changing image of picturebox
            if (passwordVisible)
            {
                passwordVisible = false;
                textBoxPassword.UseSystemPasswordChar = false;
                pictureBox4.Image = Properties.Resources.view;
            }
            else
            {
                passwordVisible = true;
                textBoxPassword.UseSystemPasswordChar = true;
                pictureBox4.Image = Properties.Resources.eye;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://linktr.ee/akare21?utm_source=linktree_profile_share&ltsid=792c0307-8897-40ec-b992-26b0267e005c");
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Location = new Point(pictureBox6.Location.X + 2, pictureBox6.Location.Y - 2);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Location = new Point(pictureBox6.Location.X - 2, pictureBox6.Location.Y + 2);
        }

        private void buttonLogin_MouseEnter(object sender, EventArgs e)
        {
            buttonLogin.Location = new Point(buttonLogin.Location.X + 2, buttonLogin.Location.Y - 2);
        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.Location = new Point(buttonLogin.Location.X - 2, buttonLogin.Location.Y + 2);
        }

        private void buttonRegister_MouseEnter(object sender, EventArgs e)
        {
            buttonRegister.Location = new Point(buttonRegister.Location.X + 2, buttonRegister.Location.Y - 2);
        }

        private void buttonRegister_MouseLeave(object sender, EventArgs e)
        {
            buttonRegister.Location = new Point(buttonRegister.Location.X - 2, buttonRegister.Location.Y + 2);
        }

    }
}
