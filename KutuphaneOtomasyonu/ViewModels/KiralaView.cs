using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.ViewModels
{
    public class KiralaView
    {

        public int UyeId { get; set; }
        public int KitapId { get; set; }  
        public DateTime AlinanTarih { get; set; } = DateTime.Now;

    }
}
