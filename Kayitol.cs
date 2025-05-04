using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kültür_Etkinlik_ve_bilet
{
    public partial class Kayitol : Form
    {
        string connectionString = "Server=DESKTOP-KT6O8E3\\SQLEXPRESS;Database=KulturBiletSistemi;Trusted_Connection=True;";

        public Kayitol()
        {
            InitializeComponent();
        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string adSoyad = txtAdSoyad.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            string cinsiyet = rbtnErkek.Checked ? "Erkek" : "Kadın";
            string rol = "Müşteri"; // Herkes varsayılan olarak müşteri olarak kayıt olur

            if (string.IsNullOrWhiteSpace(adSoyad) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Rastgele kullanıcı adı üret
            string randomSuffix = new Random().Next(100, 999).ToString();
            string adSoyadParca = adSoyad.Split(' ')[0].ToLower();
            string kullaniciAdi = adSoyadParca + randomSuffix;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Kullanicilar (AdSoyad, Sifre, Cinsiyet, KullaniciAdi, Rol) " +
                               "VALUES (@AdSoyad, @Sifre, @Cinsiyet, @KullaniciAdi, @Rol)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AdSoyad", adSoyad);
                cmd.Parameters.AddWithValue("@Sifre", sifre);
                cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                cmd.Parameters.AddWithValue("@Rol", rol);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarılı! Kullanıcı adınız: " + kullaniciAdi, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }

    }
}
