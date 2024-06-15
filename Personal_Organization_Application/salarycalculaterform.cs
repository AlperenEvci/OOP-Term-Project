using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hub
{
    public partial class salarycalculaterform : UserControl
    {
        double minimumWage = 13414.5;
        public salarycalculaterform()
        {
            InitializeComponent();

            // ComboBox için deneyim seçeneklerini ekleme
            string[] exps = { "2-4 Years", "5-9 Years", "10-14 Years", "15-20 Years", "over 20 Years" };
            for (int i = 0; i < exps.Length; i++)
            {
                comboBoxExp.Items.Add(exps[i]);
            }

            // Dil seviyelerini belirten checkedListBoxLanguage için seçenekleri ekleme
            string[] languageLvl = { "Documented knowledge of English", "Graduation from a school that provides English education",
                "Documented knowledge of other foreign languages ​​(for each language)"};
            for (int i = 0; i < languageLvl.Length; i++)
            {
                checkedListBoxLanguage.Items.Add(languageLvl[i]);
            }

            // Derece seçeneklerini belirten checkedListBoxDegree için seçenekleri ekleme
            string[] degree = { "Master's degree", "Doctorate degree", "Associate Professorship", "Non-professional Master's degree",
                "Doctorate and Associate Professorship in a non-professional field"};
            for (int i = 0; i < degree.Length; i++)
            {
                checkedListBoxDegree.Items.Add(degree[i]);
            }

            // Görevleri belirten checkedListBoxDuty için seçenekleri ekleme
            string[] Duty = { "Team Leader/Group Manager/Technical Manager/Software Architect",
                              "Project Manager", "Director/Projects Manager", "CTO/CEO", "IT Manager(maximum of 5 IT personnel)",
                              "IT Manager(more than 5 IT personnel)" };

            for (int i = 0; i < Duty.Length; i++)
            {
                checkedListBoxDuty.Items.Add(Duty[i]);
            }

            // Durumları belirten checkedListBoxStatus için seçenekleri ekleme
            string[] Status = { "Married and spouse does not work", "Child aged 0-6", "Child aged 7-18", "Child aged 18-25" };
            for (int i = 0; i < Status.Length; i++)
            {
                checkedListBoxStatus.Items.Add(Status[i]);
            }
        }

        // Hesaplama butonuna tıklandığında hesaplamaları yap
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxCity.Text.Trim() != ""&& IsCity(textBoxCity.Text) && comboBoxExp.SelectedItem != null)
            {
                double sum = 0;

                // Şehir katsayısını hesapla
                sum += cityCoef();

                // Deneyim katsayısını hesapla
                sum += expCoef();

                // Dil seviyesi katsayısını hesapla
                sum += lngCoef();

                // Derece katsayısını hesapla
                sum += degreeCoef();

                // Görev katsayısını hesapla
                sum += dutyCoef();

                // Durum katsayısını hesapla
                sum += statusCoef();
                // Toplam maaşı hesapla
                sum = (minimumWage * 2) * (sum + 1);

                if (UserProfile.statue == "part-time user")
                    sum = sum / 2;

                label1.Text = "Calculated Salary: " + sum.ToString() +" TL";
                UserProfile.salary = sum.ToString();

                List<cloneUser> list = new List<cloneUser>();

                Functions.edit(list, UserProfile.name, UserProfile.surname, UserProfile.phone, UserProfile.address, UserProfile.email, UserProfile.password, UserProfile.picture, UserProfile.statue, UserProfile.salary);

            }
            else
            {
                MessageBox.Show("Salary can not calculated city or experiment duration could be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {
            if (!IsAlphabetic(textBoxCity.Text))
            {
                MessageBox.Show("Please Only Enter Letter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCity.Clear();
            }
        }
        private double cityCoef()
        {
            double sum = 0;
            string input;
            input = Upper(textBoxCity.Text);
            bool isCity = IsCity(input);

            if (isCity)
            {
                string[] region0 = { "İstanbul" };
                string[] region1 = { "Ankara", "İzmir" };
                string[] region2 = { "Kocaeli", "Sakarya", "Düzce", "Bolu", "Yalova", "Edirne", "Kırklareli", "Tekirdağ" };
                string[] region3 = { "Trabzon", "Ordu", "Giresun", "Rize", "Artvin", "Gümüşhane", "Bursa", "Eskişehir", "Bilecik" ,
                                     "Aydın", "Denizli", "Muğla", "Adana", "Mersin", "Balıkesir", "Çanakkale", "Antalya", "Isparta", "Burdur"};
                Dictionary<double, string[]> regions = new Dictionary<double, string[]>() {
                    { 0.3, region0 }, { 0.2, region1 }, { 0.1, region2 }, { 0.05, region3 } };

                foreach (var pair in regions)
                {
                    foreach (string city in pair.Value)
                    {
                        if (city == input)
                        {
                            sum = pair.Key;
                            break; // Şehir bulunduğunda döngüyü sonlandır
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter a City", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCity.Text = "";
            }


            return sum;
        }
        private double expCoef()
        {
            double sum = 0;

            int index = comboBoxExp.SelectedIndex;
            switch (index)
            {
                case 0:
                    sum += 0.6;
                    break;
                case 1:
                    sum += 1;
                    break;
                case 2:
                    sum += 1.2;
                    break;
                case 3:
                    sum += 1.35;
                    break;
                case 4:
                    sum += 1.5;
                    break;
            }

            return sum;
        }
        private double lngCoef()
        {
            double sum = 0;

            bool check = false;

            if (checkedListBoxLanguage.GetItemChecked(0))
            {
                sum += 0.2;
                check = true;
            }
            if (checkedListBoxLanguage.GetItemChecked(1) && !check)
            {
                sum += 0.2;
            }
            if (checkedListBoxLanguage.GetItemChecked(2))
            {
                sum += (double)numericUpDown1.Value * 0.05;
            }
            check = false;


            return sum;
        }
        private double degreeCoef()
        {
            double sum = 0;

            Dictionary<int, double> valueMap = new Dictionary<int, double>
            {
                { 0, 0.1 },
                { 1, 0.3 },
                { 2, 0.35 },
                { 3, 0.05 },
                { 4, 0.15 }
            };

            for (int i = 0; i < checkedListBoxDegree.Items.Count; i++)
            {
                if (checkedListBoxDegree.GetItemChecked(i) && valueMap.ContainsKey(i))
                {
                    sum += valueMap[i];
                }
            }

            return sum;
        }
        private double dutyCoef()
        {
            double sum = 0;

            Dictionary<int, double> valueMap = new Dictionary<int, double>
            {
                { 0, 0.5 },
                { 1, 0.75 },
                { 2, 0.85 },
                { 3, 1 },
                { 4, 0.4 },
                { 5, 0.6 }
            };

            for (int i = 0; i < checkedListBoxDuty.Items.Count; i++)
            {
                if (checkedListBoxDuty.GetItemChecked(i) && valueMap.ContainsKey(i))
                {
                    sum += valueMap[i];
                }
            }

            return sum;
        }
        private double statusCoef()
        {
            double sum = 0;

            Dictionary<int, double> valueMap = new Dictionary<int, double>
            {
                { 0, 0.2 },
                { 1, 0.2 },
                { 2, 0.3 },
                { 3, 0.4 }
            };
            for (int i = 0; i < checkedListBoxStatus.Items.Count; i++)
            {
                if (checkedListBoxStatus.GetItemChecked(i) && valueMap.ContainsKey(i))
                {
                    sum += valueMap[i];
                }
            }
            return sum;
        }

        public static string Upper(string kelime)
        {
            // Kelimenin tamamını küçük harfe çevir
            string kucukHarfKelime = kelime.ToLower();

            // Küçük harfe çevrilen kelimenin ilk harfini büyük yap
            string sonuc = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(kucukHarfKelime);

            return sonuc;
        }
        // Verilen bir metnin bir şehir adı olup olmadığını kontrol eden metot
        public static bool IsCity(string arananSehir)
        {
            string[] cities = new string[]
             {
                "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin",
                "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale",
                "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum",
                "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin",
                "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli",
                "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir",
                "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat",
                "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt",
                "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük",
                "Kilis", "Osmaniye", "Düzce"
             };

            foreach (string sehir in cities)
            {
                if (arananSehir.Equals(sehir, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
        // Verilen bir metnin yalnızca alfabetik karakterler içerip içermediğini kontrol eden metot
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
        private void checkedListBoxLanguage_SelectedValueChanged(object sender, EventArgs e)
        {
            if (checkedListBoxLanguage.GetItemChecked(2))
            {
                numericUpDown1.Visible = true;
            }
            else
            {
                numericUpDown1.Visible = false;
            }
        }
        private void HubButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
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

