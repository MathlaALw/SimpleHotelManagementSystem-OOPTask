using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SimpleHotelManagementSystem_OOPTask
{
    public class Room
    {

        // 1. Add Fields to Room
        // Field to store the room number
        private int roomNumber;
        // Field to store whether the room is booked or not
        private bool isBooked;

        // 9. Static field to keep track of the total number of rooms
        private static int totalRooms = 0;

        // property to get and set the room number
        public int RoomNumber
        {
            get
            {
                return roomNumber;
            }
            set
            {
                if (roomNumber <= 0 ) //8. Add validation: - Room number must be positive 
                {
                    Console.WriteLine("Room number must be greater than zero.");
                }
                else if (value <= 0 || value > 100) // 11. Room number cannot be below 100
                {
                    Console.WriteLine("Room number must be between 1 and 100.");
                }
                else if (value == roomNumber) // Check if the new room number is the same as the current one
                {
                    Console.WriteLine("Room number is already set to " + roomNumber);
                }
                else
                {
                    RoomNumber = roomNumber; // Set the room number if valid
                    totalRooms++; // 9. Increment the total number 
                }

            }

        }




        // property to get whether the room is booked or not


        public bool IsBooked
        {

            get
            {
                return isBooked;
            }


        }

        // 3. Create Methods to Book and Free the room
        // Method that sets isBooked to true
        public void Book()
        {
            isBooked = true;
        }

        // Method that sets isBooked to false
        public void Free()
        {
            isBooked = false;
        }


        //5. Add constructor overloads to Room

        // Default constructor
        public Room()
        {
            roomNumber = 0; // Default room number
            isBooked = false; // Initialize as not booked

        }

        // Constructor that takes room number as a parameter
        public Room(int roomNumber)
        {
            if (roomNumber <= 0) //8. Add validation: - Room number must be positive
            {
                Console.WriteLine("Room number must be greater than zero.");
            }
            else
            {
                this.roomNumber = roomNumber; // this - refers to the current instance of the class -- roomNumber is the parameter
                isBooked = false; // Initialize as not booked
                totalRooms++; // 9. Increment the total number of rooms
            }

            
        }




        // 9. Static method GetRoomCount() to get the total number of rooms
        public static int GetRoomCount()
        {
            return totalRooms; // Return the total number of rooms
        }



    }
}
