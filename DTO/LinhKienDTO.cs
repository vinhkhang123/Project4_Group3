using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LinhKienDTO
    {
        private int maphieunhap;
        private int malinhkien;
        private int soluong;
        private string tenlinhkien;

        public int Maphieunhap { get => maphieunhap; set => maphieunhap = value; }
        public int Malinhkien { get => malinhkien; set => malinhkien = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string Tenlinhkien { get => tenlinhkien; set => tenlinhkien = value; }
    }
}
