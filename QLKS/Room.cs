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
    }

    public class SingleRoom : Room
    {
        public SingleRoom(int roomNumber, double roomPrice)
        {
            RoomNumber = roomNumber;
            RoomPrice = roomPrice;
            IsOccupied = false; // Ban đầu, phòng không được thuê
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Single Room number {RoomNumber} - Price: {RoomPrice} USD/night - {(IsOccupied ? "Occupied" : "Vacant")}");
        }
    }
    public class DoubleRoom : Room
    {
        public DoubleRoom(int roomNumber, double roomPrice)
        {
            RoomNumber = roomNumber;
            RoomPrice = roomPrice;
            IsOccupied = false; // Set to false by default
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Double Room number {RoomNumber} - Price: {RoomPrice} USD/night - {(IsOccupied ? "Occupied" : "Vacant")}");
        }
    }

}
