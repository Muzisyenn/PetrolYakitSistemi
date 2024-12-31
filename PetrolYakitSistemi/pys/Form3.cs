using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pys
{
    public partial class Form3 : Form
    {
        private string connectionString = @"Data Source=MÜZISYENN;Initial Catalog=pys;Integrated Security=True;Encrypt=False";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            this.yakitIstegiTableAdapter1.Fill(this.pysDataSet3.YakitIstegi);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 MevcutDepoMiktari FROM YakitIstegi WHERE SubeAdi = 'İstanbul' ORDER BY ID DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        textDepodakiYakit.Text = result.ToString();
                    }
                    else
                    {
                        textDepodakiYakit.Text = "0";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnYakitIste_Click(object sender, EventArgs e)
        {
            string subeAdi = textSubeAdi.Text;
            float istenenYakit;
            float mevcutDepoMiktari;

            
            if (string.IsNullOrWhiteSpace(subeAdi))
            {
                MessageBox.Show("Şube adını giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(textIstenilenYakit.Text, out istenenYakit) || istenenYakit <= 0)
            {
                MessageBox.Show("Geçerli bir istenen yakıt miktarı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(textDepodakiYakit.Text, out mevcutDepoMiktari) || mevcutDepoMiktari < 0)
            {
                MessageBox.Show("Depodaki geçerli yakıt miktarını giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            string query = "INSERT INTO YakitIstegi (SubeAdi, IstenenYakitMiktari, MevcutDepoMiktari) " +
                           "VALUES (@SubeAdi, @IstenenYakitMiktari, @MevcutDepoMiktari)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SubeAdi", subeAdi);
                    cmd.Parameters.AddWithValue("@IstenenYakitMiktari", istenenYakit);
                    cmd.Parameters.AddWithValue("@MevcutDepoMiktari", mevcutDepoMiktari);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Yakıt isteği başarıyla gönderildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            
            textSubeAdi.Clear();
            textIstenilenYakit.Clear();
            textDepodakiYakit.Clear();
        }
    }
}