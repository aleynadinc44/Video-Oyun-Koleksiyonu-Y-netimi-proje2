using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Video_Oyun_Koleksiyonu_Yönetimi_proje2
{
    public partial class kullanici: Form
    {
        private string connectionString = "Server=LAPTOP-6Q32OA4J\\SQLEXPRESS;Database=videooyun;Integrated Security=True;";
        private string secilikullanici;
        public kullanici(string eposta)
        {
            InitializeComponent();
            this.secilikullanici = eposta;
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'videooyunDataSet.oyunlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oyunlarTableAdapter.Fill(this.videooyunDataSet.oyunlar);
            // TODO: Bu kod satırı 'videooyunDataSet.oyunlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oyunlarTableAdapter.Fill(this.videooyunDataSet.oyunlar);
            KullaniciBilgileriniYukle();
        }

        private void oyuneklebt_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6Q32OA4J\SQLEXPRESS;Initial Catalog=videooyun;Integrated Security=True"))
                {
                    conn.Open();
                    string girilenDeger = boyuttxt.Text.ToLower().Trim();
                    decimal boyutDeger;

                    // GB cinsinden normalize et
                    if (girilenDeger.Contains("mb"))
                    {
                        girilenDeger = girilenDeger.Replace("mb", "").Trim();
                        if (!decimal.TryParse(girilenDeger, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal mbDeger))
                        {
                            MessageBox.Show("Geçersiz MB değeri girdiniz.", "Hata");
                            return;
                        }
                        boyutDeger = mbDeger / 1024; // MB'den GB'ye çevir
                    }
                    else if (girilenDeger.Contains("gb"))
                    {
                        girilenDeger = girilenDeger.Replace("gb", "").Trim();
                        if (!decimal.TryParse(girilenDeger, NumberStyles.Any, CultureInfo.InvariantCulture, out boyutDeger))
                        {
                            MessageBox.Show("Geçersiz GB değeri girdiniz.", "Hata");
                            return;
                        }
                    }
                    else
                    {
                        // Hiçbir birim yoksa, direkt sayı varsay (GB)
                        if (!decimal.TryParse(girilenDeger, NumberStyles.Any, CultureInfo.InvariantCulture, out boyutDeger))
                        {
                            MessageBox.Show("Lütfen oyun boyutunu doğru formatta girin. Örn: 1.5gb veya 500mb", "Hatalı Giriş");
                            return;
                        }
                    }
                




                    // SQL INSERT sorgusu
                    string sorgu = "INSERT INTO oyunlar ([oyun_adi], [oyun_turu], [oyun_boyutu]) " +
                    "VALUES (@oyunadi, @oyunturu, @oyunboyutu)";

                    SqlCommand komut = new SqlCommand(sorgu, conn);
                    komut.Parameters.AddWithValue("@oyunadi", Adıtxt.Text);
                    komut.Parameters.AddWithValue("@oyunturu", turucombo.Text);
                    komut.Parameters.AddWithValue("@oyunboyutu", boyutDeger); // Bu satırda CS1061 hatası veriyor

                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kayıt başarıyla tamamlandı!", "Başarılı");
                        this.oyunlarTableAdapter.Fill(this.videooyunDataSet.oyunlar);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt başarısız. Hiçbir satır eklenmedi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void KullaniciBilgileriniYukle()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    //Belirli bir eğitmenin bilgilerini ÇEKMEK için SQL sorgusu
                    string sorgu = "SELECT adi, soyadi FROM kullanicilar WHERE [e_posta] = @eposta";

                    using (SqlCommand command = new SqlCommand(sorgu, conn))
                    {
                        //  Parametreye mevcut eğitmen ID'sini atıyoruz
                        command.Parameters.AddWithValue("@eposta", secilikullanici);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Eğer bir kayıt bulunduysa
                            {
                                // Veritabanından okunan değerleri form üzerindeki kontrollere aktar
                                
                                adsoyadtxt.Text = $"{reader["adi"]} {reader["soyadi"]}";

                            }
                            else
                            {
                                MessageBox.Show("Belirtilen ID'ye sahip eğitmen bulunamadı.", "Bilgi");
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata");
            }
        }

        private void geribt_Click(object sender, EventArgs e)
        {
            Giris Giriş = new Giris();
            Giriş.Show();
            this.Hide();
        }

        private void anasayfabt_Click(object sender, EventArgs e)
        {
            anasayfa form3 = new anasayfa();
            form3.Show();
            this.Hide();
        }
    }
    }

