using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuNhapBUS
    {
        phieunhap HO = new phieunhap();
        public DataTable ReadAll()
        {
            return HO.ReadAll();
        }
        public bool Create(PhieuNhapDTO dto)
        {
            return HO.Create(dto);
        }
        public bool Delete(PhieuNhapDTO dto)
        {
            return HO.Delete(dto);
        }
    }
}
