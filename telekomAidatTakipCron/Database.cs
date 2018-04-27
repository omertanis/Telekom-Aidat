using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telekomAidatTakipCron
{
    class Database : IDisposable
    {
        SqlConnection bag;
        SqlCommand kmt;
        SqlDataReader data;
        public Database(string connectstring)
        {
            bag = new SqlConnection(connectstring);
            kmt = new SqlCommand();
            kmt.Connection = bag;
            bag.Open();
        }
        public Database()
        {
            bag = new SqlConnection(Program.connectstring);
            kmt = new SqlCommand();
            kmt.Connection = bag;
            kmt.CommandTimeout = 15;
            bag.Open();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing == true)
            {
                bag.Close(); // call close here to close connection
            }
        }

        ~Database()
        {
            Dispose(false);
        }
        
        public SqlDataReader DataOku(string query)
        {
            kmt.CommandText = query;
            data = kmt.ExecuteReader();
            return data;
        }
        public string DataOkuTek(string query, string column)
        {
            kmt.CommandText = query;
            data = kmt.ExecuteReader();
            if (data.Read())
                return data[column].ToString();
            return string.Empty;
        }
        public SqlDataReader DataOku(string query, params object[] param)
        {
            kmt.CommandText = query;
            for (int i = 0; i < param.Length; i++)
            {
                kmt.Parameters.AddWithValue("@" + i, param[i]);
            }
            data = kmt.ExecuteReader();
            return data;
        }
        public SqlDataReader DataOku(string query, List<SqlParameter> param)
        {
            kmt.CommandText = query;
            foreach (SqlParameter item in param)
            {
                kmt.Parameters.Add(item);
            }
            data = kmt.ExecuteReader();
            return data;
        }
        public string DataOkuTek(string query, string column, params object[] param)
        {
            kmt.CommandText = query;
            for (int i = 0; i < param.Length; i++)
            {
                kmt.Parameters.AddWithValue("@" + i, param[i]);
            }
            data = kmt.ExecuteReader();
            if (data.Read())
                return data[column].ToString();
            return string.Empty;
        }
        public void Sorgu(string query)
        {
            kmt.CommandText = query;
            kmt.ExecuteNonQuery();
        }
        public void Sorgu(string query, params object[] param)
        {
            kmt.CommandText = query;
            for (int i = 0; i < param.Length; i++)
            {
                kmt.Parameters.AddWithValue("@" + i, param[i]);
            }
            kmt.ExecuteNonQuery();
        }
        public void Sorgu(string query, SqlParameter param2, params object[] param)
        {
            kmt.CommandText = query;
            kmt.Parameters.Add(param2);
            for (int i = 0; i < param.Length; i++)
            {
                kmt.Parameters.AddWithValue("@" + i, param[i]);
            }
            kmt.ExecuteNonQuery();
        }
        public void Kapat()
        {
            bag.Close();
        }
        static public void Restore(string path)
        {
            SqlConnection bag;
            SqlCommand kmt;
            bag = new SqlConnection(Program.connectstring.Replace("telekomAidat","master"));
            kmt = new SqlCommand();
            kmt.Connection = bag;
            kmt.CommandTimeout = 15;
            bag.Open();
            kmt.CommandText = "alter database telekomAidat set offline with rollback immediate";
            kmt.ExecuteNonQuery();
            kmt.CommandText = "restore database telekomAidat from disk=@0";
            kmt.Parameters.AddWithValue("@0",path);
            kmt.ExecuteNonQuery();
            kmt.CommandText = "alter database telekomAidat set online";
            kmt.ExecuteNonQuery();
        }
    }
}
