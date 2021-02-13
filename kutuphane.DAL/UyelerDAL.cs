using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.OleDb; // veritabanına bağlanmak için gerekli
using kutuphaneApp.Entity;// entity den referans aldığından ekliyoruz

namespace kutuphane.DAL
{
    public class uyeler // açık erişim
    {
        private Baglanti baglanti; // bağlantı için oluşturuldu


        public uyeler()// uyeler classının constructor ı oluşturuldu
        {
            baglanti = new Baglanti();// bağlantı nesnesi
        }
        public DataTable Getir()// veritabanından tabloyu getirmek için
        {
            OleDbCommand cmd = baglanti.GetOleDbCommand();//komut
            cmd.CommandText = "Select * From Uyeler";//veri tabanı sorgusu
            DataTable dt = new DataTable();//nesne
            dt.Load(cmd.ExecuteReader());//veri sıralama
            return dt;
           
        }
        public void Ekle(Uyeler uyeler)// uye ekleme fonksiyonu
        {
            string cmdText =
                "INSERT INTO [Uyeler]([UyeNo],[UyeAd],[UyeSoyad],[UyeTel],[UyeEmail],[UyeAdres],[KitapNo])";
            cmdText += String.Format("values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                Convert.ToInt32(uyeler.UyeNo), uyeler.UyeAd, uyeler.UyeSoyad, Convert.ToInt32(uyeler.UyeTel),
             uyeler.UyeEmail,  uyeler.UyeAdres, Convert.ToInt32(uyeler.KitapNo));
            OleDbCommand cmd = baglanti.GetOleDbCommand();//bağlantı
            cmd.CommandText = cmdText;// cmdText içindekiler aktarıldı
            cmd.ExecuteNonQuery();//sql komutu

        }

        public void Sil(Uyeler uyeler)//üye silme fonksiyonu
        {
            OleDbCommand cmd = baglanti.GetOleDbCommand();
            cmd.CommandText = String.Format("DELETE FROM Uyeler WHERE UyeNo ={0}", Convert.ToInt32(uyeler.UyeNo));
            cmd.ExecuteNonQuery();

        }
        public void Guncelle(Uyeler uyeler)//üye güncelleme fonksiyonu
        {
            OleDbCommand cmd = baglanti.GetOleDbCommand();//bağlantı
            cmd.CommandText = ("UPDATE Uyeler SET  UyeAd=@ua,UyeSoyad=@us,UyeTel=@tel," +
                "UyeEmail=@em,UyeAdres=@ad, KitapNo=@kn WHERE UyeNo=@un");// değerler parametrelere atandı
            cmd.Parameters.AddWithValue("@ua", uyeler.UyeAd);
            cmd.Parameters.AddWithValue("@us", uyeler.UyeSoyad);
            cmd.Parameters.AddWithValue("@tel", uyeler.UyeTel);
            cmd.Parameters.AddWithValue("@em", uyeler.UyeEmail);
            cmd.Parameters.AddWithValue("@ad", uyeler.UyeAdres);
            cmd.Parameters.AddWithValue("@un", uyeler.UyeNo);
            cmd.Parameters.AddWithValue("@kn", uyeler.KitapNo);
            cmd.ExecuteNonQuery();
        }

    }
}
