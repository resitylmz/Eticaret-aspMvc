using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETİCARET.MODEL
{
   public  class satis :Base
    {
        public int sepetId { get; set; }
        public string İndirimtutarı { get; set; }
        public string satisTutarı { get; set; }
        public DateTime kayitTarih { get; set; }
        public string satisDurumu { get; set; }
        public string faturaAdresi { get; set; }
        public int kargoİd { get; set; }
    }
}
