using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kültür_Etkinlik_ve_bilet
{
    public partial class b : Form
    {
        string connectionString = "Server=DESKTOP-KT6O8E3\\SQLEXPRESS;Database=KulturBiletSistemi;Trusted_Connection=True;";

        public b()
        {
            InitializeComponent();
        }

        private void chkPersonel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYetkili.Checked)
                chkMusteri.Checked = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayitol kayit = new Kayitol();
            kayit.Show();
            this.Hide();
        }

        private void chkMusteri_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMusteri.Checked)
                chkYetkili.Checked = false;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtTcKimlik.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz.");
                return;
            }

            string secilenRol = chkMusteri.Checked ? "Müşteri" : chkYetkili.Checked ? "Yetkili" : "";

            if (string.IsNullOrEmpty(secilenRol))
            {
                MessageBox.Show("Lütfen bir rol seçiniz (Müşteri veya Yetkili).");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, KullaniciAdi, Rol FROM Kullanicilar WHERE KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre AND Rol=@Rol";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                cmd.Parameters.AddWithValue("@Sifre", sifre);
                cmd.Parameters.AddWithValue("@Rol", secilenRol);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        KullaniciBilgileri.KullaniciId = reader.GetInt32(0);
                        KullaniciBilgileri.KullaniciAdi = reader.GetString(1);
                        KullaniciBilgileri.Rol = reader.GetString(2);

                        MessageBox.Show("Giriş başarılı! Hoş geldiniz, " + secilenRol);

                        if (secilenRol == "Müşteri")
                        {
                            MusteriGiris musteriGirisForm = new MusteriGiris(KullaniciBilgileri.KullaniciId);
                            musteriGirisForm.Show();
                            this.Hide();
                        }
                        else if (secilenRol == "Yetkili")
                        {
                            YetkiliPanel yetkiliPanelForm = new YetkiliPanel();
                            yetkiliPanelForm.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hatalı giriş bilgileri veya rol seçimi.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}
