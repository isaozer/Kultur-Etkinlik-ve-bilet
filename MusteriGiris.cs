using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kültür_Etkinlik_ve_bilet
{
    public partial class MusteriGiris : Form
    {
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-KT6O8E3\\SQLEXPRESS;Database=KulturBiletSistemi;Trusted_Connection=True;");
        private int girisYapanKullaniciID;
        private int seciliEtkinlikID = -1;
        private decimal seciliEtkinlikFiyati = 0;

        public MusteriGiris(int kullaniciID)
        {
            InitializeComponent();
            girisYapanKullaniciID = kullaniciID;

            guna2TabControl1.SelectedIndexChanged += guna2TabControl1_SelectedIndexChanged;
            guna2DataGridView2.SelectionChanged += guna2DataGridView2_SelectionChanged;

            EtkinlikleriYukle();
        }

        private void EtkinlikleriYukle()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT EtkinlikID, EtkinlikAdi, BiletFiyati FROM Etkinlikler", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                guna2DataGridView2.DataSource = dt;

                if (dt.Rows.Count == 0)
                    MessageBox.Show("Hiç etkinlik bulunamadı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Etkinlikler yüklenirken hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void guna2DataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (guna2DataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow row = guna2DataGridView2.SelectedRows[0];
                seciliEtkinlikID = Convert.ToInt32(row.Cells["EtkinlikID"].Value);
                seciliEtkinlikFiyati = Convert.ToDecimal(row.Cells["BiletFiyati"].Value);
                ToplamTutariHesapla();
            }
        }

        private void numericUpDownAdet_ValueChanged(object sender, EventArgs e)
        {
            ToplamTutariHesapla();
        }

        private void ToplamTutariHesapla()
        {
            int adet = (int)numericUpDownAdet.Value;
            decimal toplam = adet * seciliEtkinlikFiyati;
            lblToplamTutar.Text = toplam.ToString("0.00") + " TL";
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            if (seciliEtkinlikID == -1)
            {
                MessageBox.Show("Lütfen bir etkinlik seçiniz.");
                return;
            }

            int adet = (int)numericUpDownAdet.Value;
            decimal toplam = adet * seciliEtkinlikFiyati;
            string odemeYontemi = radioKrediKart.Checked ? "Kredi Kartı" : "Nakit";

            try
            {
                baglanti.Open();
                string query = @"INSERT INTO EtkinlikSatinAlma 
                                (KullaniciID, EtkinlikID, Adet, ToplamTutar, OdemeYontemi) 
                                VALUES (@kullaniciID, @etkinlikID, @adet, @toplam, @odeme)";

                using (SqlCommand cmd = new SqlCommand(query, baglanti))
                {
                    cmd.Parameters.AddWithValue("@kullaniciID", girisYapanKullaniciID);
                    cmd.Parameters.AddWithValue("@etkinlikID", seciliEtkinlikID);
                    cmd.Parameters.AddWithValue("@adet", adet);
                    cmd.Parameters.AddWithValue("@toplam", toplam);
                    cmd.Parameters.AddWithValue("@odeme", odemeYontemi);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Satın alma işlemi başarıyla gerçekleşti.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Satın alma hatası: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2TabControl1.SelectedTab == tabPageCikis)
            {
                DialogResult result = MessageBox.Show("Çıkmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    this.Hide();
                else
                    guna2TabControl1.SelectedTab = tabPageHesabim;
            }
            else if (guna2TabControl1.SelectedTab == tabPageHesabim)
            {
                KullanicilariGetir();
            }
        }

        private void KullanicilariGetir()
        {
            try
            {
                baglanti.Open();
                string query = "SELECT KullaniciAdi, AdSoyad, Cinsiyet FROM Kullanicilar WHERE Id = @id";

                using (SqlCommand cmd = new SqlCommand(query, baglanti))
                {
                    cmd.Parameters.AddWithValue("@id", girisYapanKullaniciID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblKullaniciAdi1.Text = reader["KullaniciAdi"].ToString();
                        lblAdSoyad1.Text = reader["AdSoyad"].ToString();
                        lblCinsiyet1.Text = reader["Cinsiyet"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bilgileri bulunamadı.");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri getirme hatası: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void tabPageAlinanBiletler_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string query = @"
                    SELECT 
                        ea.SatinAlmaID,
                        e.EtkinlikAdi,
                        ea.Adet,
                        ea.ToplamTutar,
                        ea.OdemeYontemi,
                        ea.SatinAlmaTarihi
                    FROM EtkinlikSatinAlma ea
                    INNER JOIN Etkinlikler e ON ea.EtkinlikID = e.EtkinlikID
                    WHERE ea.KullaniciID = @kullaniciID
                    ORDER BY ea.SatinAlmaTarihi DESC";

                SqlCommand cmd = new SqlCommand(query, baglanti);
                cmd.Parameters.AddWithValue("@kullaniciID", girisYapanKullaniciID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                guna2DataGridView4.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Henüz alınmış bir bilet bulunmuyor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilet geçmişi yüklenirken hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
