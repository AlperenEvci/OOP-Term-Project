using System;
using System.Collections.Generic;
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

        string filePath = "userProfiles.csv";
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

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {
            
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
                textBoxŞifre.Text = string.Empty;
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
                        break;
                    }
                }
                
                if (UserProfile.name.StartsWith("*"))
                {
                    UserProfile.statue = "admin";

                    UserProfile.name = UserProfile.name.Replace("*", "");
                    
                }
                else
                {
                    UserProfile.statue = "user";
                }

                if (UserProfile.email == textBoxMail.Text && UserProfile.password == textBoxŞifre.Text)
                {
                    userFound = true;
                }

            if (UserProfile.email == textBoxMail.Text && UserProfile.password != textBoxŞifre.Text)
            {
                string usermail = textBoxMail.Text;
                passwordChanged = true;

                newPassword = GeneratePassword(6);

                string to = textBoxMail.Text;
                string subject = "İzinsiz Giriş!";
                DateTime now = DateTime.Now;

                string body = "Hesabınıza " + now + " tarihinde izinsiz giriş denemesi yapılmıştır!" + Environment.NewLine + "Güvenlik sebebiyle şifreniz değiştirilmiştir. Yeni şifreniz: " + newPassword;

                UserProfile.password = newPassword;

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
                        //smtp.Send(mail);
                    }
                }
            }
            if (!userFound)
            {
                MessageBox.Show("Invalid email or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxMail.Clear();
                textBoxŞifre.Clear();
            }
            if (passwordChanged)
            {
                List<cloneUser> usersClone = new List<cloneUser>();                
                Functions.edit(usersClone, UserProfile.name, UserProfile.surname, UserProfile.phone, UserProfile.address, UserProfile.email, UserProfile.password, UserProfile.picture, UserProfile.statue,UserProfile.salary);

            }
            else
            {
                Hub hub = new Hub();
                this.Hide();
                hub.Show();
            }
            
        }                                                       
         

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordHide.CheckState == CheckState.Checked)
            {
                textBoxŞifre.UseSystemPasswordChar = false;

            }
            else
            {
                textBoxŞifre.UseSystemPasswordChar = true;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                System.Diagnostics.Process.Start("https://www.linkedin.com/in/emir-selengil/");
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/alperen-evci/"); 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/akin-bektas/");
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/onur-dalgic/");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        bool ismoved = false;
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

            if (!ismoved) 
            { 
                this.Size = new Size(this.Size.Width + 75, this.Size.Height);
                pictureBox1.Location = new Point(pictureBox1.Location.X + 75, pictureBox1.Location.Y); 
                exit.Location = new Point(exit.Location.X+75, exit.Location.Y);
                ismoved = true; 
                label3.Visible = true;

            }
        }
        bool ismoved1 = false;
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            if (!ismoved1)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X + 75, pictureBox2.Location.Y);
                ismoved1 = true;
                label4.Visible = true;

            }
        }
        bool ismoved2 = false;
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            if (!ismoved2)
            {
                pictureBox3.Location = new Point(pictureBox3.Location.X + 75, pictureBox3.Location.Y);
                ismoved2 = true;
                label5.Visible = true;

            }
        }

        bool ismoved3 = false;
        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            if (!ismoved3)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X + 75, pictureBox4.Location.Y);
                ismoved3 = true;
                label6.Visible = true;

            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (ismoved) pictureBox1.Location = new Point(pictureBox1.Location.X + 2, pictureBox1.Location.Y - 2);

        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (ismoved) pictureBox1.Location = new Point(pictureBox1.Location.X - 2, pictureBox1.Location.Y + 2);
        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            if (ismoved1) pictureBox2.Location = new Point(pictureBox2.Location.X + 2, pictureBox2.Location.Y - 2);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            if (ismoved1) pictureBox2.Location = new Point(pictureBox2.Location.X - 2, pictureBox2.Location.Y + 2);
        }
        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            if (ismoved2) pictureBox3.Location = new Point(pictureBox3.Location.X + 2, pictureBox3.Location.Y - 2);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            if (ismoved2) pictureBox3.Location = new Point(pictureBox3.Location.X - 2, pictureBox3.Location.Y + 2);
        }
        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            if (ismoved3) pictureBox4.Location = new Point(pictureBox4.Location.X + 2, pictureBox4.Location.Y - 2);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            if (ismoved3) pictureBox4.Location = new Point(pictureBox4.Location.X - 2, pictureBox4.Location.Y + 2);
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
    }
}
