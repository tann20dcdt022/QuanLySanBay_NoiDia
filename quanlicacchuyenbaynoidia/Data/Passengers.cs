using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlicacchuyenbaynoidia.Data
{
    public  class Passengers
    {
        public class PassengersNode
        {
            Passenger passenger;
            PassengersNode left;
            PassengersNode right;
            int height;

            public PassengersNode(Passenger passenger) 
            {
                this.passenger = passenger;
                this.left = null;
                this.right = null;
                this.height = 0;
            }

        } 
    }
}
