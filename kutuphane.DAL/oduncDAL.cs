using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.OleDb;// veritabanına bağlanmak için gerekli
using kutuphaneApp.Entity; // entity den referans aldığından ekliyoruz

namespace kutuphane.DAL
{
    public class oduncDAL // açık erişim
    {
        private Baglanti baglanti;//bağlantı için oluşturuldu


        public oduncDAL()//constructor
        {
            baglanti = new Baglanti();//bağlantı nesnesi
        }
        public DataTable Getir()//tabloyu getircek
        {
            OleDbCommand cmd = baglanti.GetOleDbCommand();
            cmd.CommandText = "Select * From Odunc";
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt; 
        }
        public void Ekle(Odunc o)//ekleme
        {
            string cmdText =
                "INSERT INTO [Odunc]([OduncNo],[UyeNo],[OduncAlmaTarihi],[GeriGetirmeTarihi])";
            cmdText += String.Format("values('{0}','{1}','{2}','{3}')",
                Convert.ToInt32(o.OduncNo), Convert.ToInt32(o.UyeNo), Convert.ToDateTime(o.OduncAlmaTarihi), Convert.ToDateTime(o.GeriGetirmeTarihi));
            
            OleDbCommand cmd = baglanti.GetOleDbCommand();
            cmd.CommandText = cmdText;
            cmd.ExecuteNonQuery();

        }

        public void Sil(Odunc o)//silme
        {
            OleDbCommand cmd = baglanti.GetOleDbCommand();
            cmd.CommandText = String.Format("DELETE FROM Odunc WHERE OduncNo ={0}", Convert.ToInt32(o.OduncNo));
            cmd.ExecuteNonQuery();

        }
        public void Guncelle(Odunc o)//güncelleme
        {
            OleDbCommand cmd = baglanti.GetOleDbCommand();//bağlantı
            cmd.CommandText = ("UPDATE Odunc SET  UyeNo=@un, OduncAlmaTarihi=@oa, GeriGetirmeTarihi=@gg WHERE OduncNo=@on");//değerler parametrelere atandı

            cmd.Parameters.AddWithValue("@un", o.UyeNo);
            cmd.Parameters.AddWithValue("@oa", o.OduncAlmaTarihi);
            cmd.Parameters.AddWithValue("@gg", o.GeriGetirmeTarihi);
            cmd.Parameters.AddWithValue("@on", o.OduncNo);
          
            cmd.ExecuteNonQuery();
        }

    }
}