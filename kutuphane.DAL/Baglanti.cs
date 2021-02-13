using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;// veritabanına bağlanmak için gerekli
using kutuphane.DAL;

namespace kutuphane.DAL
{
    public class Baglanti// bağlantı classı veritabanı bağlantısı kurmak için
    {
        private readonly string baglanti_string;// bağlantı stringi
        public Baglanti()
        {
            baglanti_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kutuphane.accdb";// bağlantının yolu
        }
        public OleDbConnection GetOleDbConnection()//veritabanı bağlantısı
        {
            OleDbConnection baglan = new OleDbConnection(baglanti_string);// baglan adlı nesne oluşturduk
            if (baglan.State == System.Data.ConnectionState.Open)
            {
                baglan.Close();
                baglan.Open();
            }
            else
            {
                baglan.Open();
            }
            return baglan;
        }

        public OleDbCommand GetOleDbCommand()//cmd bağlantı
        {
            OleDbCommand cmd = new OleDbCommand();// cmd adında bağlantı nesnesi oluşturduk
            cmd.Connection = GetOleDbConnection();// bağlantı atandı
            return cmd;
        }
    }
}
