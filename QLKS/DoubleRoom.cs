using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS
{
    public class DoubleRoom : Room
    {
        public DoubleRoom(int roomNumber, double roomPrice)
        {
            RoomNumber = roomNumber;
            RoomPrice = roomPrice;
            IsOccupied = false;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Double Room number {RoomNumber} - Price: {RoomPrice} USD/night - {(IsOccupied ? "Occupied" : "Vacant")}");
        }

        public override void CheckOut()
        {
            IsOccupied = false;
        }
    }

}
