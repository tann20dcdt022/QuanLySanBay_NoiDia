using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlicacchuyenbaynoidia.Data
{
    public class Flights
    {
        public class FlightsNode {
            public Flight flight;
            public FlightsNode next;

            public FlightsNode(Flight flight) 
            { 
                this.flight = flight;
                this.next = null;
            }
        }

        public FlightsNode head;
        public FlightsNode tail;
        public int size;

        public Flights() 
        {
            this.head = null;
            this.tail = null;
            this.size = 0;
        }
        
        public bool isEmpty()
        {
            return this.size == 0;
        }

        public void addFlight(Flight flight) 
        {
            FlightsNode newFlight = new FlightsNode(flight);
            if(this.isEmpty())
            {
                this.head = newFlight;
            } else
            {
                FlightsNode ptr = this.head;
                while(ptr != null)
                {
                    ptr = ptr.next;
                }
                ptr.next = newFlight;
            }

            this.tail = newFlight;
            this.size++;
        }

        public void editFlight(Flight flight, DateTime ngayGioHieuChinh) 
        {
            flight.ngayKhoiHanh = ngayGioHieuChinh;
        }
        
        pubic void cancelFlight(Flight flight)
        {
            flight.trangThai = 0;
        }
    }
}
