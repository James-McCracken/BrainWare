using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Infrastructure
{
    using System.Data.Common;
    using System.Data.SqlClient;
    using System.Data.SQLite;
    public class Database
    {
        private readonly SQLiteConnection sqlite;
        private readonly Uri localPath;
        private readonly string pathToDB;
        private readonly string dbName = "BrainwareDB.db";
        public Database()
        {
            localPath = new Uri(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase));
            pathToDB = System.IO.Path.Combine(localPath.LocalPath, dbName);
            sqlite = new SQLiteConnection($"Data Source={pathToDB}");
        }

        public void OpenDB()
        {
            sqlite.Open();
        }
        public void CloseDB()
        {
            sqlite.Close();
        }
        public DbDataReader ExecuteReader(string query)
        {
            try
            {
                
                return new SQLiteCommand(query, sqlite).ExecuteReader();
                
            }
            catch (SQLiteException ex)
            {
                return null;
            }

        }

        public int ExecuteNonQuery(string query)
        {
            try
            {
                return new SQLiteCommand(query, sqlite).ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                return 0;
            }
        }

    }
}