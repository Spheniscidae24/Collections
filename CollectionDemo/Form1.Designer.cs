namespace CollectionDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOgrenciler = new System.Windows.Forms.DataGridView();
            this.gbYeniOgrenci = new System.Windows.Forms.GroupBox();
            this.bKaydet = new System.Windows.Forms.Button();
            this.tbNotOrtalamasi = new System.Windows.Forms.TextBox();
            this.cbMezun = new System.Windows.Forms.CheckBox();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.dtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.tbSoyadi = new System.Windows.Forms.TextBox();
            this.tbAdi = new System.Windows.Forms.TextBox();
            this.lNotOrtalamasi = new System.Windows.Forms.Label();
            this.lMezun = new System.Windows.Forms.Label();
            this.lCinsiyet = new System.Windows.Forms.Label();
            this.lDogumTarihi = new System.Windows.Forms.Label();
            this.lSoyadi = new System.Windows.Forms.Label();
            this.lAdi = new System.Windows.Forms.Label();
            this.gbSil = new System.Windows.Forms.GroupBox();
            this.lbSil = new System.Windows.Forms.LinkLabel();
            this.nudSil = new System.Windows.Forms.NumericUpDown();
            this.lId = new System.Windows.Forms.Label();
            this.gbGuncelle = new System.Windows.Forms.GroupBox();
            this.nudIdG = new System.Windows.Forms.NumericUpDown();
            this.bGuncelle = new System.Windows.Forms.Button();
            this.lIdG = new System.Windows.Forms.Label();
            this.tbNotOrtalamasiG = new System.Windows.Forms.TextBox();
            this.cbMezunG = new System.Windows.Forms.CheckBox();
            this.rbErkekG = new System.Windows.Forms.RadioButton();
            this.rbKadinG = new System.Windows.Forms.RadioButton();
            this.dtDogumTarihiG = new System.Windows.Forms.DateTimePicker();
            this.tbSoyadiG = new System.Windows.Forms.TextBox();
            this.tbAdiG = new System.Windows.Forms.TextBox();
            this.lNotOrtalamasiG = new System.Windows.Forms.Label();
            this.lMezunG = new System.Windows.Forms.Label();
            this.lCinsiyetG = new System.Windows.Forms.Label();
            this.lDogumTarihiG = new System.Windows.Forms.Label();
            this.lSoyadiG = new System.Windows.Forms.Label();
            this.lAdiG = new System.Windows.Forms.Label();
            this.lbGetir = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).BeginInit();
            this.gbYeniOgrenci.SuspendLayout();
            this.gbSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSil)).BeginInit();
            this.gbGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdG)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOgrenciler);
            this.groupBox1.Location = new System.Drawing.Point(35, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1146, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Listesi";
            // 
            // dgvOgrenciler
            // 
            this.dgvOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciler.Location = new System.Drawing.Point(6, 26);
            this.dgvOgrenciler.Name = "dgvOgrenciler";
            this.dgvOgrenciler.RowHeadersWidth = 51;
            this.dgvOgrenciler.RowTemplate.Height = 29;
            this.dgvOgrenciler.Size = new System.Drawing.Size(1133, 352);
            this.dgvOgrenciler.TabIndex = 0;
            // 
            // gbYeniOgrenci
            // 
            this.gbYeniOgrenci.Controls.Add(this.bKaydet);
            this.gbYeniOgrenci.Controls.Add(this.tbNotOrtalamasi);
            this.gbYeniOgrenci.Controls.Add(this.cbMezun);
            this.gbYeniOgrenci.Controls.Add(this.rbErkek);
            this.gbYeniOgrenci.Controls.Add(this.rbKadin);
            this.gbYeniOgrenci.Controls.Add(this.dtDogumTarihi);
            this.gbYeniOgrenci.Controls.Add(this.tbSoyadi);
            this.gbYeniOgrenci.Controls.Add(this.tbAdi);
            this.gbYeniOgrenci.Controls.Add(this.lNotOrtalamasi);
            this.gbYeniOgrenci.Controls.Add(this.lMezun);
            this.gbYeniOgrenci.Controls.Add(this.lCinsiyet);
            this.gbYeniOgrenci.Controls.Add(this.lDogumTarihi);
            this.gbYeniOgrenci.Controls.Add(this.lSoyadi);
            this.gbYeniOgrenci.Controls.Add(this.lAdi);
            this.gbYeniOgrenci.Location = new System.Drawing.Point(35, 437);
            this.gbYeniOgrenci.Name = "gbYeniOgrenci";
            this.gbYeniOgrenci.Size = new System.Drawing.Size(444, 268);
            this.gbYeniOgrenci.TabIndex = 1;
            this.gbYeniOgrenci.TabStop = false;
            this.gbYeniOgrenci.Text = "Yeni Öğrenci";
            // 
            // bKaydet
            // 
            this.bKaydet.Location = new System.Drawing.Point(304, 218);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(94, 29);
            this.bKaydet.TabIndex = 13;
            this.bKaydet.Text = "Kaydet";
            this.bKaydet.UseVisualStyleBackColor = true;
            this.bKaydet.Click += new System.EventHandler(this.bKaydet_Click);
            // 
            // tbNotOrtalamasi
            // 
            this.tbNotOrtalamasi.Location = new System.Drawing.Point(148, 175);
            this.tbNotOrtalamasi.Name = "tbNotOrtalamasi";
            this.tbNotOrtalamasi.Size = new System.Drawing.Size(250, 27);
            this.tbNotOrtalamasi.TabIndex = 12;
            // 
            // cbMezun
            // 
            this.cbMezun.AutoSize = true;
            this.cbMezun.Checked = true;
            this.cbMezun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMezun.Location = new System.Drawing.Point(148, 141);
            this.cbMezun.Name = "cbMezun";
            this.cbMezun.Size = new System.Drawing.Size(18, 17);
            this.cbMezun.TabIndex = 11;
            this.cbMezun.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(271, 110);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(65, 24);
            this.rbErkek.TabIndex = 10;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Checked = true;
            this.rbKadin.Location = new System.Drawing.Point(148, 110);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(68, 24);
            this.rbKadin.TabIndex = 9;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // dtDogumTarihi
            // 
            this.dtDogumTarihi.Location = new System.Drawing.Point(148, 78);
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            this.dtDogumTarihi.Size = new System.Drawing.Size(250, 27);
            this.dtDogumTarihi.TabIndex = 8;
            // 
            // tbSoyadi
            // 
            this.tbSoyadi.Location = new System.Drawing.Point(148, 49);
            this.tbSoyadi.Name = "tbSoyadi";
            this.tbSoyadi.Size = new System.Drawing.Size(250, 27);
            this.tbSoyadi.TabIndex = 7;
            // 
            // tbAdi
            // 
            this.tbAdi.Location = new System.Drawing.Point(148, 20);
            this.tbAdi.Name = "tbAdi";
            this.tbAdi.Size = new System.Drawing.Size(250, 27);
            this.tbAdi.TabIndex = 6;
            // 
            // lNotOrtalamasi
            // 
            this.lNotOrtalamasi.AutoSize = true;
            this.lNotOrtalamasi.Location = new System.Drawing.Point(21, 178);
            this.lNotOrtalamasi.Name = "lNotOrtalamasi";
            this.lNotOrtalamasi.Size = new System.Drawing.Size(110, 20);
            this.lNotOrtalamasi.TabIndex = 5;
            this.lNotOrtalamasi.Text = "Not Ortalaması";
            // 
            // lMezun
            // 
            this.lMezun.AutoSize = true;
            this.lMezun.Location = new System.Drawing.Point(21, 142);
            this.lMezun.Name = "lMezun";
            this.lMezun.Size = new System.Drawing.Size(53, 20);
            this.lMezun.TabIndex = 4;
            this.lMezun.Text = "Mezun";
            // 
            // lCinsiyet
            // 
            this.lCinsiyet.AutoSize = true;
            this.lCinsiyet.Location = new System.Drawing.Point(21, 112);
            this.lCinsiyet.Name = "lCinsiyet";
            this.lCinsiyet.Size = new System.Drawing.Size(60, 20);
            this.lCinsiyet.TabIndex = 3;
            this.lCinsiyet.Text = "Cinsiyet";
            // 
            // lDogumTarihi
            // 
            this.lDogumTarihi.AutoSize = true;
            this.lDogumTarihi.Location = new System.Drawing.Point(21, 83);
            this.lDogumTarihi.Name = "lDogumTarihi";
            this.lDogumTarihi.Size = new System.Drawing.Size(98, 20);
            this.lDogumTarihi.TabIndex = 2;
            this.lDogumTarihi.Text = "Doğum Tarihi";
            // 
            // lSoyadi
            // 
            this.lSoyadi.AutoSize = true;
            this.lSoyadi.Location = new System.Drawing.Point(21, 52);
            this.lSoyadi.Name = "lSoyadi";
            this.lSoyadi.Size = new System.Drawing.Size(54, 20);
            this.lSoyadi.TabIndex = 1;
            this.lSoyadi.Text = "Soyadı";
            // 
            // lAdi
            // 
            this.lAdi.AutoSize = true;
            this.lAdi.Location = new System.Drawing.Point(21, 23);
            this.lAdi.Name = "lAdi";
            this.lAdi.Size = new System.Drawing.Size(32, 20);
            this.lAdi.TabIndex = 0;
            this.lAdi.Text = "Adı";
            // 
            // gbSil
            // 
            this.gbSil.Controls.Add(this.lbGetir);
            this.gbSil.Controls.Add(this.lbSil);
            this.gbSil.Controls.Add(this.nudSil);
            this.gbSil.Controls.Add(this.lId);
            this.gbSil.Location = new System.Drawing.Point(485, 437);
            this.gbSil.Name = "gbSil";
            this.gbSil.Size = new System.Drawing.Size(246, 268);
            this.gbSil.TabIndex = 2;
            this.gbSil.TabStop = false;
            this.gbSil.Text = "Öğrenci Silme";
            // 
            // lbSil
            // 
            this.lbSil.AutoSize = true;
            this.lbSil.Location = new System.Drawing.Point(143, 101);
            this.lbSil.Name = "lbSil";
            this.lbSil.Size = new System.Drawing.Size(25, 20);
            this.lbSil.TabIndex = 2;
            this.lbSil.TabStop = true;
            this.lbSil.Text = "Sil";
            this.lbSil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbSil_LinkClicked);
            // 
            // nudSil
            // 
            this.nudSil.Location = new System.Drawing.Point(69, 50);
            this.nudSil.Name = "nudSil";
            this.nudSil.Size = new System.Drawing.Size(150, 27);
            this.nudSil.TabIndex = 1;
            this.nudSil.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(24, 52);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(22, 20);
            this.lId.TabIndex = 0;
            this.lId.Text = "id";
            // 
            // gbGuncelle
            // 
            this.gbGuncelle.Controls.Add(this.nudIdG);
            this.gbGuncelle.Controls.Add(this.bGuncelle);
            this.gbGuncelle.Controls.Add(this.lIdG);
            this.gbGuncelle.Controls.Add(this.tbNotOrtalamasiG);
            this.gbGuncelle.Controls.Add(this.cbMezunG);
            this.gbGuncelle.Controls.Add(this.rbErkekG);
            this.gbGuncelle.Controls.Add(this.rbKadinG);
            this.gbGuncelle.Controls.Add(this.dtDogumTarihiG);
            this.gbGuncelle.Controls.Add(this.tbSoyadiG);
            this.gbGuncelle.Controls.Add(this.tbAdiG);
            this.gbGuncelle.Controls.Add(this.lNotOrtalamasiG);
            this.gbGuncelle.Controls.Add(this.lMezunG);
            this.gbGuncelle.Controls.Add(this.lCinsiyetG);
            this.gbGuncelle.Controls.Add(this.lDogumTarihiG);
            this.gbGuncelle.Controls.Add(this.lSoyadiG);
            this.gbGuncelle.Controls.Add(this.lAdiG);
            this.gbGuncelle.Location = new System.Drawing.Point(737, 437);
            this.gbGuncelle.Name = "gbGuncelle";
            this.gbGuncelle.Size = new System.Drawing.Size(444, 268);
            this.gbGuncelle.TabIndex = 14;
            this.gbGuncelle.TabStop = false;
            this.gbGuncelle.Text = "Öğrenci Güncelleme";
            // 
            // nudIdG
            // 
            this.nudIdG.Location = new System.Drawing.Point(76, 220);
            this.nudIdG.Name = "nudIdG";
            this.nudIdG.Size = new System.Drawing.Size(150, 27);
            this.nudIdG.TabIndex = 4;
            this.nudIdG.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bGuncelle
            // 
            this.bGuncelle.Location = new System.Drawing.Point(304, 218);
            this.bGuncelle.Name = "bGuncelle";
            this.bGuncelle.Size = new System.Drawing.Size(94, 29);
            this.bGuncelle.TabIndex = 13;
            this.bGuncelle.Text = "Güncelle";
            this.bGuncelle.UseVisualStyleBackColor = true;
            this.bGuncelle.Click += new System.EventHandler(this.bGuncelle_Click);
            // 
            // lIdG
            // 
            this.lIdG.AutoSize = true;
            this.lIdG.Location = new System.Drawing.Point(31, 222);
            this.lIdG.Name = "lIdG";
            this.lIdG.Size = new System.Drawing.Size(22, 20);
            this.lIdG.TabIndex = 3;
            this.lIdG.Text = "id";
            // 
            // tbNotOrtalamasiG
            // 
            this.tbNotOrtalamasiG.Location = new System.Drawing.Point(148, 175);
            this.tbNotOrtalamasiG.Name = "tbNotOrtalamasiG";
            this.tbNotOrtalamasiG.Size = new System.Drawing.Size(250, 27);
            this.tbNotOrtalamasiG.TabIndex = 12;
            // 
            // cbMezunG
            // 
            this.cbMezunG.AutoSize = true;
            this.cbMezunG.Checked = true;
            this.cbMezunG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMezunG.Location = new System.Drawing.Point(148, 141);
            this.cbMezunG.Name = "cbMezunG";
            this.cbMezunG.Size = new System.Drawing.Size(18, 17);
            this.cbMezunG.TabIndex = 11;
            this.cbMezunG.UseVisualStyleBackColor = true;
            // 
            // rbErkekG
            // 
            this.rbErkekG.AutoSize = true;
            this.rbErkekG.Location = new System.Drawing.Point(271, 110);
            this.rbErkekG.Name = "rbErkekG";
            this.rbErkekG.Size = new System.Drawing.Size(65, 24);
            this.rbErkekG.TabIndex = 10;
            this.rbErkekG.Text = "Erkek";
            this.rbErkekG.UseVisualStyleBackColor = true;
            // 
            // rbKadinG
            // 
            this.rbKadinG.AutoSize = true;
            this.rbKadinG.Checked = true;
            this.rbKadinG.Location = new System.Drawing.Point(148, 110);
            this.rbKadinG.Name = "rbKadinG";
            this.rbKadinG.Size = new System.Drawing.Size(68, 24);
            this.rbKadinG.TabIndex = 9;
            this.rbKadinG.TabStop = true;
            this.rbKadinG.Text = "Kadın";
            this.rbKadinG.UseVisualStyleBackColor = true;
            // 
            // dtDogumTarihiG
            // 
            this.dtDogumTarihiG.Location = new System.Drawing.Point(148, 78);
            this.dtDogumTarihiG.Name = "dtDogumTarihiG";
            this.dtDogumTarihiG.Size = new System.Drawing.Size(250, 27);
            this.dtDogumTarihiG.TabIndex = 8;
            // 
            // tbSoyadiG
            // 
            this.tbSoyadiG.Location = new System.Drawing.Point(148, 49);
            this.tbSoyadiG.Name = "tbSoyadiG";
            this.tbSoyadiG.Size = new System.Drawing.Size(250, 27);
            this.tbSoyadiG.TabIndex = 7;
            // 
            // tbAdiG
            // 
            this.tbAdiG.Location = new System.Drawing.Point(148, 20);
            this.tbAdiG.Name = "tbAdiG";
            this.tbAdiG.Size = new System.Drawing.Size(250, 27);
            this.tbAdiG.TabIndex = 6;
            // 
            // lNotOrtalamasiG
            // 
            this.lNotOrtalamasiG.AutoSize = true;
            this.lNotOrtalamasiG.Location = new System.Drawing.Point(21, 178);
            this.lNotOrtalamasiG.Name = "lNotOrtalamasiG";
            this.lNotOrtalamasiG.Size = new System.Drawing.Size(110, 20);
            this.lNotOrtalamasiG.TabIndex = 5;
            this.lNotOrtalamasiG.Text = "Not Ortalaması";
            // 
            // lMezunG
            // 
            this.lMezunG.AutoSize = true;
            this.lMezunG.Location = new System.Drawing.Point(21, 142);
            this.lMezunG.Name = "lMezunG";
            this.lMezunG.Size = new System.Drawing.Size(53, 20);
            this.lMezunG.TabIndex = 4;
            this.lMezunG.Text = "Mezun";
            // 
            // lCinsiyetG
            // 
            this.lCinsiyetG.AutoSize = true;
            this.lCinsiyetG.Location = new System.Drawing.Point(21, 112);
            this.lCinsiyetG.Name = "lCinsiyetG";
            this.lCinsiyetG.Size = new System.Drawing.Size(60, 20);
            this.lCinsiyetG.TabIndex = 3;
            this.lCinsiyetG.Text = "Cinsiyet";
            // 
            // lDogumTarihiG
            // 
            this.lDogumTarihiG.AutoSize = true;
            this.lDogumTarihiG.Location = new System.Drawing.Point(21, 83);
            this.lDogumTarihiG.Name = "lDogumTarihiG";
            this.lDogumTarihiG.Size = new System.Drawing.Size(98, 20);
            this.lDogumTarihiG.TabIndex = 2;
            this.lDogumTarihiG.Text = "Doğum Tarihi";
            // 
            // lSoyadiG
            // 
            this.lSoyadiG.AutoSize = true;
            this.lSoyadiG.Location = new System.Drawing.Point(21, 52);
            this.lSoyadiG.Name = "lSoyadiG";
            this.lSoyadiG.Size = new System.Drawing.Size(54, 20);
            this.lSoyadiG.TabIndex = 1;
            this.lSoyadiG.Text = "Soyadı";
            // 
            // lAdiG
            // 
            this.lAdiG.AutoSize = true;
            this.lAdiG.Location = new System.Drawing.Point(21, 23);
            this.lAdiG.Name = "lAdiG";
            this.lAdiG.Size = new System.Drawing.Size(32, 20);
            this.lAdiG.TabIndex = 0;
            this.lAdiG.Text = "Adı";
            // 
            // lbGetir
            // 
            this.lbGetir.AutoSize = true;
            this.lbGetir.Location = new System.Drawing.Point(35, 101);
            this.lbGetir.Name = "lbGetir";
            this.lbGetir.Size = new System.Drawing.Size(41, 20);
            this.lbGetir.TabIndex = 3;
            this.lbGetir.TabStop = true;
            this.lbGetir.Text = "Getir";
            this.lbGetir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbGetir_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 728);
            this.Controls.Add(this.gbGuncelle);
            this.Controls.Add(this.gbSil);
            this.Controls.Add(this.gbYeniOgrenci);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Öğrenci App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).EndInit();
            this.gbYeniOgrenci.ResumeLayout(false);
            this.gbYeniOgrenci.PerformLayout();
            this.gbSil.ResumeLayout(false);
            this.gbSil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSil)).EndInit();
            this.gbGuncelle.ResumeLayout(false);
            this.gbGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvOgrenciler;
        private GroupBox gbYeniOgrenci;
        private Button bKaydet;
        private TextBox tbNotOrtalamasi;
        private CheckBox cbMezun;
        private RadioButton rbErkek;
        private RadioButton rbKadin;
        private DateTimePicker dtDogumTarihi;
        private TextBox tbSoyadi;
        private TextBox tbAdi;
        private Label lNotOrtalamasi;
        private Label lMezun;
        private Label lCinsiyet;
        private Label lDogumTarihi;
        private Label lSoyadi;
        private Label lAdi;
        private GroupBox gbSil;
        private LinkLabel lbSil;
        private NumericUpDown nudSil;
        private Label lId;
        private GroupBox gbGuncelle;
        private Button bGuncelle;
        private TextBox tbNotOrtalamasiG;
        private CheckBox cbMezunG;
        private RadioButton rbErkekG;
        private RadioButton rbKadinG;
        private DateTimePicker dtDogumTarihiG;
        private TextBox tbSoyadiG;
        private TextBox tbAdiG;
        private Label lNotOrtalamasiG;
        private Label lMezunG;
        private Label lCinsiyetG;
        private Label lDogumTarihiG;
        private Label lSoyadiG;
        private Label lAdiG;
        private NumericUpDown nudIdG;
        private Label lIdG;
        private LinkLabel lbGetir;
    }
}