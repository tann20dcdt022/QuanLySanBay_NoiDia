using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlicacchuyenbaynoidia.Data
{
    public class Passenger
    {
        public string cmnd { get; set; }

        public string ho { get; set; }

        public string ten { get; set; }

        public bool phai { get; set; }

        public Passenger() { }

        public Passenger(string cmnd, string ho, string ten, bool phai)
        {
            this.cmnd = cmnd;
            this.ho = ho;
            this.ten = ten;
            this.phai = phai;
        }
    }
}
