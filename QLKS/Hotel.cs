using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace QLKS
{
    internal class Hotel
    {
        private List<Room> roomList;

        public Hotel()
        {
            roomList = new List<Room>();
        }

        public void AddRoom(Room room)
        {
            roomList.Add(room);
        }

        public void DisplayRoomList()
        {
            Console.WriteLine("List of rooms in the hotel:");
            foreach (var room in roomList)
            {
                room.DisplayInfo();
            }
        }

        public void CheckOutRoom(int roomNumber)
        {
            var room = roomList.Find(r => r.RoomNumber == roomNumber && r.IsOccupied);
            if (room != null)
            {
                room.CheckOut();
                Console.WriteLine($"Room {roomNumber} has been checked out.");
            }
            else
            {
                Console.WriteLine($"Cannot check out room {roomNumber}.");
            }
        }
    }

}

