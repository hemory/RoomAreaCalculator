using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RoomAreaCalculatorApp
{
   public class Room
    {
        public double Length { get; set; }
        public double Width { get; set; }


        public double CalculateArea(double length, double width)
        {
            return width * length;
        }

        public double CalculateAreaOfAllRooms(List<Room> rooms)
        {

            double sum = 0;

            foreach (var room in rooms)
            {
                double area = CalculateArea(room.Length, room.Width);

                sum += area;

            }

            return sum;

        }
    }

  
}
