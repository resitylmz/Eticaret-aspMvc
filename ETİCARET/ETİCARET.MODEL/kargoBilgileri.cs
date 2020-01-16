using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETİCARET.MODEL
{
   public  class kargoBilgileri :Base
    {
        public string firmaAdi { get; set; }
        public string durum { get; set; }
        [ForeignKey("siparis")]
        public int teslimatId { get; set; }
        public string kargoTakipNo { get; set; }
        public sepetSiparis siparis { get; set; }
       // public ICollection<kargoBilgileri> kargoBilgileri { get; set; }
    }
}
