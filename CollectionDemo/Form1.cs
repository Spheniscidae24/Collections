using CollectionDemo.DataAccess;
using CollectionDemo.Enum;
using CollectionDemo.Models;

namespace CollectionDemo
{
    public partial class Form1 : Form
    {
        VeriEriþim _veriErisim;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _veriErisim = new VeriEriþim();
            List<Ogrenci> ogrenciler = _veriErisim.Oku();
            dgvOgrenciler.DataSource = ogrenciler;
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAdi.Text))
            {
                MessageBox.Show("Adý boþ olamaz!");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbSoyadi.Text))
            {
                MessageBox.Show("Soyadý boþ olamaz!");
                return;
            }
            double notOrtalamasi;
            if (!double.TryParse(tbNotOrtalamasi.Text.Trim(), out notOrtalamasi))
            {
                MessageBox.Show("Not ortalamasý sayýsal olmalýdýr!");
                return;
            }


            Ogrenci ogrenci = new Ogrenci()
            {
                Adi = tbAdi.Text.Trim(),
                Soyadi = tbSoyadi.Text.Trim(),
                NotOrtalamasi = notOrtalamasi,
                DogumTarihi = dtDogumTarihi.Value,
                MezunMu = cbMezun.Checked,
                Cinsiyet = rbKadin.Checked ? Cinsiyet.Kadýn : Cinsiyet.Erkek
            };

            _veriErisim.Ekle(ogrenci);

            dgvOgrenciler.DataSource = null;
            List<Ogrenci> ogrenciler = _veriErisim.Oku();
            dgvOgrenciler.DataSource = ogrenciler;

            MessageBox.Show("Öðrenci kaydedildi.", "Oley be!");

            tbAdi.Text = "";
            tbSoyadi.Text = "";
            dtDogumTarihi.Value = DateTime.Now;
            rbKadin.Checked = true;
            cbMezun.Checked = true;
            tbNotOrtalamasi.Clear();
        }

        private void lbSil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int id = Convert.ToInt32(nudSil.Value);
            _veriErisim.Sil(id);
            dgvOgrenciler.DataSource = null;
            List<Ogrenci> ogrenciler = _veriErisim.Oku();
            dgvOgrenciler.DataSource = ogrenciler;
            MessageBox.Show("Öðrenci silindi", "Ah be...");
        }

        private void bGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAdiG.Text))
            {
                MessageBox.Show("Adý boþ olamaz!");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbSoyadiG.Text))
            {
                MessageBox.Show("Soyadý boþ olamaz!");
                return;
            }
            double notOrtalamasi;
            if (!double.TryParse(tbNotOrtalamasiG.Text.Trim(), out notOrtalamasi))
            {
                MessageBox.Show("Not ortalamasý sayýsal olmalýdýr!");
                return;
            }

            Ogrenci ogrenci = new Ogrenci()
            {
                Adi = tbAdiG.Text.Trim(),
                Soyadi = tbSoyadiG.Text.Trim(),
                DogumTarihi = dtDogumTarihiG.Value,
                MezunMu = cbMezunG.Checked,
                NotOrtalamasi = notOrtalamasi,
                Cinsiyet = rbKadinG.Checked ? Cinsiyet.Kadýn : Cinsiyet.Erkek
            };
            int id = Convert.ToInt32(nudIdG.Value);
            _veriErisim.Guncelle(ogrenci, id);

            dgvOgrenciler.DataSource = null;
            List<Ogrenci> ogrenciler = _veriErisim.Oku();
            dgvOgrenciler.DataSource = ogrenciler;

            MessageBox.Show("Öðrenci güncellendi.", "Yes be.");
        }

        private void lbGetir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int id = Convert.ToInt32(nudSil.Value);
            Ogrenci ogrenci = _veriErisim.Oku(id);
            MessageBox.Show($"Adý: {ogrenci.Adi}\r\n" + $"Soyadý: {ogrenci.Soyadi}\r\n" + $"Doðum tarihi: {ogrenci.DogumTarihi.ToShortDateString()}" + $"Cinsiyet: {ogrenci.Cinsiyet}"
                + $"Mezun: {(ogrenci.MezunMu ? "evet" : "hayýr")}" + $"Not ortalamasý: {ogrenci.NotOrtalamasi}");
        }
    }
}