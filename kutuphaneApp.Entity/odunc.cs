using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphaneApp.Entity
{
   public class Odunc//açık erişim
    {
        public int OduncNo { get; set; }
        public int UyeNo { get; set; }
        public DateTime OduncAlmaTarihi { get; set; }
        public DateTime GeriGetirmeTarihi { get; set; }
        //kapsülleme işlemi
    }
}
