using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS
{
    public abstract class Room
    {
        public int RoomNumber { get; set; }
        public double RoomPrice { get; set; }
        public bool IsOccupied { get; set; }

        public abstract void DisplayInfo();
        public abstract void CheckOut();
    }

}
