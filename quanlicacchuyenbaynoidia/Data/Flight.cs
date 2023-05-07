using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlicacchuyenbaynoidia.Data
{
    public class Flight
    {
        public string maChuyenBay { get; set; } // 1 -> 15 kí tự

        public DateTime ngayKhoiHanh { get; set; } // Chỉ được đặt ở tương lai

        public string sanBayDen { get; set; } // Lớn hơn 1 kí tự

        public int trangThai { get; set; } 
        /*
        0 huy chuyen 
        1 con ve
	    2 het ve
	    3 hoan tat
	    */

        public string soHieuMayBay { get; set; }

        public string[] danhSachVe;

        public int tongSoVe;

        public Flight()
        {
            this.trangThai = 1;
            this.tongSoVe = 0;
        }
    }
}
