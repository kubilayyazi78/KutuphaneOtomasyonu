using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.ViewModels
{
    public class TeslimView
    {
        public string UyeAdi { get; set; }
        public string UyeSoyadi { get; set; }
        public string KitapAdi { get; set; }
        public int UyeId { get; set; }
        public int KitapId { get; set; }
        public DateTime AlinanTarih { get; set; } = DateTime.Now;

        public override string ToString() => ($"{UyeAdi.Substring(0,1).ToUpper()+UyeAdi.Substring(1).ToLower()}-{UyeSoyadi.Substring(0,1).ToUpper()+UyeSoyadi.Substring(1).ToLower()} Kütüphaneden Aldığı Kitap Adı : - {KitapAdi.Substring(0,1).ToUpper()+KitapAdi.Substring(1).ToLower()}");
    }
}
