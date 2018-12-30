using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.ViewModels
{
     public class KitapYazarView
    {
        public int YazarId { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }

        public override string ToString() => ($"{YazarAdi.Substring(0,1).ToUpper()+YazarAdi.Substring(1).ToLower()} {YazarSoyadi.Substring(0,1).ToUpper()+YazarSoyadi.Substring(1).ToLower()}");
    }
}
