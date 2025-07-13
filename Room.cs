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




        // property to get and set the room number with validation with loop if it fails

        public int RoomNumber
        {
            get
            {
                return roomNumber;
            }
            set
            {
                // 8. Add validation: - Room number must be positive
                if (value < 100)
                {
                    Console.WriteLine("Room number must be greater than 100.");
                    int newRoomNumber;
                    while (!int.TryParse(Console.ReadLine(), out newRoomNumber) || newRoomNumber < 100)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid room number greater than 100.");
                    }
                    roomNumber = newRoomNumber; // Set the new room number
                }
                else if (value == roomNumber)
                {
                    Console.WriteLine("Room number is already booked " + roomNumber + " Please enter a different room number : ");
                    int newRoomNumber;
                    while (!int.TryParse(Console.ReadLine(), out newRoomNumber) || newRoomNumber < 100)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid room number greater than 100.");
                    }
                    roomNumber = newRoomNumber; // Set the new room number
                }
                else if (value <= 0) // Room number must be positive
                {
                    Console.WriteLine("Room number must be a positive integer.");
                    // insert another value
                    Console.WriteLine("Please enter a valid room number must be a positive integer.: ");
                    int newRoomNumber;
                    while (!int.TryParse(Console.ReadLine(), out newRoomNumber) || newRoomNumber > 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid room number must be a positive integer.");
                    }
                }
                else
                {
                    // Set the room number if valid
                    roomNumber = value;
                    totalRooms++; // count only when actually changed
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
            totalRooms++;
        }

        // Constructor that takes room number as a parameter
        public Room(int roomNumber)
        {

             if (roomNumber <100) 
            {
                Console.WriteLine("Room number must be grater than 100.");
                this.roomNumber = 0; // Set to default if invalid
            }
           
            this.roomNumber = roomNumber; // this - refers to the current instance of the class -- roomNumber is the parameter
            totalRooms++; // 9. Increment the total number of rooms
            isBooked = false; // Initialize as not booked

        }




        // 9. Static method GetRoomCount() to get the total number of rooms
        public static int GetRoomCount()
        {
            return totalRooms; // Return the total number of rooms
        }



    }
}
