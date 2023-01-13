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
        int id;
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

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //MessageBox.Show("x="+e.x+"Y="+e.Y);
                int satır = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (satır !=-1)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[satır].Selected = true;
                    id = Convert.ToInt32(dataGridView1.Rows[satır].Cells["ID"].Value);
                    contextMenuStrip1.Show(dataGridView1, e.X, e.Y);
                    
                }
            }
        }

        private void TSMI_duzenle_Click(object sender, EventArgs e)
        {
            Kategori c = dm.GetCategory(id);
            tb_ID.Text = c.ID.ToString();
            tb_İsim.Text = c.Isim;
            tb_Açıklama.Text = c.Aciklama;
            btn_Ekle.Visible = false;
            btn_guncelle.Visible = true;

        }

        private void TSMI_sil_Click(object sender, EventArgs e)
        {
            if (!dm.RemooveCategory(id))
            {
                MessageBox.Show("Silme İşlemi Başarısız");
            }
            dataGridView1.DataSource = dm.kategorilistele();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            Kategori c = new Kategori();
            c.ID = Convert.ToInt32(tb_ID.Text);
            c.Isim = tb_İsim.Text;
            c.Aciklama = tb_Açıklama.Text;
            if (!dm.UpdateCategory(c))
            {
                MessageBox.Show("Güncelleme İşlemi Başarısız");
            }
            dataGridView1.DataSource = dm.kategorilistele();
            tb_ID.Text = tb_İsim.Text;
            btn_Ekle.Visible = true;
            btn_guncelle.Visible = false;
        }
    }
}
