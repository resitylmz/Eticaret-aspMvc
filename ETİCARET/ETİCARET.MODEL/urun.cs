using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETİCARET.MODEL
{
    public class urun :Base
    {

        public int katagoriId { get; set; }

        public string urunKodu { get; set; }
        public int MarkaID { get; set; }
        public int urunOzellikId { get; set; }
        public string urunAdi{get; set;}

        public string fiyat { get; set; }



        public string stok { get; set; }

    }
}
