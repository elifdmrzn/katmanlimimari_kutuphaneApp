
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kutuphaneApp.Entity
{
    public class kitaplarr//açık erişim
    {
        public int KitapNo { get; set; }

        public string KitapAd { get; set; }
        public string KitapYazari { get; set; }
        public int KitapBaskiYil { get; set; }
        public int KitapSayfaSayi { get; set; }
        public string KitapYayinEvi { get; set; }
        //kapsülleme işlemi

    }
}
