using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kutuphane.DAL;//daldan referans aldığı için gerekli
using System.Data;
using kutuphaneApp.Entity;//entityden referans aldığı için gerekli

namespace kutuphaneAPP.BLL
{
   public class UyelerBLL//açık erişim
    {
        private uyeler uyelerDal;

        public UyelerBLL()
        {
            uyelerDal = new uyeler();//daldan yeni nesne
        }

        public DataTable Getir()//getir metodu işlemleri
        {
            return uyelerDal.Getir();

        }

        public void Ekle(Uyeler uyeler)//ekle metodu işlemleri
        {
            uyelerDal.Ekle(uyeler);
        }

        public void Sil(Uyeler uyeler)//sil metodu işlemleri
        {
            uyelerDal.Sil(uyeler);
        }

        public void Guncelle(Uyeler uyeler)//güncelle metodu işlemleri
        {
            uyelerDal.Guncelle(uyeler);
        }
    }

    
}
