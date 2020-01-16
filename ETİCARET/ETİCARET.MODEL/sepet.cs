using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETİCARET.MODEL
{
   public  class sepet :Base
    {
        [ForeignKey("kullanici")]
        public int kullaniciId { get; set; }
        public int toplamTutar { get; set; }
        [ForeignKey("urunler")]
        public int urunId { get; set; }
        public ICollection<urun> uruenler { get; set; }

        public Kullanici kullanici { get; set; }
        
    }
}
