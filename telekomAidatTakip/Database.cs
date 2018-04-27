using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telekomAidatTakip
{
    class Database : IDisposable
    {
        SqlConnection bag;
        SqlCommand kmt;
        SqlDataReader data;
        Exception excepBaglanti = new Exception("Veritabanı hatası");

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
            try
            {
                bag.Open();
            }
            catch
            {
                throw excepBaglanti;
            }
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
            try
            {
                data = kmt.ExecuteReader();
            }
            catch
            {
                this.Kapat();
                throw excepBaglanti;

            }
            return data;
        }
        public string DataOkuTek(string query, string column)
        {
            kmt.CommandText = query;
            try
            {
                data = kmt.ExecuteReader();
            }
            catch
            {
                this.Kapat();
                throw excepBaglanti;

            }
            if (data.Read())
                return data[column].ToString();
            return string.Empty;
        }
        public SqlDataReader DataOku(string query, params object[] param)
        {
            kmt.CommandText = query;
            kmt.Parameters.Clear();
            for (int i = 0; i < param.Length; i++)
            {
                kmt.Parameters.AddWithValue("@" + i, param[i]);
            }
            try
            {
                data = kmt.ExecuteReader();
            }
            catch
            {
                this.Kapat();
                throw excepBaglanti;

            }
            return data;
        }
        public SqlDataReader DataOku(string query, List<SqlParameter> param)
        {
            kmt.CommandText = query;
            kmt.Parameters.Clear();
            foreach (SqlParameter item in param)
            {
                kmt.Parameters.Add(item);
            }
            try
            {
                data = kmt.ExecuteReader();
            }
            catch
            {
                this.Kapat();
                throw excepBaglanti;

            }
            return data;
        }
        public string DataOkuTek(string query, string column, params object[] param)
        {
            kmt.CommandText = query;
            kmt.Parameters.Clear();
            for (int i = 0; i < param.Length; i++)
            {
                kmt.Parameters.AddWithValue("@" + i, param[i]);
            }
            try
            {
                data = kmt.ExecuteReader();
                if (data.Read())
                    return data[column].ToString();
            }
            catch
            {
                this.Kapat();
                throw excepBaglanti;
            }
            return string.Empty;
        }
        public void Sorgu(string query)
        {
            kmt.CommandText = query;
            try
            {
                kmt.ExecuteNonQuery();
            }
            catch
            {
                this.Kapat();
                throw excepBaglanti;

            }
        }
        public void Sorgu(string query, params object[] param)
        {
            kmt.CommandText = query;
            kmt.Parameters.Clear();
            for (int i = 0; i < param.Length; i++)
            {
                kmt.Parameters.AddWithValue("@" + i, param[i]);
            }
            try
            {
                kmt.ExecuteNonQuery();
            }
            catch(SqlException exception)
            {
                this.Kapat();
                if (exception.Number == 2627)
                {
                    throw new Exception("Girilen numara kullanılmakta");
                }
                
                throw excepBaglanti;

            }
        }
        public void Sorgu(string query, SqlParameter param2, params object[] param)
        {
            kmt.CommandText = query;
            kmt.Parameters.Clear();
            kmt.Parameters.Add(param2);
            for (int i = 0; i < param.Length; i++)
            {
                kmt.Parameters.AddWithValue("@" + i, param[i]);
            }
            try
            {
                kmt.ExecuteNonQuery();
            }
            catch
            {
                this.Kapat();
                throw excepBaglanti;

            }
        }
        public void Kapat()
        {
            if (bag != null && bag.State == System.Data.ConnectionState.Open)
                bag.Close();
        }
        static public void Restore(string path)
        {
            SqlConnection bag;
            SqlCommand kmt;
            bag = new SqlConnection(Program.connectstring.Replace("telekomAidat", "master"));
            kmt = new SqlCommand();
            kmt.Connection = bag;
            kmt.CommandTimeout = 15;
            try
            {
                bag.Open();
                kmt.CommandText = "alter database telekomAidat set offline with rollback immediate";
                kmt.ExecuteNonQuery();
                kmt.CommandText = "restore database telekomAidat from disk=@0";
                kmt.Parameters.AddWithValue("@0", path);
                kmt.ExecuteNonQuery();
                kmt.CommandText = "alter database telekomAidat set online";
                kmt.ExecuteNonQuery();
            }
            catch
            {
                if (bag != null && bag.State == System.Data.ConnectionState.Open)
                    bag.Close();
                throw new Exception("Bağlantı hatası");

            }
        }
    }
}
