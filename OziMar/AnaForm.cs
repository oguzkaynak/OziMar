using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OziMar
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void TSMI_KategoriEkle_Click(object sender, EventArgs e)
        {
            Form[] AcikFormlar = this.MdiChildren;
            bool acikmi = false;
            for (int i = 0; i < AcikFormlar.Length; i++)
            {
                if (AcikFormlar[i].GetType()==typeof(KategoriEkleForm))
                {
                    acikmi = true;
                    AcikFormlar[i].Activate();
                    break;
                }
            }
            if (acikmi==false)
            {
                KategoriEkleForm frm = new KategoriEkleForm();
                frm.MdiParent = this;
                frm.Show();
            }

        }

        private void TSMI_UrunListele_Click(object sender, EventArgs e)
        {
            Form[] acikformlar = this.MdiChildren;
            bool acikmi = false;
            foreach (Form item in acikformlar)
            {
                if (item.GetType()==typeof(UrunListeleForm))
                {
                    acikmi = true;
                    item.Activate();
                    break;
                }
            }
            if (acikmi==false)
            {
                UrunListeleForm frm = new UrunListeleForm();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
