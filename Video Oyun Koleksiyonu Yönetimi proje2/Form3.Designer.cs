namespace Video_Oyun_Koleksiyonu_Yönetimi_proje2
{
    partial class anasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oyunidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oyunadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oyunturuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oyunboyutuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oyunlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videooyunDataSet = new Video_Oyun_Koleksiyonu_Yönetimi_proje2.videooyunDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pokemonbt = new System.Windows.Forms.Button();
            this.mariobt = new System.Windows.Forms.Button();
            this.minecraftbt = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.okeybt = new System.Windows.Forms.Button();
            this.pubgbt = new System.Windows.Forms.Button();
            this.atessubt = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.popmbllbt = new System.Windows.Forms.Button();
            this.popminecraftbt = new System.Windows.Forms.Button();
            this.popokeybt = new System.Windows.Forms.Button();
            this.oyunlarTableAdapter = new Video_Oyun_Koleksiyonu_Yönetimi_proje2.videooyunDataSetTableAdapters.oyunlarTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.geri = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyunlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videooyunDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(27, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 528);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.geri);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.pokemonbt);
            this.tabPage1.Controls.Add(this.mariobt);
            this.tabPage1.Controls.Add(this.minecraftbt);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.okeybt);
            this.tabPage1.Controls.Add(this.pubgbt);
            this.tabPage1.Controls.Add(this.atessubt);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tüm Oyunlar";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(216, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Yorumlar için görsellere tıklayınız";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oyunidDataGridViewTextBoxColumn,
            this.oyunadiDataGridViewTextBoxColumn,
            this.oyunturuDataGridViewTextBoxColumn,
            this.oyunboyutuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oyunlarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(738, 174);
            this.dataGridView1.TabIndex = 29;
            // 
            // oyunidDataGridViewTextBoxColumn
            // 
            this.oyunidDataGridViewTextBoxColumn.DataPropertyName = "oyun_id";
            this.oyunidDataGridViewTextBoxColumn.HeaderText = "oyun_id";
            this.oyunidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oyunidDataGridViewTextBoxColumn.Name = "oyunidDataGridViewTextBoxColumn";
            this.oyunidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oyunadiDataGridViewTextBoxColumn
            // 
            this.oyunadiDataGridViewTextBoxColumn.DataPropertyName = "oyun_adi";
            this.oyunadiDataGridViewTextBoxColumn.HeaderText = "oyun_adi";
            this.oyunadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oyunadiDataGridViewTextBoxColumn.Name = "oyunadiDataGridViewTextBoxColumn";
            // 
            // oyunturuDataGridViewTextBoxColumn
            // 
            this.oyunturuDataGridViewTextBoxColumn.DataPropertyName = "oyun_turu";
            this.oyunturuDataGridViewTextBoxColumn.HeaderText = "oyun_turu";
            this.oyunturuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oyunturuDataGridViewTextBoxColumn.Name = "oyunturuDataGridViewTextBoxColumn";
            // 
            // oyunboyutuDataGridViewTextBoxColumn
            // 
            this.oyunboyutuDataGridViewTextBoxColumn.DataPropertyName = "oyun_boyutu";
            this.oyunboyutuDataGridViewTextBoxColumn.HeaderText = "oyun_boyutu";
            this.oyunboyutuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oyunboyutuDataGridViewTextBoxColumn.Name = "oyunboyutuDataGridViewTextBoxColumn";
            // 
            // oyunlarBindingSource
            // 
            this.oyunlarBindingSource.DataMember = "oyunlar";
            this.oyunlarBindingSource.DataSource = this.videooyunDataSet;
            // 
            // videooyunDataSet
            // 
            this.videooyunDataSet.DataSetName = "videooyunDataSet";
            this.videooyunDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(573, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Mario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(415, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Minecraft";
            // 
            // pokemonbt
            // 
            this.pokemonbt.BackColor = System.Drawing.Color.Transparent;
            this.pokemonbt.BackgroundImage = global::Video_Oyun_Koleksiyonu_Yönetimi_proje2.Properties.Resources.indir_;
            this.pokemonbt.Location = new System.Drawing.Point(672, 87);
            this.pokemonbt.Name = "pokemonbt";
            this.pokemonbt.Size = new System.Drawing.Size(102, 106);
            this.pokemonbt.TabIndex = 24;
            this.pokemonbt.UseVisualStyleBackColor = false;
            this.pokemonbt.Click += new System.EventHandler(this.pokemonbt_Click);
            // 
            // mariobt
            // 
            this.mariobt.BackColor = System.Drawing.Color.Transparent;
            this.mariobt.BackgroundImage = global::Video_Oyun_Koleksiyonu_Yönetimi_proje2.Properties.Resources.images__1___1_;
            this.mariobt.Location = new System.Drawing.Point(550, 87);
            this.mariobt.Name = "mariobt";
            this.mariobt.Size = new System.Drawing.Size(102, 106);
            this.mariobt.TabIndex = 23;
            this.mariobt.UseVisualStyleBackColor = false;
            this.mariobt.Click += new System.EventHandler(this.mariobt_Click);
            // 
            // minecraftbt
            // 
            this.minecraftbt.BackColor = System.Drawing.Color.Transparent;
            this.minecraftbt.BackgroundImage = global::Video_Oyun_Koleksiyonu_Yönetimi_proje2.Properties.Resources.indir__1___1_;
            this.minecraftbt.Location = new System.Drawing.Point(410, 87);
            this.minecraftbt.Name = "minecraftbt";
            this.minecraftbt.Size = new System.Drawing.Size(102, 106);
            this.minecraftbt.TabIndex = 22;
            this.minecraftbt.UseVisualStyleBackColor = false;
            this.minecraftbt.Click += new System.EventHandler(this.minecraftbt_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(53, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 27);
            this.label9.TabIndex = 21;
            this.label9.Text = "ÖNERİLENLER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(300, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Pubg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(158, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ateş ve Su";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(45, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Okey";
            // 
            // okeybt
            // 
            this.okeybt.BackColor = System.Drawing.Color.Transparent;
            this.okeybt.BackgroundImage = global::Video_Oyun_Koleksiyonu_Yönetimi_proje2.Properties.Resources.unnamed__1_;
            this.okeybt.Location = new System.Drawing.Point(21, 87);
            this.okeybt.Name = "okeybt";
            this.okeybt.Size = new System.Drawing.Size(102, 106);
            this.okeybt.TabIndex = 4;
            this.okeybt.UseVisualStyleBackColor = false;
            this.okeybt.Click += new System.EventHandler(this.okeybt_Click);
            // 
            // pubgbt
            // 
            this.pubgbt.BackgroundImage = global::Video_Oyun_Koleksiyonu_Yönetimi_proje2.Properties.Resources.images__1_;
            this.pubgbt.Location = new System.Drawing.Point(282, 87);
            this.pubgbt.Name = "pubgbt";
            this.pubgbt.Size = new System.Drawing.Size(99, 106);
            this.pubgbt.TabIndex = 2;
            this.pubgbt.UseVisualStyleBackColor = true;
            this.pubgbt.Click += new System.EventHandler(this.pubgbt_Click);
            // 
            // atessubt
            // 
            this.atessubt.BackgroundImage = global::Video_Oyun_Koleksiyonu_Yönetimi_proje2.Properties.Resources.ates_ve_su__1_;
            this.atessubt.Location = new System.Drawing.Point(154, 87);
            this.atessubt.Name = "atessubt";
            this.atessubt.Size = new System.Drawing.Size(102, 106);
            this.atessubt.TabIndex = 1;
            this.atessubt.UseVisualStyleBackColor = true;
            this.atessubt.Click += new System.EventHandler(this.atessubt_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.popmbllbt);
            this.tabPage2.Controls.Add(this.popminecraftbt);
            this.tabPage2.Controls.Add(this.popokeybt);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Popüler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // popmbllbt
            // 
            this.popmbllbt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("popmbllbt.BackgroundImage")));
            this.popmbllbt.Location = new System.Drawing.Point(540, 109);
            this.popmbllbt.Name = "popmbllbt";
            this.popmbllbt.Size = new System.Drawing.Size(216, 203);
            this.popmbllbt.TabIndex = 24;
            this.popmbllbt.UseVisualStyleBackColor = true;
            this.popmbllbt.Click += new System.EventHandler(this.popmbllbt_Click);
            // 
            // popminecraftbt
            // 
            this.popminecraftbt.BackColor = System.Drawing.Color.Transparent;
            this.popminecraftbt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("popminecraftbt.BackgroundImage")));
            this.popminecraftbt.Location = new System.Drawing.Point(287, 109);
            this.popminecraftbt.Name = "popminecraftbt";
            this.popminecraftbt.Size = new System.Drawing.Size(216, 203);
            this.popminecraftbt.TabIndex = 23;
            this.popminecraftbt.UseVisualStyleBackColor = false;
            this.popminecraftbt.Click += new System.EventHandler(this.popminecraftbt_Click);
            // 
            // popokeybt
            // 
            this.popokeybt.BackColor = System.Drawing.Color.Transparent;
            this.popokeybt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("popokeybt.BackgroundImage")));
            this.popokeybt.Location = new System.Drawing.Point(35, 109);
            this.popokeybt.Name = "popokeybt";
            this.popokeybt.Size = new System.Drawing.Size(216, 203);
            this.popokeybt.TabIndex = 5;
            this.popokeybt.UseVisualStyleBackColor = false;
            this.popokeybt.Click += new System.EventHandler(this.popokeybt_Click);
            // 
            // oyunlarTableAdapter
            // 
            this.oyunlarTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(668, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Pokemon";
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(699, 28);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(75, 23);
            this.geri.TabIndex = 32;
            this.geri.Text = "Geri";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(842, 579);
            this.Controls.Add(this.tabControl1);
            this.Name = "anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyunlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videooyunDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button pubgbt;
        private System.Windows.Forms.Button atessubt;
        private System.Windows.Forms.Button okeybt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pokemonbt;
        private System.Windows.Forms.Button mariobt;
        private System.Windows.Forms.Button minecraftbt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button popmbllbt;
        private System.Windows.Forms.Button popminecraftbt;
        private System.Windows.Forms.Button popokeybt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private videooyunDataSet videooyunDataSet;
        private System.Windows.Forms.BindingSource oyunlarBindingSource;
        private videooyunDataSetTableAdapters.oyunlarTableAdapter oyunlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oyunidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oyunadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oyunturuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oyunboyutuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button geri;
    }
}