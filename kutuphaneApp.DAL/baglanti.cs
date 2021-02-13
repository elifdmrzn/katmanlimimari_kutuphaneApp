using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace kutuphaneApp.DAL
{
    public class baglanti
    {
        private readonly string _connectionString;

        public baglanti()
        {
            _connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kutuphane.accdb";
        }
        public OleDbConnection GetOleDbConnection()
        {
            OleDbConnection cnn = new OleDbConnection(_connectionString);
            if (cnn.State == System.Data.ConnectionState.Open)
            {
                cnn.Close();
                cnn.Open();
            }
            else
            {
                cnn.Open();
            }
            return cnn;
        }

        public OleDbCommand GetOleDbCommand()
        {
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = GetOleDbConnection();
            return komut;
        }
    }
}

