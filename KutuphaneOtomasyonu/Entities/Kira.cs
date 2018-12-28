using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Entities
{
    [Table("Kiralar")]
   public class Kira
    {   
        [Key]
        [Column(Order =1)]
        public int UyeId { get; set; }
        
        [Key]
        [Column(Order = 2)]
        public int KitapId { get; set; }
        [Column("Eklenme", TypeName = "smalldatetime")]
        public DateTime AlinanTarih { get; set; } = DateTime.Now;
        [ForeignKey("KitapId")]
        public virtual Kitap Kitap { get; set; }
        [ForeignKey("UyeId")]
        public virtual Uye Uye { get; set; }
    }
}
