using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hub
{
    public partial class PersonalInformations : Form
    {
        private cloneUser userProfile = new cloneUser();
        private Stack<cloneUser> undoStack;
        private Stack<cloneUser> redoStack;
        List<cloneUser> usersList = new List<cloneUser>();

        public PersonalInformations()
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

            Image image = Functions.Base64ToImage(UserProfile.picture);
            pictureBox1.Image = image;
            this.KeyPreview = true;
            UpdateUI();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            string email = txtEmail.Text;
            if (Functions.IsValidEmail(email))
            {
                // Geri alma/yineleme için mevcut durumu saklayın
                undoStack.Push(userProfile.Clone() as cloneUser);
                redoStack.Clear();

                string base64Image = Functions.ImageToBase64(pictureBox1.Image);

                UserProfile.picture = base64Image;

                Functions.edit(usersList, txtName.Text, txtSurname.Text, txtPhoneNo.Text, txtAddress.Text, txtEmail.Text, txtPassword.Text, base64Image,UserProfile.statue,UserProfile.salary);

                MessageBox.Show("Veriler Kaydedildi.");
                
                // Kullanıcı profili bilgilerini güncelleyin
                userProfile.Name  = txtName.Text;
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
                MessageBox.Show("Geçersiz e-posta adresi.", "Doğrulama Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void ChangePhoto_Click(object sender, EventArgs e)
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

        private void PreviousPhoto_Click(object sender, EventArgs e)
        {
            Functions.getData("userProfiles.csv", usersList);

            foreach(var item in usersList)
            {
                if(item.ID == UserProfile.ID)
                {
                    Image image = Functions.Base64ToImage(item.Picture);
                    pictureBox1.Image = image;
                }
            }
            usersList.Clear(); 
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

            UserProfile.name = txtName.Text;
            UserProfile.surname = txtSurname.Text;
            UserProfile.phone = txtPhoneNo.Text;
            UserProfile.address = txtAddress.Text;
            UserProfile.email = txtEmail.Text;
            UserProfile.password = txtPassword.Text;
        }
        private void Undo()
        {
            if (undoStack.Count > 0)
            {
                redoStack.Push(userProfile.Clone() as cloneUser);
                userProfile = undoStack.Pop();
                UpdateUI();
            }
        }

        private void Redo()
        {
            if (redoStack.Count > 0)
            {
                undoStack.Push(userProfile.Clone() as cloneUser);
                userProfile = redoStack.Pop();
                UpdateUI();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                Undo();
            }
            else if (e.Control && e.KeyCode == Keys.Y)
            {
                Redo();
            }
        }
        
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!Functions.IsAlphabetic(txtName.Text))
            {
                MessageBox.Show("", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Clear();
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            if (!Functions.IsAlphabetic(txtSurname.Text))
            {
                MessageBox.Show("", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Clear();
            }
        }

        private void HubButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Hub hub = new Hub();
            hub.Show();
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
