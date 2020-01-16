using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETİCARET.MODEL
{
   public  class kullaniciRol:Base
    {
         [Required]
         public string kullaniciRoller { get; set; }
        [ForeignKey("kullanici")]
         public int kullaniciId { get; set; }
        [ForeignKey("rol")]
        public int rolId { get; set; }
        public Rol rol { get; set; }
        public Kullanici kullanici { get; set; }
    }

    internal class RequiredAttribute : Attribute
    {
    }
}
