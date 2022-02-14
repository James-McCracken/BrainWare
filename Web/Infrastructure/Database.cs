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
        //private readonly SqlConnection _connection;

        private readonly SQLiteConnection sqlite;
        public Database()
        {
            // var connectionString = "Data Source=LOCALHOST;Initial Catalog=BrainWare;Integrated Security=SSPI";
            var db = @"C:\Users\13mcc\Desktop\github\BrainWare\ProjectDB\Tables\BranwareDB.db";
            var connectionString = $"Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=BrainWAre;Integrated Security=SSPI;AttachDBFilename={db}";


            sqlite = new SQLiteConnection($"Data Source={db}");
            sqlite.Open();
            //_connection = new SqlConnection(connectionString);

            //_connection.Open();
        }

        public DbDataReader ExecuteReader(string query)
        {


            /*SQLiteDataAdapter ad;
            //DataTable dt = new DataTable();

            try
            {
                SQLiteCommand cmd;
                sqlite.Open();  //Initiate connection to the db
                cmd = sqlite.CreateCommand();
                cmd.CommandText = query;  //set the passed query
                ad = new SQLiteDataAdapter(cmd);
                //ad.Fill(dt); //fill the datasource
            }
            catch (SQLiteException ex)
            {
                //Add your exception code here.
            }*/

            var sqlQuery = new SQLiteCommand(query, sqlite);
            //var sqlQuery = new SqlCommand(query, _connection);

            return sqlQuery.ExecuteReader();
        }

        public int ExecuteNonQuery(string query)
        {
            var sqlQuery = new SQLiteCommand(query, sqlite);

            return sqlQuery.ExecuteNonQuery();
        }

    }
}