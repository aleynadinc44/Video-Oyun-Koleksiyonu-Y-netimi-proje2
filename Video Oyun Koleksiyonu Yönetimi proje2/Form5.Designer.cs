namespace Video_Oyun_Koleksiyonu_Yönetimi_proje2
{
    partial class kullanici
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
            this.label2 = new System.Windows.Forms.Label();
            this.Adıtxt = new System.Windows.Forms.TextBox();
            this.turucombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boyuttxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oyunidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oyunadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oyunturuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oyunboyutuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oyunlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videooyunDataSet = new Video_Oyun_Koleksiyonu_Yönetimi_proje2.videooyunDataSet();
            this.oyuneklebt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adsoyadtxt = new System.Windows.Forms.RichTextBox();
            this.oyunlarTableAdapter = new Video_Oyun_Koleksiyonu_Yönetimi_proje2.videooyunDataSetTableAdapters.oyunlarTableAdapter();
            this.geribt = new System.Windows.Forms.Button();
            this.anasayfabt = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyunlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videooyunDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Oyun Adı";
            // 
            // Adıtxt
            // 
            this.Adıtxt.Location = new System.Drawing.Point(214, 105);
            this.Adıtxt.Name = "Adıtxt";
            this.Adıtxt.Size = new System.Drawing.Size(100, 22);
            this.Adıtxt.TabIndex = 3;
            // 
            // turucombo
            // 
            this.turucombo.FormattingEnabled = true;
            this.turucombo.Items.AddRange(new object[] {
            "Macera",
            "Aksiyon",
            "Hayatta Kalma",
            "Chill"});
            this.turucombo.Location = new System.Drawing.Point(214, 164);
            this.turucombo.Name = "turucombo";
            this.turucombo.Size = new System.Drawing.Size(121, 24);
            this.turucombo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(91, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 48);
            this.label3.TabIndex = 5;
            this.label3.Text = "Oyun Türü\r\n\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(69, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Oyun Boyutu";
            // 
            // boyuttxt
            // 
            this.boyuttxt.Location = new System.Drawing.Point(214, 239);
            this.boyuttxt.Name = "boyuttxt";
            this.boyuttxt.Size = new System.Drawing.Size(121, 22);
            this.boyuttxt.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oyunidDataGridViewTextBoxColumn,
            this.oyunadiDataGridViewTextBoxColumn,
            this.oyunturuDataGridViewTextBoxColumn,
            this.oyunboyutuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oyunlarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(732, 155);
            this.dataGridView1.TabIndex = 0;
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
            // oyuneklebt
            // 
            this.oyuneklebt.Location = new System.Drawing.Point(575, 216);
            this.oyuneklebt.Name = "oyuneklebt";
            this.oyuneklebt.Size = new System.Drawing.Size(109, 45);
            this.oyuneklebt.TabIndex = 8;
            this.oyuneklebt.Text = "Oyunu Ekle";
            this.oyuneklebt.UseVisualStyleBackColor = true;
            this.oyuneklebt.Click += new System.EventHandler(this.oyuneklebt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(312, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "HOŞGELDİNİZ";
            // 
            // adsoyadtxt
            // 
            this.adsoyadtxt.Location = new System.Drawing.Point(109, 34);
            this.adsoyadtxt.Name = "adsoyadtxt";
            this.adsoyadtxt.Size = new System.Drawing.Size(158, 26);
            this.adsoyadtxt.TabIndex = 10;
            this.adsoyadtxt.Text = "";
            // 
            // oyunlarTableAdapter
            // 
            this.oyunlarTableAdapter.ClearBeforeFill = true;
            // 
            // geribt
            // 
            this.geribt.Location = new System.Drawing.Point(575, 129);
            this.geribt.Name = "geribt";
            this.geribt.Size = new System.Drawing.Size(109, 45);
            this.geribt.TabIndex = 11;
            this.geribt.Text = "Geri";
            this.geribt.UseVisualStyleBackColor = true;
            this.geribt.Click += new System.EventHandler(this.geribt_Click);
            // 
            // anasayfabt
            // 
            this.anasayfabt.Location = new System.Drawing.Point(575, 48);
            this.anasayfabt.Name = "anasayfabt";
            this.anasayfabt.Size = new System.Drawing.Size(109, 45);
            this.anasayfabt.TabIndex = 12;
            this.anasayfabt.Text = "Anasayfa";
            this.anasayfabt.UseVisualStyleBackColor = true;
            this.anasayfabt.Click += new System.EventHandler(this.anasayfabt_Click);
            // 
            // kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.anasayfabt);
            this.Controls.Add(this.geribt);
            this.Controls.Add(this.adsoyadtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oyuneklebt);
            this.Controls.Add(this.boyuttxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.turucombo);
            this.Controls.Add(this.Adıtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyunlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videooyunDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Adıtxt;
        private System.Windows.Forms.ComboBox turucombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boyuttxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button oyuneklebt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox adsoyadtxt;
        private videooyunDataSet videooyunDataSet;
        private System.Windows.Forms.BindingSource oyunlarBindingSource;
        private videooyunDataSetTableAdapters.oyunlarTableAdapter oyunlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oyunidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oyunadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oyunturuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oyunboyutuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button geribt;
        private System.Windows.Forms.Button anasayfabt;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}