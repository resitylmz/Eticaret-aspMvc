using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETİCARET.MODEL
{
   public  class satis :Base
    {
        [ForeignKey("sepets")]
        public int sepetId { get; set; }
        public string İndirimtutarı { get; set; }
        public string satisTutarı { get; set; }
    
        public string satisDurumu { get; set; }
        public string faturaAdresi { get; set; }
        [ForeignKey("kargo")]
        public int kargoİd { get; set; }

        public ICollection<sepet> sepets { get; set; }
        public kargoBilgileri  kargo { get; set; }
    }
}
