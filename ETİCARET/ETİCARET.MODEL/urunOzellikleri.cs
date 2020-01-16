using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETİCARET.MODEL
{
    public class urunOzellikleri :Base
    {
        [ForeignKey("urunler")]
        public int urunId { get;  set;  }
        [Required]
        public int aciklama { get; set; }
        public ICollection<urun> urunler { get; set; }
       
    }
}
