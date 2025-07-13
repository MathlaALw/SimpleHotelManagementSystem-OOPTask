using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace SimpleHotelManagementSystem_OOPTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////13. Call the static method PrintWelcomeMessage() from the HotelUtils class to print a welcome message.
            //HotelUtils.PrintWelcomeMessage(); // Print welcome message


            //4. In Main method, create one room and one guest, then:
            // 1.Book the room
            // 2.Display room status before and after booking
            
            // Create a new guest
            Guest guest = new Guest();


            Console.WriteLine("Enter guest name: ");
            guest.Name = Console.ReadLine();

            Console.WriteLine("Enter guest national ID: ");
            guest.NationalID = Console.ReadLine();

          

            Console.WriteLine("Enter room number: ");
            int roomNumber = int.Parse(Console.ReadLine()); // Set the room number from user input

           
            while (!int.TryParse(Console.ReadLine(), out roomNumber) || roomNumber < 100)
            {
                Console.WriteLine(" Room number must be 100 or higher. Try again:");
            }

            // Create a new room with room number 1
            Room room = new Room(roomNumber);
            // 13. // Call the static method IsRoomAvailable() from the HotelUtils class to check if the room is available
            if (HotelUtils.IsRoomAvailable(room)) // Check if the room is available
            {
                Console.WriteLine("Room " + room.RoomNumber + " is available for booking.");
            }
            else
            {
                Console.WriteLine("Room " + room.RoomNumber + " is not available for booking.");
            }


            //13. Call the static method PrintWelcomeMessage() from the HotelUtils class to print a welcome message.
            HotelUtils.PrintWelcomeMessage(guest.Name); // Print welcome message



            Booking booking = new Booking(room, guest); // Create a booking for the room and guest

            //----------------
            Console.WriteLine("Guest Name: " + guest.Name);
            Console.WriteLine("Guest National ID: " + guest.NationalID);
            // Display room status before booking
            Console.WriteLine("Room " + room.RoomNumber + " booked status: " + room.IsBooked);
            
            // Book the room
            booking.ConfirmBooking(); // Confirm the booking
            //Console.WriteLine("Booking Date : " + booking.BookingTime);
            // Display room status after booking
            Console.WriteLine("Room " + room.RoomNumber + " booked status: " + room.IsBooked);

          

            Console.WriteLine("--------------------------------"); // Print a new line for better readability


            //------------------


            //Room room2 = new Room(2);
            //Guest guest2 = new Guest();
            //guest2.Name = "Ahmed";
            //guest2.NationalID = "222222";
            //Booking booking1 = new Booking(room2, guest2);

            //HotelUtils.PrintWelcomeMessage(guest2.Name); // Print welcome message

            ////-------------
            //Console.WriteLine("Guest Name: " + guest2.Name);
            //Console.WriteLine("Guest National ID: " + guest2.NationalID);
            //Console.WriteLine("Room " + room2.RoomNumber + " booked status: " + room2.IsBooked);
            //// Check availability
            //if (HotelUtils.IsRoomAvailable(room1)) // Check if the room is available
            //{
            //    Console.WriteLine("Room " + room2.RoomNumber + " is available for booking.");
            //}
            //else
            //{
            //    Console.WriteLine("Room " + room2.RoomNumber + " is not available for booking.");
            //}

            //booking1.ConfirmBooking();// Confirm the booking
            ////Console.WriteLine("Booking Date : " + booking.BookingTime); // Display the booking time

            //Console.WriteLine("Room " + room2.RoomNumber + " booked status: " + room2.IsBooked);
            //// -------








            Console.WriteLine("Total Rooms: " + Room.GetRoomCount());
            




        }
    }
}
