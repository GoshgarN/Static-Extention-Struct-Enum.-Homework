using Login.Service;
using System;

namespace Login
{
    class Program
    {
       public static void Main(string[] args)
        {
            string username = "SuperAdmin";
            string password = "test12345";
            string email = "test@code.edu.az";

            CheckUsers(1);
        }

        public static void CheckUsers(int roles)
        {
            switch (roles)
            {
                case (int)Roles.SuperAdmin:
                    Console.WriteLine("SuperAdmin");
                    break;
                case (int)Roles.Admin:
                    Console.WriteLine("Not Allowed");
                    break;
                case (int)Roles.Member:
                    Console.WriteLine("You are not Admin");
                    break;

                default:
                    break;
            }

        }
    }
}
