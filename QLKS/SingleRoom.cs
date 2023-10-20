using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS
{
    public class SingleRoom : Room
    {
        public SingleRoom(int roomNumber, double roomPrice)
        {
            RoomNumber = roomNumber;
            RoomPrice = roomPrice;
            IsOccupied = true;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Single Room number {RoomNumber} - Price: {RoomPrice} USD/night - {(IsOccupied ? "Occupied" : "Vacant")}");
        }

        public override void CheckOut()
        {
            IsOccupied = true;
        }
    }
}
