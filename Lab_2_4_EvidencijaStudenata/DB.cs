using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Text;

namespace Lab_2_4_EvidencijaStudenata
{
    class DB
    {
        private static DB instance;
        private string connectionString;
        private SQLiteConnection connection;

        public static DB Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DB();
                }
                return instance;
            }
        }

        public string ConnectionString
        {
            get { return connectionString; }
            private set { connectionString = value; }
        }

        public SQLiteConnection Connection
        {
            get { return connection; }
            private set { connection = value; }
        }

        private DB()
        {
            ConnectionString = @"Data Source=..\..\Baza\EvidencijaStudenataPI.db3";
            Connection = new SQLiteConnection(ConnectionString);
            Connection.Open();
        }

        public DbDataReader DohvatiDataReader(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteReader();
        }

        public object DohvatiVrijednost(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteScalar();
        }

        public int IzvrsiUpit(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteNonQuery();
        }
    }
}
