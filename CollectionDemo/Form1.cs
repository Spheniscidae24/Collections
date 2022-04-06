using CollectionDemo.DataAccess;
using CollectionDemo.Models;

namespace CollectionDemo
{
    public partial class Form1 : Form
    {
        VeriErižim _veriErisim;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _veriErisim = new VeriErižim();
            List<Ogrenci> ogrenciler = _veriErisim.Oku();
            dgvOgrenciler.DataSource = ogrenciler;
        }
    }
}