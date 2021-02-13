using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using kutuphane.DAL;

namespace kutuphaneApp.DAL
{
    public class KitaplarDAL
    {
        private Baglanti baglanti;
        public KitaplarDAL()
        {
            baglanti = new Baglanti();
        }
        public DataTable GetAllItems()
        {
            OleDbCommand komut = baglanti.GetOleDbCommand();
            komut.CommandText = "Select * From Kitaplar";
            DataTable dt = new DataTable();
            dt.Load(komut.ExecuteReader());
            return dt;
        }
        public void AddNewItem(int KitapNo, string KitapAdi, string KitapYazari, int BaskiYil, int SayfaSayisi, string KitapDil, string YayinEvi, string Aciklama)
        {
            string komutText =
                "INSERT INTO [Kitaplar]([KitapNo],[KitapAdi],[KitapYazari],[BaskiYil],[SayfaSayisi],[KitapDil],[YayinEvi],[Aciklama])";
            komutText += String.Format("values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", Convert.ToInt32(KitapNo), KitapAdi, KitapYazari,Convert.ToDateTime(BaskiYil), Convert.ToInt32(SayfaSayisi), KitapDil, YayinEvi, Aciklama);
            OleDbCommand komut = baglanti.GetOleDbCommand();
            komut.CommandText = komutText;
            komut.ExecuteNonQuery();

        }

        public void DeleteItemById(int hasta_id)
        {
            OleDbCommand komut = baglanti.GetOleDbCommand();
            komut.CommandText = String.Format("DELETE FROM hastalar WHERE hasta_id={0}", Convert.ToInt32(hasta_id));
            komut.ExecuteNonQuery();

        }
        public void UpdateItem(int hasta_id, int TCK_numarası, string hasta_adı, string hasta_soyadı, string adres, int tel, string cinsiyet, DateTime doğum_tarihi, int doktor_id)
        {

        }
    }
}
