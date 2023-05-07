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

        public void addPlane(Plane plane)
        {
            this.planes[this.size] = plane;
            this.size++;
        }

        public void removePlane(string soHieuMayBay) 
        {
            int index = 0;
            for(int i = 0; i < this.size; i++)
            {
                if (this.planes[i].soHieuMayBay == soHieuMayBay)
                {
                    index = i;
                    break;
                }
            }

            for(int i = index; i < this.size; i++)
            {
                this.planes[i] = this.planes[i + 1];
            }

            this.size--;
        }

        public void editPlane(Plane plane)
        {
            for (int i = 0; i < this.size; i++)
            {
                if (this.planes[i].soHieuMayBay == plane.soHieuMayBay)
                {
                    this.planes[i] = plane;
                    break;
                }
            }
        }
    }
}
