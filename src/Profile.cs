using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTASKS.src
{
    // Profile class with properties for username and password
    internal class Profile
    {
        public string userName;
        private string password;

        public string _password
        {
            get
            {
                return password;
            }
            set
            {
                if(value.Length < 6)
                {
                    Console.WriteLine("Password must be at least 6 characters long.");
                }
                else password = value;
            }
        }
    }
}
