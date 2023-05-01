namespace Bookcase_Project
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKitapid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitaplıkDataSet = new Bookcase_Project.KitaplıkDataSet();
            this.TxtKitapAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtYazar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSayfa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RdbKullanilmis = new System.Windows.Forms.RadioButton();
            this.RdbYeni = new System.Windows.Forms.RadioButton();
            this.CmbTur = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.kitaplarTableAdapter = new Bookcase_Project.KitaplıkDataSetTableAdapters.KitaplarTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kitaplikDataSet1 = new Bookcase_Project.KitaplikDataSet1();
            this.kitaplarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kitaplarTableAdapter1 = new Bookcase_Project.KitaplikDataSet1TableAdapters.KitaplarTableAdapter();
            this.kitapidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TxtKitapBul = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnBul = new System.Windows.Forms.Button();
            this.BtnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplıkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplikDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap id:";
            // 
            // TxtKitapid
            // 
            this.TxtKitapid.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TxtKitapid.Enabled = false;
            this.TxtKitapid.Location = new System.Drawing.Point(141, 21);
            this.TxtKitapid.Name = "TxtKitapid";
            this.TxtKitapid.Size = new System.Drawing.Size(228, 34);
            this.TxtKitapid.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapidDataGridViewTextBoxColumn,
            this.kitapAdDataGridViewTextBoxColumn,
            this.yazarDataGridViewTextBoxColumn,
            this.turDataGridViewTextBoxColumn,
            this.sayfaDataGridViewTextBoxColumn,
            this.durumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.kitaplarBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(24, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(813, 230);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // kitaplarBindingSource
            // 
            this.kitaplarBindingSource.DataMember = "Kitaplar";
            this.kitaplarBindingSource.DataSource = this.kitaplıkDataSet;
            // 
            // kitaplıkDataSet
            // 
            this.kitaplıkDataSet.DataSetName = "KitaplıkDataSet";
            this.kitaplıkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtKitapAd
            // 
            this.TxtKitapAd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TxtKitapAd.Location = new System.Drawing.Point(141, 61);
            this.TxtKitapAd.Name = "TxtKitapAd";
            this.TxtKitapAd.Size = new System.Drawing.Size(228, 34);
            this.TxtKitapAd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(26, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap Ad:";
            // 
            // TxtYazar
            // 
            this.TxtYazar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TxtYazar.Location = new System.Drawing.Point(141, 101);
            this.TxtYazar.Name = "TxtYazar";
            this.TxtYazar.Size = new System.Drawing.Size(228, 34);
            this.TxtYazar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(59, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yazar:";
            // 
            // TxtSayfa
            // 
            this.TxtSayfa.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TxtSayfa.Location = new System.Drawing.Point(141, 182);
            this.TxtSayfa.Name = "TxtSayfa";
            this.TxtSayfa.Size = new System.Drawing.Size(228, 34);
            this.TxtSayfa.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(61, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sayfa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(80, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tür:";
            // 
            // RdbKullanilmis
            // 
            this.RdbKullanilmis.AutoSize = true;
            this.RdbKullanilmis.Location = new System.Drawing.Point(141, 231);
            this.RdbKullanilmis.Name = "RdbKullanilmis";
            this.RdbKullanilmis.Size = new System.Drawing.Size(120, 31);
            this.RdbKullanilmis.TabIndex = 11;
            this.RdbKullanilmis.TabStop = true;
            this.RdbKullanilmis.Text = "İkinci El";
            this.RdbKullanilmis.UseVisualStyleBackColor = true;
            this.RdbKullanilmis.CheckedChanged += new System.EventHandler(this.RdbKullanilmis_CheckedChanged);
            // 
            // RdbYeni
            // 
            this.RdbYeni.AutoSize = true;
            this.RdbYeni.Location = new System.Drawing.Point(290, 231);
            this.RdbYeni.Name = "RdbYeni";
            this.RdbYeni.Size = new System.Drawing.Size(79, 31);
            this.RdbYeni.TabIndex = 12;
            this.RdbYeni.TabStop = true;
            this.RdbYeni.Text = "Yeni";
            this.RdbYeni.UseVisualStyleBackColor = true;
            this.RdbYeni.CheckedChanged += new System.EventHandler(this.RdbYeni_CheckedChanged);
            // 
            // CmbTur
            // 
            this.CmbTur.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTur.FormattingEnabled = true;
            this.CmbTur.Items.AddRange(new object[] {
            "Seçim Yapınız",
            "Hikaye ",
            "Roman ",
            "Şiir",
            "Tiyatro"});
            this.CmbTur.Location = new System.Drawing.Point(141, 141);
            this.CmbTur.Name = "CmbTur";
            this.CmbTur.Size = new System.Drawing.Size(228, 35);
            this.CmbTur.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(44, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "Durum:";
            // 
            // BtnListele
            // 
            this.BtnListele.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnListele.ForeColor = System.Drawing.Color.Maroon;
            this.BtnListele.Location = new System.Drawing.Point(462, 28);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(150, 42);
            this.BtnListele.TabIndex = 15;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = false;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnKaydet.ForeColor = System.Drawing.Color.Maroon;
            this.BtnKaydet.Location = new System.Drawing.Point(462, 78);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(150, 42);
            this.BtnKaydet.TabIndex = 16;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSil.ForeColor = System.Drawing.Color.Maroon;
            this.BtnSil.Location = new System.Drawing.Point(462, 126);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(150, 42);
            this.BtnSil.TabIndex = 17;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnGuncelle.ForeColor = System.Drawing.Color.Maroon;
            this.BtnGuncelle.Location = new System.Drawing.Point(462, 174);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(150, 42);
            this.BtnGuncelle.TabIndex = 18;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // kitaplarTableAdapter
            // 
            this.kitaplarTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bookcase_Project.Properties.Resources.kitap_hareketli_resim_0019;
            this.pictureBox1.Location = new System.Drawing.Point(660, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // kitaplikDataSet1
            // 
            this.kitaplikDataSet1.DataSetName = "KitaplikDataSet1";
            this.kitaplikDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitaplarBindingSource1
            // 
            this.kitaplarBindingSource1.DataMember = "Kitaplar";
            this.kitaplarBindingSource1.DataSource = this.kitaplikDataSet1;
            // 
            // kitaplarTableAdapter1
            // 
            this.kitaplarTableAdapter1.ClearBeforeFill = true;
            // 
            // kitapidDataGridViewTextBoxColumn
            // 
            this.kitapidDataGridViewTextBoxColumn.DataPropertyName = "Kitapid";
            this.kitapidDataGridViewTextBoxColumn.HeaderText = "Kitapid";
            this.kitapidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapidDataGridViewTextBoxColumn.Name = "kitapidDataGridViewTextBoxColumn";
            // 
            // kitapAdDataGridViewTextBoxColumn
            // 
            this.kitapAdDataGridViewTextBoxColumn.DataPropertyName = "KitapAd";
            this.kitapAdDataGridViewTextBoxColumn.HeaderText = "KitapAd";
            this.kitapAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapAdDataGridViewTextBoxColumn.Name = "kitapAdDataGridViewTextBoxColumn";
            // 
            // yazarDataGridViewTextBoxColumn
            // 
            this.yazarDataGridViewTextBoxColumn.DataPropertyName = "Yazar";
            this.yazarDataGridViewTextBoxColumn.HeaderText = "Yazar";
            this.yazarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yazarDataGridViewTextBoxColumn.Name = "yazarDataGridViewTextBoxColumn";
            // 
            // turDataGridViewTextBoxColumn
            // 
            this.turDataGridViewTextBoxColumn.DataPropertyName = "Tur";
            this.turDataGridViewTextBoxColumn.HeaderText = "Tur";
            this.turDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.turDataGridViewTextBoxColumn.Name = "turDataGridViewTextBoxColumn";
            // 
            // sayfaDataGridViewTextBoxColumn
            // 
            this.sayfaDataGridViewTextBoxColumn.DataPropertyName = "Sayfa";
            this.sayfaDataGridViewTextBoxColumn.HeaderText = "Sayfa";
            this.sayfaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sayfaDataGridViewTextBoxColumn.Name = "sayfaDataGridViewTextBoxColumn";
            // 
            // durumDataGridViewCheckBoxColumn
            // 
            this.durumDataGridViewCheckBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewCheckBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.durumDataGridViewCheckBoxColumn.Name = "durumDataGridViewCheckBoxColumn";
            // 
            // TxtKitapBul
            // 
            this.TxtKitapBul.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TxtKitapBul.Location = new System.Drawing.Point(586, 225);
            this.TxtKitapBul.Name = "TxtKitapBul";
            this.TxtKitapBul.Size = new System.Drawing.Size(251, 34);
            this.TxtKitapBul.TabIndex = 21;
            this.TxtKitapBul.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtKitapBul_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(464, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 27);
            this.label7.TabIndex = 20;
            this.label7.Text = "Kitap Adı:";
            // 
            // BtnBul
            // 
            this.BtnBul.Location = new System.Drawing.Point(585, 265);
            this.BtnBul.Name = "BtnBul";
            this.BtnBul.Size = new System.Drawing.Size(123, 38);
            this.BtnBul.TabIndex = 22;
            this.BtnBul.Text = "Bul";
            this.BtnBul.UseVisualStyleBackColor = true;
            this.BtnBul.Click += new System.EventHandler(this.BtnBul_Click);
            // 
            // BtnAra
            // 
            this.BtnAra.Location = new System.Drawing.Point(714, 265);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(123, 38);
            this.BtnAra.TabIndex = 23;
            this.BtnAra.Text = "Ara";
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(835, 564);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.BtnBul);
            this.Controls.Add(this.TxtKitapBul);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmbTur);
            this.Controls.Add(this.RdbYeni);
            this.Controls.Add(this.RdbKullanilmis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSayfa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtYazar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtKitapAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtKitapid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplıkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplikDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKitapid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtKitapAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtYazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSayfa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RdbKullanilmis;
        private System.Windows.Forms.RadioButton RdbYeni;
        private System.Windows.Forms.ComboBox CmbTur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private KitaplıkDataSet kitaplıkDataSet;
        private System.Windows.Forms.BindingSource kitaplarBindingSource;
        private KitaplıkDataSetTableAdapters.KitaplarTableAdapter kitaplarTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private KitaplikDataSet1 kitaplikDataSet1;
        private System.Windows.Forms.BindingSource kitaplarBindingSource1;
        private KitaplikDataSet1TableAdapters.KitaplarTableAdapter kitaplarTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn durumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox TxtKitapBul;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnBul;
        private System.Windows.Forms.Button BtnAra;
    }
}

