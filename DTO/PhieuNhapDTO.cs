using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapDTO
    {
        private int maphieunhap;
        private DateTime ngaynhap;

        public int Maphieunhap { get => maphieunhap; set => maphieunhap = value; }
        public DateTime Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
    }
}
