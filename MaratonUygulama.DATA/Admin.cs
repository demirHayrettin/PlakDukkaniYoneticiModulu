﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniYoneticiModulu.DATA
{
    public class Admin : BaseClass
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string? SifreKontrol { get; set; }

    }
}
