using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHotelManagementSystem_OOPTask
{
    public static class HotelUtils
    {

        // 13. Static method to print a welcome message
        // Static method PrintWelcomeMessage() 
        public static void PrintWelcomeMessage(string guestName)
        {
            Console.WriteLine("Welcome "+guestName+" to the Hotel Management System!");
          
        }

        // Static method IsRoomAvailable(Room room)
        public static bool IsRoomAvailable(Room room)
        {
            if (room == null)
            {
                Console.WriteLine("Room is null.");
                return false;
            }
            return !room.IsBooked; // Returns true if the room is not booked
        }


    }
}
