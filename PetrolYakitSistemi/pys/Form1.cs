using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pys
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=MÜZISYENN;Initial Catalog=pys;Integrated Security=True;Encrypt=False";

        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            UpdateDepodakiYakit();
            float yakitFiyati = GetYakitFiyati();
            lblYakitFiyati.Text = $"Yakıt Fiyatı: {yakitFiyati} TL/Litre";

            this.kasaTablosuTableAdapter.Fill(this.pysDataSet.KasaTablosu);
        }

        private float GetYakitFiyati()
        {
            float fiyat = 0;
            string query = "SELECT TOP 1 YakitFiyati FROM KasaTablosu ORDER BY ID DESC";

            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                fiyat = Convert.ToSingle(cmd.ExecuteScalar());
            }

            return fiyat;
        }

        private void UpdateDepodakiYakit()
        {
            string query = "SELECT MevcutDepoMiktari FROM YakitIstegi WHERE SubeAdi = 'İstanbul'";
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                object result = cmd.ExecuteScalar();
                textDepodakiYakit.Text = result != null ? result.ToString() : "0";
            }
        }

        private void btnFisyazdir_Click(object sender, EventArgs e)
        {
            string aracPlakasi = textAracPlakasi.Text;
            float yakitMiktari = float.Parse(textAladigiyakitmiktari.Text);
            string odemeTuru = comboOdemeturu.SelectedItem.ToString();
            string islemYapanCalisan = textIslemiyapankisi.Text;
            float odenenUcret = float.Parse(textödeyecegiücret.Text);
            float yakitFiyati = GetYakitFiyati();

            
            float mevcutDepoMiktari = float.Parse(textDepodakiYakit.Text);
            if (mevcutDepoMiktari < yakitMiktari)
            {
                MessageBox.Show("Yeterli yakıt bulunmuyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            string query = "INSERT INTO KasaTablosu (AracPlakasi, YakitMiktari, OdemeTuru, IslemYapanCalisan, OdenenUcret, YakitFiyati) " +
                           "VALUES (@plaka, @miktar, @odemeTuru, @islemYapan, @odemeUcreti, @yakitFiyati)";

            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@plaka", aracPlakasi);
                cmd.Parameters.AddWithValue("@miktar", yakitMiktari);
                cmd.Parameters.AddWithValue("@odemeTuru", odemeTuru);
                cmd.Parameters.AddWithValue("@islemYapan", islemYapanCalisan);
                cmd.Parameters.AddWithValue("@odemeUcreti", odenenUcret);
                cmd.Parameters.AddWithValue("@yakitFiyati", yakitFiyati);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            
            string updateQuery = "UPDATE YakitIstegi SET MevcutDepoMiktari = MevcutDepoMiktari - @miktar WHERE SubeAdi = 'İstanbul'";
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@miktar", yakitMiktari);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            
            UpdateDepodakiYakit();

            
            string fis = $"--- PETROL OFİSİ FİŞİ ---\n" +
                         $"Araç Plakası: {aracPlakasi}\n" +
                         $"Yakıt Miktarı: {yakitMiktari} Litre\n" +
                         $"Yakıt Fiyatı: {yakitFiyati} TL/Litre\n" +
                         $"Ödenen Ücret: {odenenUcret} TL\n" +
                         $"Ödeme Türü: {odemeTuru}\n" +
                         $"İşlem Yapan Çalışan: {islemYapanCalisan}\n" +
                         $"------------------------";

            MessageBox.Show(fis, "Fiş Yazdırma", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textAladigiyakitmiktari_TextChanged(object sender, EventArgs e)
        {
            float yakitMiktari;
            if (float.TryParse(textAladigiyakitmiktari.Text, out yakitMiktari))
            {
                float yakitFiyati = GetYakitFiyati();
                float odenenUcret = yakitMiktari * yakitFiyati;
                textödeyecegiücret.Text = odenenUcret.ToString("F2");
            }
            else
            {
                textödeyecegiücret.Clear();
            }
        }
    }
}
