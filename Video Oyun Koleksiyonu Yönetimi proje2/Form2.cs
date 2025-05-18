using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Oyun_Koleksiyonu_Yönetimi_proje2
{
    public partial class Kayit: Form
    {

        SQLBağlantısı bgl = new SQLBağlantısı();
        public class Baglanti
        {
            public SqlConnection baglanti()
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6Q32OA4J\SQLEXPRESS;Initial Catalog=videooyun;Integrated Security=True");
                return conn;
            }
        }
        public Kayit()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void kayitbt_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6Q32OA4J\SQLEXPRESS;Initial Catalog=videooyun;Integrated Security=True"))
                {
                    conn.Open();

                    DateTime dogumTarihi;
                    if (!DateTime.TryParse(txtDogumTarihi.Text, out dogumTarihi))
                    {
                        MessageBox.Show("Geçerli bir tarih formatı girin (örn: 01.01.2000)");
                        return;
                    }

                    // SQL INSERT sorgusu
                    string sorgu = "INSERT INTO kullanicilar ([e_posta],adi,soyadi,[dogum_tarihi],sifre) " +
                    "VALUES (@eposta,@adi,@soyadi,@dogumtarihi,@sifre)";

                    SqlCommand komut = new SqlCommand(sorgu, conn);
                    komut.Parameters.AddWithValue("@adi", txtAd.Text);
                    komut.Parameters.AddWithValue("@soyadi", txtSoyad.Text);
                    komut.Parameters.AddWithValue("@eposta", epostatxt.Text);
                    komut.Parameters.AddWithValue("@dogumtarihi", Convert.ToDateTime(txtDogumTarihi.Text));
                    komut.Parameters.AddWithValue("@sifre", txtsifre.Text);


                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kayıt başarıyla tamamlandı!", "Başarılı");

                        string eposta = epostatxt.Text;
                        kullanici Kullanıcı = new kullanici(eposta);
                        Kullanıcı.Show();
                        this.Hide();                             


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

        private void Kayit_Load(object sender, EventArgs e)
        {
           

        }

        private void geri_Click(object sender, EventArgs e)
        {
            Giris Giriş = new Giris();
            Giriş.Show();
            this.Hide();
        }
    }
}
