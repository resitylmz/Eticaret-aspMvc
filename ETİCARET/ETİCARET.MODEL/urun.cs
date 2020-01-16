using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETİCARET.MODEL
{
    public class urun :Base
    {
        [ForeignKey("kategori")]
        public int kategoriId { get; set; }
        [Required]
        public string urunKodu { get; set; }

        [ForeignKey("marka")]
        public int MarkaID { get; set; }

        [ForeignKey("urunOzellikleri")]
        public int urunOzellikId { get; set; }
        [Required]
        public string urunAdi{get; set;}

        [Required]
        public string fiyat { get; set; }

        [Required]
        public string stok { get; set; }
        
        public ICollection<kategori> kategori { get; set; }
        public ICollection<urunOzellikleri> urunOzellikleri { get; set; }

        public ICollection<marka> marka{ get; set; }


    }
}
