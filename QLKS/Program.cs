using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();

            while (true)
            {
                Console.WriteLine("======= Menu =======");
                Console.WriteLine("1. Add Single Room");
                Console.WriteLine("2. Add Double Room");
                Console.WriteLine("3. Display Room List");
                Console.WriteLine("4. Check Out Room");
                Console.WriteLine("5. Exit");
                Console.WriteLine("====================");

                Console.Write("Select an option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Single Room number: ");
                        int singleRoomNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Single Room price: ");
                        double singleRoomPrice = Convert.ToDouble(Console.ReadLine());
                        hotel.AddRoom(new SingleRoom(singleRoomNumber, singleRoomPrice));
                        break;

                    case 2:
                        Console.Write("Enter Double Room number: ");
                        int doubleRoomNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Double Room price: ");
                        double doubleRoomPrice = Convert.ToDouble(Console.ReadLine());
                        hotel.AddRoom(new DoubleRoom(doubleRoomNumber, doubleRoomPrice));
                        break;

                    case 3:
                        hotel.DisplayRoomList();
                        break;

                    case 4:
                        Console.Write("Enter the room number to check out: ");
                        int roomNumberToCheckOut = Convert.ToInt32(Console.ReadLine());
                        hotel.CheckOutRoom(roomNumberToCheckOut);
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select again.");
                        break;
                }
            }
        }

    }
}
