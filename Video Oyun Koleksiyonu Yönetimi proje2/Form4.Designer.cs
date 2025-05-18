namespace Video_Oyun_Koleksiyonu_Yönetimi_proje2
{
    partial class yorum
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oyunaditxt = new System.Windows.Forms.TextBox();
            this.puancombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yorumeklebt = new System.Windows.Forms.Button();
            this.videooyunDataSet = new Video_Oyun_Koleksiyonu_Yönetimi_proje2.videooyunDataSet();
            this.oyunYorumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oyunYorumTableAdapter = new Video_Oyun_Koleksiyonu_Yönetimi_proje2.videooyunDataSetTableAdapters.OyunYorumTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oyunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yorumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geri = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.yorumtxt = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videooyunDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyunYorumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.oyunAdiDataGridViewTextBoxColumn,
            this.puanDataGridViewTextBoxColumn,
            this.yorumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oyunYorumBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 419);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(877, 233);
            this.dataGridView1.TabIndex = 1;
            // 
            // oyunaditxt
            // 
            this.oyunaditxt.Location = new System.Drawing.Point(306, 117);
            this.oyunaditxt.Name = "oyunaditxt";
            this.oyunaditxt.Size = new System.Drawing.Size(154, 22);
            this.oyunaditxt.TabIndex = 2;
            // 
            // puancombo
            // 
            this.puancombo.FormattingEnabled = true;
            this.puancombo.Items.AddRange(new object[] {
            "⭐⭐⭐⭐⭐",
            "⭐⭐⭐⭐",
            "⭐⭐⭐",
            "⭐⭐",
            "⭐"});
            this.puancombo.Location = new System.Drawing.Point(306, 183);
            this.puancombo.Name = "puancombo";
            this.puancombo.Size = new System.Drawing.Size(154, 24);
            this.puancombo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(154, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Oyun Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(193, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Puan :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(179, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yorum :";
            // 
            // yorumeklebt
            // 
            this.yorumeklebt.Location = new System.Drawing.Point(229, 327);
            this.yorumeklebt.Name = "yorumeklebt";
            this.yorumeklebt.Size = new System.Drawing.Size(154, 55);
            this.yorumeklebt.TabIndex = 7;
            this.yorumeklebt.Text = "Yorum Ekle";
            this.yorumeklebt.UseVisualStyleBackColor = true;
            this.yorumeklebt.Click += new System.EventHandler(this.yorumeklebt_Click);
            // 
            // videooyunDataSet
            // 
            this.videooyunDataSet.DataSetName = "videooyunDataSet";
            this.videooyunDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oyunYorumBindingSource
            // 
            this.oyunYorumBindingSource.DataMember = "OyunYorum";
            this.oyunYorumBindingSource.DataSource = this.videooyunDataSet;
            // 
            // oyunYorumTableAdapter
            // 
            this.oyunYorumTableAdapter.ClearBeforeFill = true;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oyunAdiDataGridViewTextBoxColumn
            // 
            this.oyunAdiDataGridViewTextBoxColumn.DataPropertyName = "OyunAdi";
            this.oyunAdiDataGridViewTextBoxColumn.HeaderText = "OyunAdi";
            this.oyunAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oyunAdiDataGridViewTextBoxColumn.Name = "oyunAdiDataGridViewTextBoxColumn";
            // 
            // puanDataGridViewTextBoxColumn
            // 
            this.puanDataGridViewTextBoxColumn.DataPropertyName = "Puan";
            this.puanDataGridViewTextBoxColumn.HeaderText = "Puan";
            this.puanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.puanDataGridViewTextBoxColumn.Name = "puanDataGridViewTextBoxColumn";
            // 
            // yorumDataGridViewTextBoxColumn
            // 
            this.yorumDataGridViewTextBoxColumn.DataPropertyName = "Yorum";
            this.yorumDataGridViewTextBoxColumn.HeaderText = "Yorum";
            this.yorumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yorumDataGridViewTextBoxColumn.Name = "yorumDataGridViewTextBoxColumn";
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(466, 327);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(154, 55);
            this.geri.TabIndex = 8;
            this.geri.Text = "Geri";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // yorumtxt
            // 
            this.yorumtxt.Location = new System.Drawing.Point(306, 243);
            this.yorumtxt.Name = "yorumtxt";
            this.yorumtxt.Size = new System.Drawing.Size(395, 60);
            this.yorumtxt.TabIndex = 9;
            this.yorumtxt.Text = "";
            // 
            // yorum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(972, 681);
            this.Controls.Add(this.yorumtxt);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.yorumeklebt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.puancombo);
            this.Controls.Add(this.oyunaditxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "yorum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yorumlar";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videooyunDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyunYorumBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox oyunaditxt;
        private System.Windows.Forms.ComboBox puancombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button yorumeklebt;
        private videooyunDataSet videooyunDataSet;
        private System.Windows.Forms.BindingSource oyunYorumBindingSource;
        private videooyunDataSetTableAdapters.OyunYorumTableAdapter oyunYorumTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oyunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yorumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox yorumtxt;
    }
}