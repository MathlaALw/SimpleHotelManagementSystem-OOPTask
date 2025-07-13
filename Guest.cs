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
                
               
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Name cannot be empty or null.");
                }
                else if (value.Length < 3) // 11. Guest name must be at least 3 characters
                {
                    Console.WriteLine("Name must be at least 3 characters long.");
                }
                else
                {
                    // Set the name if valid
                    name = value;
                }


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
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("National ID cannot be empty or null.");
                }
                else
                {
                    // Set the National ID if valid
                    nationalID = value;
                }
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
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Password cannot be empty or null.");
                }
                else
                {
                    // Set the password if valid
                    password = value;
                }
            }
        }


    }
}
