using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class linhkien
    {
        DBAccess objDBAccess = new DBAccess();
        LinhKienDTO dto = new LinhKienDTO();
        private static string _tablelk  = "linhkien";
        private static string _filesdlk = "maphieunhap,malinhkien,tenlinhkien,soluong";
        private static string _filesdl = "maphieunhap,tenlinhkien,soluong";

        public DataTable ReadAll()
        {
            string query = "SELECT " + _filesdlk + " FROM " + _tablelk + ";";
 
            return objDBAccess.ExecuteDataTable(query);
        }
        public DataTable Readitem(LinhKienDTO Item)
        {
           
                string query = " SELECT  " + _filesdlk + " FROM " + _tablelk + " WHERE maphieunhap = " + Item.Maphieunhap + " ";
            


            return objDBAccess.ExecuteDataTable(query);
        }
        public bool Create(LinhKienDTO Item)
        {
            string query = "INSERT INTO " + _tablelk + "(" + _filesdl + ")VALUES ('{0}',N'{1}','{2}')";
            string Query = string.Format(query, (Item.Maphieunhap).ToString().Replace("\'", "\\\'"),(Item.Tenlinhkien).ToString().Replace("\'", "\\\'"), (Item.Soluong).ToString().Replace("\'", "\\\'"));
            return (objDBAccess.ExecuteNonQuery(Query) > 0) ? true : false;


        }
    }
}

