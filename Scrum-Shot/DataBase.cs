using System;
using System.Data;
using System.Data.Odbc;
using System.Web.Configuration;

namespace DataBaseClass
{
    class DataBase
    {
        OdbcConnection connection;

        public DataBase()
        {
            string connString;
            //connString = WebConfigurationManager.ConnectionStrings["AppDbFromExt"].ConnectionString;
            connString = WebConfigurationManager.ConnectionStrings["AppDbFromInt"].ConnectionString;
            connection = new OdbcConnection(connString);
        }

        public void Open()
        {
            connection.Open();
        }
        public void Close()
        {
            connection.Close();
        }

        public DataTable FillDataTable(string sql)
        {
            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(sql, connection);  // da automatically opens connection        
            da.Fill(dt);
            return dt;
        }
        public int ExecuteNonQuery(string sql)
        {
            OdbcCommand cmd = new OdbcCommand();
            int numRecords = 0;
            bool isConnectionClosed = connection.State == ConnectionState.Closed;

            if (isConnectionClosed)
            {
                Open();
            }
            try
            {
                cmd.CommandText = sql;
                cmd.Connection = connection;
                numRecords = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (isConnectionClosed)
                {
                    Close();
                }
            }

            return numRecords;
        }
        public object ExecuteScalar(string sql)
        {
            OdbcCommand cmd = new OdbcCommand();
            object anyValue;
            bool isConnectionClosed = connection.State == ConnectionState.Closed;

            if (isConnectionClosed)
            {
                Open();
            }
            try
            {
                cmd.CommandText = sql;
                cmd.Connection = connection;
                anyValue = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (isConnectionClosed)
                {
                    Close();
                }
            }
            return anyValue;
        }
    }
}
