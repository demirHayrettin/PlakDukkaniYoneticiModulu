using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniYoneticiModulu.DATA
{
    public class Album : BaseClass
    {
        public string AlbumAdi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public decimal Fiyati { get; set; }
        public int? IndirimOrani { get; set; }

        public SatisDurumu SatisDurumu { get; set; }

        public string Sanatci { get; set; }
    }
}
