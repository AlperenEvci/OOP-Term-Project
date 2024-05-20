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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;

namespace PI
{
    internal class Functions
    {
        public static void getData(string filePath, List<cloneUser> list)
        {

            DataTable dt = new DataTable();
            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length > 0)
            {
                // İlk satırı başlık olarak kullan
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                // Verileri satır satır oku
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    cloneUser user = new cloneUser
                    {
                        Name = row["Name"].ToString(),
                        Surname = row["Surname"].ToString(),
                        PhoneNumber = row["PhoneNumber"].ToString(),
                        Address = row["Email"].ToString(),
                        Email = row["Address"].ToString(),
                        Password = row["Password"].ToString(),
                        ID = Convert.ToInt32(row["ID"]),
                    };
                    list.Add(user);
                }
            }
        }
        public static void edit(List<cloneUser> list,string Name, string Surname, string PhoneNo, string Address, string Email, string Password)
        {
            Functions.getData("userProfiles.csv", list);
            foreach (cloneUser user in list)
            {
                if (user.ID == UserProfile.ID)
                {
                    user.Name = Name;
                    user.Surname = Surname;
                    user.PhoneNumber = PhoneNo;
                    user.Address = Address;
                    user.Email = Email;
                    user.Password = Password;
                    break;
                }
            }

            SaveDataToCsv("userProfiles.csv", list);
            list.Clear();

        }
        public static void SaveDataToCsv(string filePath, List<cloneUser> list)
        {
            //clearin csv file
            File.WriteAllText(filePath, string.Empty);
            //writing the headers
            string headers = "Name,Surname,PhoneNumber,Address,Email,Password,ID\n";
            File.WriteAllText(filePath, headers);
            for (int i = 0; i < list.Count; i++)
            {
                cloneUser person = list[i];
                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        // Verileri virgülle ayrılmış bir satır olarak dosyaya yaz
                        writer.WriteLine($"{person.Name},{person.Surname},{person.PhoneNumber},{person.Address},{person.Email},{person.Password},{person.ID}");
                    }
                }
                catch (Exception ex)
                {
                    // Hata yönetimi burada yapılabilir
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }
        public static string ImageToBase64(Image image)
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
        public static Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                ms.Write(imageBytes, 0, imageBytes.Length);
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }
        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public static bool IsAlphabetic(string input)
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
    }
}
