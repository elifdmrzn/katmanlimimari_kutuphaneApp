using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kutuphane.DAL;//daldan referans aldığı için gerekli
using System.Data;
using kutuphaneApp.Entity;//entity den referans aldığı için gerekli

namespace kutuphaneAPP.BLL
{
    public class oduncBLL//açık erişim
    {
        private oduncDAL oduncBll;

        public oduncBLL()
        {
            oduncBll = new oduncDAL();// daldan yeni nesne
        }

        public DataTable Getir()//getir metodu işlemleri
        {
            return oduncBll.Getir();//değer döndürür

        }

        public void Ekle(Odunc o)//ekle metodu işlemleri
        {
            oduncBll.Ekle(o);
        }

        public void Sil(Odunc o)//sil metodu işlemleri
        {
            oduncBll.Sil(o);
        }

        public void Guncelle(Odunc o)//güncelle metodu işlemleri
        {
            oduncBll.Guncelle(o);
        }
    }
}