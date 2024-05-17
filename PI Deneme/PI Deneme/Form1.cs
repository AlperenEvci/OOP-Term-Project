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

namespace PI
{
    public partial class Form1 : Form
    {
        private UserProfile userProfile = new UserProfile();
        private Stack<UserProfile> undoStack;
        private Stack<UserProfile> redoStack;
        public Form1()
        {
            InitializeComponent();

            undoStack = new Stack<UserProfile>();
            redoStack = new Stack<UserProfile>();
            userProfile.Name = "Emir"; 
            userProfile.Surname = "Selengil";
            userProfile.PhoneNumber = "5438363744";
            userProfile.Email = "emir@gmail.com";
            userProfile.Address = "Atatürk Bulvarı";
            userProfile.Password = "selim226";
            this.KeyPreview = true;
            UpdateUI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (IsValidEmail(email))
            {
                // Geri alma/yineleme için mevcut durumu saklayın
                undoStack.Push(userProfile.Clone() as UserProfile);
                redoStack.Clear();

                // Kullanıcı profili bilgilerini güncelleyin
                userProfile.Name = txtName.Text;
                userProfile.Surname = txtSurname.Text;
                userProfile.PhoneNumber = txtPhoneNo.Text;
                userProfile.Address = txtAddress.Text;
                userProfile.Email = txtEmail.Text;
                userProfile.Password = txtPassword.Text;



                Image image = pictureBox1.Image;

                string base64Image = ImageToBase64(image);
                File.WriteAllText("base64image.txt", base64Image);

                MessageBox.Show("Veriler Kaydedildi.");
                // Arayüzü güncelleyin
                UpdateUI();
            }
            else
            {
                MessageBox.Show("Geçersiz e-posta adresi.", "Doğrulama Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private string ImageToBase64(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                //2 kere resim değiştirince hata
                image.Save(ms, image.RawFormat);
                byte[] imageBytes = ms.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
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

                Image image = Base64ToImage(base64Image);

                pictureBox1.Image = image;
            }
            else
            {
                MessageBox.Show("Base64 formatında bir resim bulunamadı.");
            }
        }
        private Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                ms.Write(imageBytes, 0, imageBytes.Length);
                Image image = Image.FromStream(ms, true);
                return image;
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

        }
        private void Undo()
        {
            if (undoStack.Count > 0)
            {
                redoStack.Push(userProfile.Clone() as UserProfile);
                userProfile = undoStack.Pop();
                UpdateUI();
            }
        }

        private void Redo()
        {
            if (redoStack.Count > 0)
            {
                undoStack.Push(userProfile.Clone() as UserProfile);
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
        static bool IsValidEmail(string email)
        {
            // E-posta adresini doğrulamak için bir Regex deseni kullanılır
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                           + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)+)"
                           + @"([a-z0-9!#$%&'*+/=?^_`{|}~-]+|(?<!\.)\.)"
                           + @"@[a-z0-9][a-z0-9-]{0,61}[a-z0-9]\."
                           + @"[a-z0-9][a-z0-9-]{0,61}[a-z0-9]$";

            // E-posta adresi Regex deseni ile eşleşirse true döner, aksi halde false döner
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }
        private bool IsAlphabetic(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!IsAlphabetic(txtName.Text))
            {
                MessageBox.Show("", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Clear();
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            if (!IsAlphabetic(txtSurname.Text))
            {
                MessageBox.Show("", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Clear();
            }
        }
    }
}
