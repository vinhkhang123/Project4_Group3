using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class phieunhap 
    {
        DBAccess objDBAccess = new DBAccess();
        private static string _table = "phieunhap";
        private static string _table2 = "linhkien";
        private static string _filesd = "maphieunhap,ngaynhap";
        private static string _files = "ngaynhap";
        public DataTable ReadAll()
        {

            string query = "select "+ _filesd + " from "+_table+";";
          
            return objDBAccess.ExecuteDataTable(query);
        }
         public bool Create(PhieuNhapDTO Item)
        {
            string query = "INSERT INTO " + _table + "(" + _files + ")VALUES (N'{0}')";
            string Query = string.Format(query, (Item.Ngaynhap).ToString().Replace("\'", "\\\'"));
            return (objDBAccess.ExecuteNonQuery(Query) > 0) ? true : false;
        }
        public bool Delete(PhieuNhapDTO Item)
        {
            string query = "BEGIN DECLARE @maphieunhap INT; SET @maphieunhap = '{0}';  DELETE FROM "+_table2+ " WHERE "+_table2+ ".maphieunhap = @maphieunhap; DELETE FROM "+_table+ " WHERE "+_table+".maphieunhap = @maphieunhap; END";
            string Query = string.Format(query, Item.Maphieunhap);

            return (objDBAccess.ExecuteNonQuery(Query) > 0) ? true : false;


        }
    }
}
