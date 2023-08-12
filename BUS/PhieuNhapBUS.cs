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
        phieunhap PN = new phieunhap();
        public DataTable ReadAll()
        {
            return PN.ReadAll();
        }
        public bool Create(PhieuNhapDTO dto)
        {
            return PN.Create(dto);
        }
        public bool Delete(PhieuNhapDTO dto)
        {
            return PN.Delete(dto);
        }
    }
}
