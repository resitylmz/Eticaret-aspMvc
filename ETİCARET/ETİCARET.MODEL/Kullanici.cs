using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETİCARET.MODEL
{
   public  class Kullanici :Base
    { 

        public string adSoyad { get; set; }
        public string email { get; set; }
        public string kullaniciAdi { get; set; }

        public DateTime kayitTraihi { get; set; }
        public DateTime dogumTarihi { get; set; }
        public  string varsayılanAdres { get; set; }
        public string durum { get; set; }
        public string sonzGiris { get; set; }
    }
}
