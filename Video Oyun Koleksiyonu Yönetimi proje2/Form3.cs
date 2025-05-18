using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Oyun_Koleksiyonu_Yönetimi_proje2
{
    public partial class anasayfa: Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'videooyunDataSet.oyunlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oyunlarTableAdapter.Fill(this.videooyunDataSet.oyunlar);
            // TODO: Bu kod satırı 'videooyunDataSet.oyunlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oyunlarTableAdapter.Fill(this.videooyunDataSet.oyunlar);
            // TODO: Bu kod satırı 'videooyunDataSet.oyunlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oyunlarTableAdapter.Fill(this.videooyunDataSet.oyunlar);

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void okeybt_Click(object sender, EventArgs e)
        {
            yorum Yorumlar = new yorum();
            Yorumlar.Show();
            this.Hide();
        }

        private void atessubt_Click(object sender, EventArgs e)
        {
            yorum Yorumlar = new yorum();
            Yorumlar.Show();
            this.Hide();
        }

        private void pubgbt_Click(object sender, EventArgs e)
        {
            yorum Yorumlar = new yorum();
            Yorumlar.Show();
            this.Hide();
        }

        private void minecraftbt_Click(object sender, EventArgs e)
        {
            yorum Yorumlar = new yorum();
            Yorumlar.Show();
            this.Hide();
        }

        private void mariobt_Click(object sender, EventArgs e)
        {
            yorum Yorumlar = new yorum();
            Yorumlar.Show();
            this.Hide();
        }

        private void pokemonbt_Click(object sender, EventArgs e)
        {
            yorum Yorumlar = new yorum();
            Yorumlar.Show();
            this.Hide();
        }

        private void popokeybt_Click(object sender, EventArgs e)
        {
            yorum Yorumlar = new yorum();
            Yorumlar.Show();
            this.Hide();
        }

        private void popminecraftbt_Click(object sender, EventArgs e)
        {
            yorum Yorumlar = new yorum();
            Yorumlar.Show();
            this.Hide();
        }

        private void popmbllbt_Click(object sender, EventArgs e)
        {
            yorum Yorumlar = new yorum();
            Yorumlar.Show();
            this.Hide();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Giris Giriş = new Giris();
            Giriş.Show();
            this.Hide();
        }
    }
}
