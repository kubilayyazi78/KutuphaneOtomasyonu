﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.ViewModels
{
   public class YazarView
    {
        public int YazarId { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }

        public override string ToString() => ($"{YazarAdi} {YazarSoyadi}");
    }
}
