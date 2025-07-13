using System.Diagnostics.Metrics;

namespace SimpleHotelManagementSystem_OOPTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //13. Call the static method PrintWelcomeMessage() from the HotelUtils class to print a welcome message.
            HotelUtils.PrintWelcomeMessage(); // Print welcome message


            //4. In Main method, create one room and one guest, then:
            // 1.Book the room
            // 2.Display room status before and after booking


            // Create a new room with room number 1
            Room room1 = new Room(1);
            // Create a new guest
            Guest guest = new Guest();
            guest.Name = "Salim";
            guest.NationalID ="111111";



            Booking booking = new Booking(room1, guest); // Create a booking for the room and guest

            //----------------
            Console.WriteLine("Guest Name: " + guest.Name);
            Console.WriteLine("Guest National ID: " + guest.NationalID);
            // Display room status before booking
            Console.WriteLine("Room " + room1.RoomNumber + " booked status: " + room1.IsBooked);
            // 13. // Call the static method IsRoomAvailable() from the HotelUtils class to check if the room is available
            if (HotelUtils.IsRoomAvailable(room1)) // Check if the room is available
            {
                Console.WriteLine("Room " + room1.RoomNumber + " is available for booking.");
            }
            else
            {
                Console.WriteLine("Room " + room1.RoomNumber + " is not available for booking.");
            }

            // Book the room
            booking.ConfirmBooking(); // Confirm the booking
            Console.WriteLine("Booking Date : " + booking.BookingTime);
            // Display room status after booking
            Console.WriteLine("Room " + room1.RoomNumber + " booked status: " + room1.IsBooked);

          

            Console.WriteLine("--------------------------------"); // Print a new line for better readability


            //------------------


            Room room2 = new Room(2);
            Guest guest2 = new Guest();
            guest2.Name = "Ahmed";
            guest2.NationalID = "222222";
            Booking booking1 = new Booking(room2, guest2);


            //-------------
            Console.WriteLine("Guest Name: " + guest2.Name);
            Console.WriteLine("Guest National ID: " + guest2.NationalID);
            Console.WriteLine("Room " + room2.RoomNumber + " booked status: " + room2.IsBooked);
            // Check availability
            if (HotelUtils.IsRoomAvailable(room1)) // Check if the room is available
            {
                Console.WriteLine("Room " + room2.RoomNumber + " is available for booking.");
            }
            else
            {
                Console.WriteLine("Room " + room2.RoomNumber + " is not available for booking.");
            }

            booking1.ConfirmBooking();// Confirm the booking
            Console.WriteLine("Booking Date : " + booking.BookingTime); // Display the booking time

            Console.WriteLine("Room " + room2.RoomNumber + " booked status: " + room2.IsBooked);
            // -------








            Console.WriteLine("Total Rooms: " + Room.GetRoomCount());
            




        }
    }
}
