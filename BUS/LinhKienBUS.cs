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
        linhkien LK = new linhkien();
        LinhKienDTO dto = new LinhKienDTO();
        public DataTable ReadAll()
        {
            return LK.ReadAll();
        }
        public DataTable Readitem(LinhKienDTO dto)
        {
            return LK.Readitem(dto);
        }
        public bool Create(LinhKienDTO dto)
        {
            return LK.Create(dto);
        }
        public bool Update(LinhKienDTO dto)
        {
            return LK.Update(dto);
        }
        public bool Delete(LinhKienDTO dto)
        {
            return LK.Delete(dto);
        }
    }
}
