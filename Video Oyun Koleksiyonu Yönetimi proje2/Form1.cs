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
    public partial class Giris: Form
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
        public Giris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void girisbt_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();

                string sorgu = "SELECT COUNT(*) FROM kullanicilar WHERE [e_posta] = @eposta AND sifre = @Sifre";

                using (SqlCommand kontrol = new SqlCommand(sorgu, conn))
                {
                    kontrol.Parameters.AddWithValue("@eposta", epostatxt.Text);
                    kontrol.Parameters.AddWithValue("@Sifre", sifretxt.Text);

                    int sonuc = (int)kontrol.ExecuteScalar();

                    if (sonuc > 0)
                    {
                        string eposta = epostatxt.Text;
                        kullanici Kullanıcı = new kullanici(eposta);
                        Kullanıcı.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void kayitbt_Click(object sender, EventArgs e)
        {

            
            Kayit Kayıt= new Kayit(); // constructor string olmalı                                                     // constructor da long olmalı
            Kayıt.Show();
            this.Hide();
            
        }

        private void kayitsizbt_Click(object sender, EventArgs e)
        {
            anasayfa form3 = new anasayfa();
            form3.Show();
            this.Hide();

        }
    }
}
