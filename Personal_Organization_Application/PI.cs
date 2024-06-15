using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Hub.Hub;

namespace Hub
{
    public partial class PI : UserControl
    {
        private cloneUser userProfile = new cloneUser();
        private Stack<cloneUser> undoStack;
        private Stack<cloneUser> redoStack;
        List<cloneUser> usersList = new List<cloneUser>();

        public PI()
        {
            InitializeComponent();

            undoStack = new Stack<cloneUser>();
            redoStack = new Stack<cloneUser>();
            userProfile.Name = UserProfile.name;
            userProfile.Surname = UserProfile.surname;
            userProfile.PhoneNumber = UserProfile.phone;
            userProfile.Email = UserProfile.email;
            userProfile.Address = UserProfile.address;
            userProfile.Password = UserProfile.password;
            userProfile.Picture = UserProfile.picture;

            try
            {
                Image image = Functions.Base64ToImage(UserProfile.picture);
                pictureBox1.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }

            UpdateUI();
        }
        private bool controlPhoto()
        {
            string photo = string.Empty;
            photo = Functions.ImageToBase64(pictureBox1.Image);

            if (photo.Length < 30000)
            {
                return true;
            }

            return false;
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (!controlPhoto())
            {
                MessageBox.Show("The size of the photo is larger than the allowed value.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Functions.IsValidEmail(email))
            {
                // Geri alma/yineleme için mevcut durumu saklayın
                undoStack.Push(userProfile.Clone() as cloneUser);
                redoStack.Clear();

                string base64Image = Functions.ImageToBase64(pictureBox1.Image);

                UserProfile.picture = base64Image;

                if (txtName.Text != "" && txtSurname.Text != "" && txtPhoneNo.Text != "" && txtAddress.Text != "" && txtEmail.Text != "" && txtPassword.Text != "" && txtPhoneNo.Text.Replace(" ","").Length >= 12)
                {
                    Functions.edit(usersList, txtName.Text, txtSurname.Text, txtPhoneNo.Text, txtAddress.Text, txtEmail.Text, txtPassword.Text, base64Image, UserProfile.statue, UserProfile.salary);

                    MessageBox.Show("Data Saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please fill in the blanks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Kullanıcı profili bilgilerini güncelleyin
                userProfile.Name = txtName.Text;
                userProfile.Surname = txtSurname.Text;
                userProfile.PhoneNumber = txtPhoneNo.Text;
                userProfile.Address = txtAddress.Text;
                userProfile.Email = txtEmail.Text;
                userProfile.Password = txtPassword.Text;
                userProfile.Picture = base64Image;

                UpdateUI();
            }
            else
            {
                MessageBox.Show("Invalid email address.", "Verification Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateUI()
        {
            // Metin kutularına kullanıcı profili bilgilerini yerleştirin
            txtName.Text = userProfile.Name;
            txtSurname.Text = userProfile.Surname;
            txtPhoneNo.Text = userProfile.PhoneNumber;
            txtAddress.Text = userProfile.Address;
            txtEmail.Text = userProfile.Email;
            txtPassword.Text = userProfile.Password;
            pictureBox1.Image = Functions.Base64ToImage(userProfile.Picture);

            UserProfile.name = userProfile.Name;
            UserProfile.surname = userProfile.Surname;
            UserProfile.phone = userProfile.PhoneNumber;
            UserProfile.address = userProfile.Address;
            UserProfile.email = userProfile.Email;
            UserProfile.password = userProfile.Password;
        }
        public void Undo()
        {
            if (undoStack.Count > 0)
            {
                redoStack.Push(userProfile.Clone() as cloneUser);
                userProfile = undoStack.Pop();
                UpdateUI();
            }
        }

        public void Redo()
        {
            if (redoStack.Count > 0)
            {
                undoStack.Push(userProfile.Clone() as cloneUser);
                userProfile = redoStack.Pop();
                UpdateUI();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!Functions.IsAlphabetic(txtName.Text))
            {
                MessageBox.Show("Only letters can be entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Clear();
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            if (!Functions.IsAlphabetic(txtSurname.Text))
            {
                MessageBox.Show("Only letters can be entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Clear();
            }
        }

        private void HubButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Application.OpenForms["Hub"].Close();
            Hub hub = new Hub();
            hub.Show();
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X + 2, pictureBox2.Location.Y - 2);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X - 2, pictureBox2.Location.Y + 2);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int adminCount = 0;
            string[] lines = File.ReadAllLines("userProfiles.csv");

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts[0].StartsWith("*"))
                {
                    adminCount++;
                }
            }

            if (adminCount > 1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the person?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Functions.deleteUser(usersList, UserProfile.ID);
                    this.Visible = false;
                    File.WriteAllText("remember.txt", "");
                    Login login = new Login();
                    login.Show();
                }
            }
            else
            {
                MessageBox.Show("You must make a user an administrator before deleting yourself\r\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            int score = CalculatePasswordStrength(txtPassword.Text);

            if (score == 0)
            {
                passwordStrength.BackColor = Color.White;
                label2.Text = "";
            }
            if (score == 1)
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
                passwordStrength.Size = new Size(186, 20);
                label2.Text = "Very Strong Password!";
            }
            panel2.Visible = true;
            passwordStrength.Visible = true;
        }

        private void ChangePhoto_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                Image image = Image.FromFile(imagePath);

                pictureBox1.Image = image;

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void PreviousPhoto_Click_1(object sender, EventArgs e)
        {
            Functions.getData("userProfiles.csv", usersList);

            foreach (var item in usersList)
            {
                if (item.ID == UserProfile.ID)
                {
                    Image image = Functions.Base64ToImage(item.Picture);
                    pictureBox1.Image = image;
                }
            }
            usersList.Clear();
        }
    }
}
