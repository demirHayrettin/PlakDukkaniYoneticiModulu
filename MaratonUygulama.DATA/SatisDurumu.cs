using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniYoneticiModulu.DATA
{
    public enum SatisDurumu
    {
        [Display(Name = "Devam Ediyor")] DevamEdiyor = 1,
        [Display(Name = "Satış Durduruldu")] SatisDurduruldu = 2,

    }
}
