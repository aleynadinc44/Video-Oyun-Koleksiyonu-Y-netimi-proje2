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
    public partial class yorum: Form
    {
        private string connectionString = "Server=LAPTOP-6Q32OA4J\\SQLEXPRESS;Database=videooyun;Integrated Security=True;";
        public yorum()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'videooyunDataSet.OyunYorum' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oyunYorumTableAdapter.Fill(this.videooyunDataSet.OyunYorum);
           

        }

        private void geri_Click(object sender, EventArgs e)
        {
            anasayfa form3 = new anasayfa();
            form3.Show();
            this.Hide();
        }

        private void yorumeklebt_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();


                    string sorgu = "INSERT INTO OyunYorum (OyunAdi, Puan,Yorum) " +
                    "VALUES (@oyunadi, @puan, @yorum)";

                    SqlCommand komut = new SqlCommand(sorgu, conn);
                    komut.Parameters.AddWithValue("@oyunadi", oyunaditxt.Text);
                    komut.Parameters.AddWithValue("@puan", puancombo.Text);
                    komut.Parameters.AddWithValue("@yorum", yorumtxt.Text);

                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Dosya Başarı ile eklendi!", "Başarılı");
                        //  Tabloyu yenile
                        this.oyunYorumTableAdapter.Fill(this.videooyunDataSet.OyunYorum);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt başarısız. Hiçbir satır eklenmedi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
