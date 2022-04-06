using CollectionDemo.DataAccess;
using CollectionDemo.Models;

namespace CollectionDemo
{
    public partial class Form1 : Form
    {
        VeriEri�im _veriErisim;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _veriErisim = new VeriEri�im();
            List<Ogrenci> ogrenciler = _veriErisim.Oku();
            dgvOgrenciler.DataSource = ogrenciler;
        }
    }
}