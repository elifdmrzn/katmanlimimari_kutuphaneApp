using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.OleDb;// veritabanına bağlanmak için gerekli
using kutuphaneApp.Entity;// entity den referans aldığından ekliyoruz

namespace kutuphane.DAL
{
    public class kitapDAL//açık erişim
    {
        private Baglanti baglanti;//bağlantı için


        public kitapDAL()
        {
            baglanti = new Baglanti();//bağlantı nesnesi
        }
        public DataTable Getir()//getir fonksiyonu
        {
            OleDbCommand cmd = baglanti.GetOleDbCommand();
            cmd.CommandText = "Select * From kitaplar";
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt; 

        }
        public void Ekle(kitaplarr kitap)//ekleme
        {
            string cmdText =
                "INSERT INTO [kitaplar]([KitapNo],[KitapAd],[KitapYazari],[KitapBaskiYil],[KitapSayfaSayi],[KitapYayinEvi])";
            cmdText += String.Format("values('{0}','{1}','{2}','{3}','{4}','{5}')",
                Convert.ToInt32(kitap.KitapNo), kitap.KitapAd, kitap.KitapYazari, Convert.ToInt32(kitap.KitapBaskiYil), Convert.ToInt32(kitap.KitapSayfaSayi),
             kitap.KitapYayinEvi);
            OleDbCommand cmd = baglanti.GetOleDbCommand();
            cmd.CommandText = cmdText;
            cmd.ExecuteNonQuery();

        }

        public void Sil(kitaplarr kitap)//silme
        {
            OleDbCommand cmd = baglanti.GetOleDbCommand();
            cmd.CommandText = String.Format("DELETE FROM kitaplar WHERE KitapNo ={0}", Convert.ToInt32(kitap.KitapNo));
            cmd.ExecuteNonQuery();

        }
        public void Guncelle(kitaplarr kitap)//güncelleme
        {
            OleDbCommand cmd = baglanti.GetOleDbCommand();//komut bağlantısı 
            cmd.CommandText = ("UPDATE kitaplar SET  KitapAd=@ka,KitapYazari=@ky,KitapBaskiYil=@by," +
                "KitapSayfaSayi=@ks,KitapYayinEvi=@ke WHERE KitapNo=@kn");//değerler parametrelere atandı
          
            cmd.Parameters.AddWithValue("@ka", kitap.KitapAd);
            cmd.Parameters.AddWithValue("@ky", kitap.KitapYazari);
            cmd.Parameters.AddWithValue("@by", kitap.KitapBaskiYil);
            cmd.Parameters.AddWithValue("@ks", kitap.KitapSayfaSayi);
            cmd.Parameters.AddWithValue("@ke", kitap.KitapYayinEvi);
            cmd.Parameters.AddWithValue("@kn", kitap.KitapNo);
            cmd.ExecuteNonQuery();
        }

    }
}