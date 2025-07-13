using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHotelManagementSystem_OOPTask
{
    class Guest
    {
        // Fields for Guest class
        private string name;
        private string nationalID;




        // 11. Password field
        private string password;

        // 2. Add auto-properties for Name and NationalID
        // Auto-property: Name
        public string Name
        {
            get
            {
               
                return name;
            }
            set
            {
                // 8. Validation: Name must not be empty or null
                bool isValid = true;
                string username = value; // Set the name to the provided value
                do {
                    isValid = true; // Reset isValid to true for each iteration
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        Console.WriteLine("Name cannot be empty or null. Please enter a valid name:");
                        value = Console.ReadLine(); // Read a new value from the console
                        isValid = false; // Set isValid to false to continue the loop
                    }
                    else if (value.Length < 3) // 11. Guest name must be at least 3 characters
                    {
                        Console.WriteLine("Name must be at least 3 characters long. Please enter a valid name:");
                        value = Console.ReadLine(); // Read a new value from the console
                        isValid = false; // Set isValid to false to continue the loop
                    }
                    else
                    {
                        // Set the name if valid
                        name = value;
                    }
                } while (!isValid); // Continue until a valid name is provided

                


            }
        }

        // Auto-property: NationalID
        public string NationalID
        {
            get
            {

                return nationalID;

            }
            set
            {
                // 8. Validation: National ID must not be empty or null
                bool isValid = true;
                string nationalId = value; // Set the National ID to the provided value
                do
                {
                    isValid = true;
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        Console.WriteLine("National ID cannot be empty or null. Please enter a valid National ID:");
                        value = Console.ReadLine(); // Read a new value from the console
                        isValid = false; // Set isValid to false to continue the loop
                    }
                    else if (value.Length != 8) // 11. National ID must be exactly 8 characters long
                    {
                        Console.WriteLine("National ID must be exactly 8 characters long. Please enter a valid National ID:");
                        value = Console.ReadLine(); // Read a new value from the console
                        isValid = false; // Set isValid to false to continue the loop
                    }
                    else
                    {
                        // Set the National ID if valid
                        nationalID = value;
                        isValid = true; 
                    }

                }
                while (!isValid);
            }
        }



        // 5.Add constructor overloads to Guest
        // Default constructor
        public Guest()
        {
            name = "Sara"; // Default name
            nationalID = "99999999"; // Default National ID
        }

        // Parameterized constructor

        public Guest(string name, string nationalID)
        {
            this.Name = name;
            this.NationalID = nationalID;
        }



        //11. Password property with validation
        public string Password
        {
           
            set
            {
                // 8. Validation: Password must not be empty or null
                bool isValid = true;
                string password = value; // Set the password to the provided value
                do
                {
                    isValid = true; // Reset isValid to true for each iteration
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        Console.WriteLine("Password cannot be empty or null. Please enter a valid password:");
                        value = Console.ReadLine(); // Read a new value from the console
                        isValid = false; // Set isValid to false to continue the loop
                    }
                    else if (value.Length < 6) // 11. Password must be at least 6 characters long
                    {
                        Console.WriteLine("Password must be at least 6 characters long. Please enter a valid password:");
                        value = Console.ReadLine(); // Read a new value from the console
                        isValid = false; // Set isValid to false to continue the loop
                    }
                    else
                    {
                        // Set the password if valid
                        password = value;
                    }
                } while (!isValid); // Continue until a valid password is provided
            }
        }


    }
}
