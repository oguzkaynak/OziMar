using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Urun
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public int KategoriID { get; set; }
        public int TedarikciID { get; set; }
        public string Birim { get; set; }
        public decimal BirimFiyat { get; set; }
        public short BirimStok { get; set; }
        public short BirimSiparis { get; set; }
        public short ZorunluSiparis { get; set; }
        public bool Satistami { get; set; }

    }
}
