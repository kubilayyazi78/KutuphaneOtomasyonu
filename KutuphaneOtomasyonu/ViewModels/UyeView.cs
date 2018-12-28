using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.ViewModels
{
   public class UyeView
    {
        public int UyeId { get; set; }
        public string UyeAdi { get; set; }
        public string UyeSoyadi { get; set; }
        public string TcKimlik { get; set; }
        public int? Ceza { get; set; } = 0;

        public override string ToString() => ($"{UyeAdi} {UyeSoyadi}");
    }
}
