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
        public string KitapId { get; set; }  
        public DateTime AlinanTarih { get; set; } = DateTime.Now;
       
    }
}
