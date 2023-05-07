using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlicacchuyenbaynoidia.Data
{
    public class Plane
    {
        public string soHieuMayBay { get; set; } // 0 < soHieu <= 15 kí tự

        public string loaiMayBay { get; set; } // 0 < Loại <= 40 kí tự

        public int soCho { get; set; } //Số  chỗ >= 20

        public Plane() { } // hàm khỏi tạo không tham so 

        public Plane(string soHieuMayBay, string loaiMayBay, int soCho) // hàm khỏi tạo full tham so 
        {
            this.soHieuMayBay = soHieuMayBay;
            this.loaiMayBay = loaiMayBay;
            this.soCho = soCho;
        }
    }
}
