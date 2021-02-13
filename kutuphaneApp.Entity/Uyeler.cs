
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kutuphaneApp.Entity
{
    public class Uyeler//açık erişim
    {
        public int UyeNo { get; set; }

        public string UyeAd { get; set; }
        public string UyeSoyad { get; set; }
        public int UyeTel { get; set; }
        public string UyeEmail { get; set; }
        public string UyeAdres { get; set; }
        public int KitapNo { get; set; }
        //kapsülleme işlemi
    }
}
