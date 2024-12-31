using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pys
{
    public partial class Form6 : Form
    {
        
        private string connectionString = @"Data Source=MÜZISYENN;Initial Catalog=pys;Integrated Security=True;Encrypt=False";

        public Form6()
        {
            InitializeComponent();
        }

        private void textID_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textID.Text, out int id))
            {
                LoadData(id);
            }
        }

        private void LoadData(int id)
        {
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT IstenenYakitMiktari, MevcutDepoMiktari FROM YakitIstegi WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        textIstenenYakitMiktari.Text = reader["IstenenYakitMiktari"].ToString();
                        textMevcutDepoMiktari.Text = reader["MevcutDepoMiktari"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textID.Text, out int id))
            {
                ApproveRequest(id);
            }
            else
            {
                MessageBox.Show("Geçerli bir ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApproveRequest(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    UPDATE YakitIstegi
                    SET MevcutDepoMiktari = MevcutDepoMiktari + IstenenYakitMiktari,
                        Durum = 'Onaylandı'
                    WHERE ID = @ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Yakıt isteği onaylandı ve depo miktarı güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(id); // Verileri güncellemek için tekrar yükle
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
            this.yakitIstegiTableAdapter.Fill(this.pysDataSet3.YakitIstegi);

        }
    }
}
