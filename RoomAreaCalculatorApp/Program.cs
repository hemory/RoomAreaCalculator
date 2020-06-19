using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomAreaCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Room roomObj = new Room();
            Console.WriteLine("How many rooms would you like to calculate?");
            int numberOfRooms = Convert.ToInt16(Console.ReadLine());

            List<Room> rooms = new List<Room>();

            for (int i = 0; i < numberOfRooms; i++)
            {

                Console.WriteLine($"Let's get the length of Room Number {i + 1}?");
                Console.WriteLine("How many feet?");

                roomObj.Length = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Let's get the width of Room Number {i + 1}?");
                roomObj.Width = Convert.ToDouble(Console.ReadLine());

                rooms.Add(roomObj);

            }

            double totalRoomArea = roomObj.CalculateAreaOfAllRooms(rooms);

            Console.WriteLine($"The total area of all these rooms is {totalRoomArea}");

            Console.WriteLine("Press ENTER to exit");
            Console.ReadLine();

        }
    }
}
