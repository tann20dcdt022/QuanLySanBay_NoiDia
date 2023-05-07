using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlicacchuyenbaynoidia.Data
{
    public class Planes
    {
        public Plane[] planes;
        public int size;

        public Planes()
        {
            this.planes = new Plane[300];
            this.size = 0;
        }
    }
}
