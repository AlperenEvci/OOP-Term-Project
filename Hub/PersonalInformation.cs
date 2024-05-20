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

namespace PI
{
    public partial class PersonalInformation : Form
    {
        private cloneUser userProfile = new cloneUser();
        private Stack<cloneUser> undoStack;
        private Stack<cloneUser> redoStack;
        List<cloneUser> usersList = new List<cloneUser>();

        public PersonalInformation()
        {
            InitializeComponent();

            undoStack = new Stack<cloneUser>();
            redoStack = new Stack<cloneUser>();
            userProfile.Name = UserProfile.Name; 
            userProfile.Surname = UserProfile.Surname;
            userProfile.PhoneNumber = UserProfile.PhoneNumber;
            userProfile.Email = UserProfile.Email;
            userProfile.Address = UserProfile.Address;
            userProfile.Password = UserProfile.Password;
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

                Image image = pictureBox1.Image;

                string base64Image = Functions.ImageToBase64(image);

                File.WriteAllText("base64image.txt", base64Image);

                Functions.edit(usersList, txtName.Text, txtSurname.Text, txtPhoneNo.Text, txtAddress.Text, txtEmail.Text, txtPassword.Text);

                MessageBox.Show("Veriler Kaydedildi.");

                // Kullanıcı profili bilgilerini güncelleyin
                userProfile.Name  = txtName.Text;
                userProfile.Surname = txtSurname.Text;
                userProfile.PhoneNumber = txtPhoneNo.Text;
                userProfile.Address = txtAddress.Text;
                userProfile.Email = txtEmail.Text;
                userProfile.Password = txtPassword.Text;

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
            if (File.Exists("base64image.txt"))
            {
                string base64Image = File.ReadAllText("base64image.txt");

                Image image = Functions.Base64ToImage(base64Image);

                pictureBox1.Image = image;
            }
            else
            {
                MessageBox.Show("Base64 formatında bir resim bulunamadı.");
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

            UserProfile.Name = txtName.Text;
            UserProfile.Surname = txtSurname.Text;
            UserProfile.PhoneNumber = txtPhoneNo.Text;
            UserProfile.Address = txtAddress.Text;
            UserProfile.Email = txtEmail.Text;
            UserProfile.Password = txtPassword.Text;

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
            Hub.Hub hub = new Hub.Hub();
            hub.Show();
        }
    }
}
