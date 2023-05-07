using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlicacchuyenbaynoidia.Data
{
    public class Flights
    {
        public class FightsNode {
            public Flight flight;
            FightsNode next;

            public FightsNode(Flight flight) 
            { 
                this.flight = flight;
                this.next = null;
            }
        }

        public Flights() {}
    }
}
