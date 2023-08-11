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
    public class LinhKienBUS
    {
        linhkien HO = new linhkien();
        LinhKienDTO dto = new LinhKienDTO();
        public DataTable ReadAll()
        {
            return HO.ReadAll();
        }
        public DataTable Readitem(LinhKienDTO dto)
        {
            return HO.Readitem(dto);
        }
        public bool Create(LinhKienDTO dto)
        {
            return HO.Create(dto);
        }
    }
}
