using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETİCARET.MODEL
{
   public  class Base
    {
        [Key]
        public int id { get; set; }

        public bool durum { get; set; }
       
        public DateTime KayitTarihi { get; set; }
    }
}
