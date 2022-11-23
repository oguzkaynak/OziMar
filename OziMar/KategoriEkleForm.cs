using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
namespace OziMar
{
    public partial class KategoriEkleForm : Form
    {
        DataModel dm = new DataModel();
        public KategoriEkleForm()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Kategori k = new Kategori();
            k.Isim = tb_İsim.Text;
            k.Aciklama = tb_Açıklama.Text;
            if (dm.KategoriEkle(k))
            {
                MessageBox.Show("Başarılı");
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
            dataGridView1.DataSource = dm.kategorilistele();
        }

        private void KategoriEkleForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dm.kategorilistele();
        }
    }
}
