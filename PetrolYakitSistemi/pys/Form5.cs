using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pys
{
    public partial class Form5 : Form
    {
        private string connectionString = @"Data Source=MÜZISYENN;Initial Catalog=pys;Integrated Security=True;Encrypt=False";

        public Form5()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            string isimSoyisim = textisimsoyisim.Text.Trim();
            string calisacagiSube = textCalisacagiSube.Text.Trim();
            string yapacagiIs = comboBoxYapacagiis.SelectedItem?.ToString();
            float maas;

            
            if (string.IsNullOrWhiteSpace(isimSoyisim) || string.IsNullOrWhiteSpace(calisacagiSube) || string.IsNullOrWhiteSpace(yapacagiIs))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(textAlacagiMaas.Text, out maas) || maas <= 0)
            {
                MessageBox.Show("Geçerli bir maaş giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            string query = "INSERT INTO PersonelBilgileri (IsimSoyisim, CalistigiSube, NeIsYapiyor, Maas) " +
                           "VALUES (@IsimSoyisim, @CalistigiSube, @NeIsYapiyor, @Maas)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IsimSoyisim", isimSoyisim);
                    cmd.Parameters.AddWithValue("@CalistigiSube", calisacagiSube);
                    cmd.Parameters.AddWithValue("@NeIsYapiyor", yapacagiIs);
                    cmd.Parameters.AddWithValue("@Maas", maas);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Personel bilgileri başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Alanları temizle
                        textisimsoyisim.Clear();
                        textCalisacagiSube.Clear();
                        comboBoxYapacagiis.SelectedIndex = -1;
                        textAlacagiMaas.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
            this.personelBilgileriTableAdapter1.Fill(this.pysDataSet3.PersonelBilgileri);
            
            this.personelBilgileriTableAdapter.Fill(this.pysDataSet2.PersonelBilgileri);
            
            this.yakitIstegiTableAdapter.Fill(this.pysDataSet2.YakitIstegi);

        }
    }
}
