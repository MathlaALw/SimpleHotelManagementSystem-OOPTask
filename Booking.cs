using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHotelManagementSystem_OOPTask
{
    class Booking
    {
        // Booking Fields
        private Room bookedRoom;
        private Guest bookingGuest;

        // 6. A constructor that takes a Room and a Guest
        public Booking(Room room, Guest guest)
        {
            bookedRoom = room;
            bookingGuest = guest;
        }




        //6. A method ConfirmBooking() that:
        
        

        public void ConfirmBooking()
        {
            if (!bookedRoom.IsBooked) // 1.Checks if the room is booked
            {
                // 2.If not, books the room and prints guest name and room number
                bookedRoom.Book();
                this.BookingTime = DateTime.Today; //10. Sets the booking time to the current time
                
                Console.WriteLine("Booking Time is : " + BookingTime);
                Console.WriteLine("Booking confirmed for " + bookingGuest.Name + " in room " + bookedRoom.RoomNumber);
            }
            else
            {
                Console.WriteLine("Room " + bookedRoom.RoomNumber + " is already booked");
            }

        }

        // 10.Add a read-only property BookingTime to the Booking class that stores the time of booking when ConfirmBooking() is called.

        private DateTime bookingTime;
        public DateTime BookingTime
        {
            get
            {
                return bookingTime;
            }
            set
            {
                bookingTime = value; // Sets the booking time in the room
            }
            }
       


    }
}
