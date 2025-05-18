namespace Video_Oyun_Koleksiyonu_Yönetimi_proje2
{
    partial class Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.label1 = new System.Windows.Forms.Label();
            this.epostatxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kayıtsızbt = new System.Windows.Forms.Button();
            this.girisbt = new System.Windows.Forms.Button();
            this.kayitbt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // epostatxt
            // 
            this.epostatxt.Location = new System.Drawing.Point(379, 74);
            this.epostatxt.Name = "epostatxt";
            this.epostatxt.Size = new System.Drawing.Size(221, 22);
            this.epostatxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(264, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // sifretxt
            // 
            this.sifretxt.Location = new System.Drawing.Point(379, 169);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.PasswordChar = '*';
            this.sifretxt.Size = new System.Drawing.Size(157, 22);
            this.sifretxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(254, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-Posta";
            // 
            // kayıtsızbt
            // 
            this.kayıtsızbt.BackColor = System.Drawing.Color.White;
            this.kayıtsızbt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıtsızbt.ForeColor = System.Drawing.Color.Black;
            this.kayıtsızbt.Location = new System.Drawing.Point(450, 310);
            this.kayıtsızbt.Name = "kayıtsızbt";
            this.kayıtsızbt.Size = new System.Drawing.Size(315, 55);
            this.kayıtsızbt.TabIndex = 5;
            this.kayıtsızbt.Text = "Kayıt Olmadan Devam Et ";
            this.kayıtsızbt.UseVisualStyleBackColor = false;
            this.kayıtsızbt.Click += new System.EventHandler(this.kayitsizbt_Click);
            // 
            // girisbt
            // 
            this.girisbt.BackColor = System.Drawing.Color.White;
            this.girisbt.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisbt.ForeColor = System.Drawing.Color.Black;
            this.girisbt.Location = new System.Drawing.Point(379, 226);
            this.girisbt.Name = "girisbt";
            this.girisbt.Size = new System.Drawing.Size(133, 61);
            this.girisbt.TabIndex = 6;
            this.girisbt.Text = "Giriş";
            this.girisbt.UseVisualStyleBackColor = false;
            this.girisbt.Click += new System.EventHandler(this.girisbt_Click);
            // 
            // kayitbt
            // 
            this.kayitbt.BackColor = System.Drawing.Color.White;
            this.kayitbt.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitbt.ForeColor = System.Drawing.Color.Black;
            this.kayitbt.Location = new System.Drawing.Point(220, 310);
            this.kayitbt.Name = "kayitbt";
            this.kayitbt.Size = new System.Drawing.Size(134, 55);
            this.kayitbt.TabIndex = 7;
            this.kayitbt.Text = "Kayıt Ol";
            this.kayitbt.UseVisualStyleBackColor = false;
            this.kayitbt.Click += new System.EventHandler(this.kayitbt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(547, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Oyun eklemek için Lütfen giriş yapınız!!";
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(863, 555);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kayitbt);
            this.Controls.Add(this.girisbt);
            this.Controls.Add(this.kayıtsızbt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.epostatxt);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox epostatxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button kayıtsızbt;
        private System.Windows.Forms.Button girisbt;
        private System.Windows.Forms.Button kayitbt;
        private System.Windows.Forms.Label label4;
    }
}

