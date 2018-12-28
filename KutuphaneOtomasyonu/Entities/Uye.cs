using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Entities
{
    [Table("Uyeler")]
   public  class Uye
    {

        [Key]
        public int UyeId { get; set; }
        [Required]
        [StringLength(20)]
        public string UyeAdi { get; set; }
        [Required]
        [StringLength(20)]
        public string UyeSoyadi { get; set; }
        [Index(IsUnique =true)]
        [MinLength(11),MaxLength(11)]
        public string TcKimlik { get; set; }
        public int? Ceza { get; set; } = 0;
        public virtual ICollection<Kira> Kiralik { get; set; } = new HashSet<Kira>();
    }
}
