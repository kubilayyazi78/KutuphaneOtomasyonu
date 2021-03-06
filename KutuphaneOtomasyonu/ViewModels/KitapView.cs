﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.ViewModels
{
   public class KitapView
    {
        public int KitapId { get; set; }
        public string KitapAdi { get; set; }
        public string YazarId { get; set; }
        public int Adet { get; set; } = 0;

       public override string ToString() => ($"{KitapAdi.Substring(0,1).ToUpper()+KitapAdi.Substring(1).ToLower()} Kalan Miktar: - ({Adet})");
    }
}
