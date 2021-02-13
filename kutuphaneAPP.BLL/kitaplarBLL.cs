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
    public class kitaplarBLL//açık erişim
    {
        private kitapDAL kitaplarBll;// dal sınıfından yeni nesne

        public kitaplarBLL()
        {
            kitaplarBll = new kitapDAL();//daldan yeni nesne
        }

        public DataTable Getir()// getir metodu işlemleri
        {
            return kitaplarBll.Getir();

        }

        public void Ekle(kitaplarr kitap)//ekle metodu işlemleri
        {
            kitaplarBll.Ekle(kitap);
        }

        public void Sil(kitaplarr kitap)//sil metodu işlemleri
        {
            kitaplarBll.Sil(kitap);
        }

        public void Guncelle(kitaplarr kitap)//güncelle metodu işlemleri
        {
            kitaplarBll.Guncelle(kitap);
        }
    }


}
