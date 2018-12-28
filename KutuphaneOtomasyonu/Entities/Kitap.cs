using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Entities
{

    [Table("Kitaplar")]
    public class Kitap
    {
        [Key]
        public int KitapId { get; set; }


        [Required]
        [StringLength(25)]
        [Index(IsUnique = true)]
        public string KitapAdi { get; set; }
        [Required]
        public int YazarId { get; set; }
        public int Adet { get; set; }
        [ForeignKey("YazarId")]
        public virtual Yazar Yazar { get; set; }

        public virtual ICollection<Kira> Kiralik { get; set; } = new HashSet<Kira>();

        public override string ToString()
        {
            return this.KitapAdi + " - " + Yazar.YazarAdi;
        }

    }
}
