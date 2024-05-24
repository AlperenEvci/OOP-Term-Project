using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hub
{
    public partial class management : Form
    {

        public management()
        {
            InitializeComponent();
        }

        private void management_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("userProfiles.csv");

            List<string[]> veriler = new List<string[]>();
            while (!reader.EndOfStream)
            {
                string satir = reader.ReadLine();
                string[] veri = satir.Split(',');

                string isim = veri[0];
                string statü = isim.StartsWith("*") ? "admin" : "user";
                veri[0] = isim.Replace("*",""); 

                veriler.Add(new string[] { veri[0], veri[1], veri[2], veri[3], veri[4], veri[5], statü });
            }

            reader.Close();

            dataGridView1.Rows.Clear();
            for (int i = 1; i < veriler.Count; i++)
            {
                string[] veri = veriler[i];
                dataGridView1.Rows.Add(veri);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<string[]> txtVeriler = new List<string[]>();
            using (StreamReader reader = new StreamReader("userProfiles.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string satir = reader.ReadLine();
                    string[] veri = satir.Split(',');
                    if (veri.Length >= 7) 
                    {
                        txtVeriler.Add(veri);
                    }
                }
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string[] rowData = new string[row.Cells.Count];
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        rowData[i] = row.Cells[i].Value.ToString();
                    }
                    string email = rowData[4]; 
                    string yeniStatu = rowData[6]; 

                    foreach (string[] txtVeri in txtVeriler)
                    {
                        if (txtVeri[4] == email) 
                        {
                            string txtStatu = txtVeri[6]; 
                            if (txtStatu != yeniStatu) 
                            {
                                if (yeniStatu == "admin" && !txtVeri[0].StartsWith("*"))
                                {
                                    txtVeri[0] = "*" + txtVeri[0];
                                }
                                else if (yeniStatu == "user" && txtVeri[0].StartsWith("*"))
                                {
                                    txtVeri[0] = txtVeri[0].Substring(1);
                                }
                            }
                            break; 
                        }
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter("userProfiles.csv"))
            {
                foreach (string[] veri in txtVeriler)
                {
                    string line = string.Join(",", veri);
                    writer.WriteLine(line);
                }
            }

            MessageBox.Show("Veriler başarıyla güncellendi.");

            // burda ana menüye dön
            Hub form = new Hub();
            form.Show();
            this.Close();
        }

        private void HubButton_Click(object sender, EventArgs e)
        {
            Hub form = new Hub();
            form.Show();
            this.Close();
        }
    }
}
