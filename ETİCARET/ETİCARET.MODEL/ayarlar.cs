using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETİCARET.MODEL
{
    public class ayarlar:Base
    {


        public string siteAdi { get; set; }
        public string eposta { get; set; }
        public string telefon { get; set; }

        public string meteKey { get; set; }
        public string metaDesc { get; set; }

        public string  smtpEposta{get; set;}
        public string smtpsifre { get; set; }

        public  int port { get; set; }
      

    }
}
