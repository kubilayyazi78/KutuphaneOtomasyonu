using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.ViewModels
{
    public class KiralaView
    {

        public string UyeId { get; set; }
        public string UyeId2 { get; set; }
        public string KitapId { get; set; }  
        public DateTime AlinanTarih { get; set; } = DateTime.Now;

        public override string ToString() => ($"{UyeId.Substring(0, 1).ToUpper() + UyeId.Substring(1).ToLower()}-{UyeId2.Substring(0, 1).ToUpper() + UyeId2.Substring(1).ToLower()}- ({KitapId.Substring(0, 1).ToUpper() + KitapId.Substring(1).ToLower()}) Alınan Tarih : {AlinanTarih}");
    }
}
