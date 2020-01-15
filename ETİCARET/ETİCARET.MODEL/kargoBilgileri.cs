using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETİCARET.MODEL
{
   public  class kargoBilgileri
    {
        public int id { get; set; }
        public string firmaAdi { get; set; }
        public string durum { get; set; }
        public int teslimatId { get; set; }
        public string kargoTakipNo { get; set; }
    }
}
