using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class DBAccess
    {
        private static SqlConnection connection = new SqlConnection();
        private static SqlCommand command = new SqlCommand();
        private static SqlDataAdapter adapter = new SqlDataAdapter();

        protected SqlConnection _conn;
        public static string strConn = @"Data Source=LAPTOP-QMVRU8HD\VINHKHANG0501;Initial Catalog=kho;Integrated Security=True";
        public bool _OpenConn()
        {
            try
            {
                _conn = new SqlConnection(strConn);
                _conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void _CloseConn()
        {
            _conn.Close();
            _conn.Dispose();
        }
        public DataTable ExecuteDataTable(string query)
        {
            DataTable dt = new DataTable();
            if (_OpenConn())
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(query, _conn);
                    dt.Load(sqlCommand.ExecuteReader());
                }
                catch (Exception ex)
                {
                    return dt;
                }
            }
            _CloseConn();
            return dt;
        }
        public DataSet ExecuteDataSet(string query)
        {
            DataSet ds = new DataSet();
            if (_OpenConn())
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, _conn);
                    da.Fill(ds, "result");
                }
                catch (Exception ex)
                {
                    return ds;
                }
            }
            _CloseConn();
            return ds;
        }
        public SqlDataReader ExecuteReader(string query)
        {

            if (_OpenConn())
            {
                try
                {
                    SqlDataReader reader;
                    SqlCommand cmd = new SqlCommand(query, _conn);
                    reader = cmd.ExecuteReader();
                    _CloseConn();
                    return reader;
                }
                catch (Exception ex)
                {
                    // khong lam gi ca
                }
            }

            _CloseConn();

            return null;
        }
        public int ExecuteNonQuery(string query)
        {
            int affectedRows = 0;

            if (_OpenConn())
            {

                SqlCommand cmd = new SqlCommand(query, _conn);
                affectedRows = cmd.ExecuteNonQuery();


            }

            _CloseConn();

            return affectedRows;

        }
    }
}
