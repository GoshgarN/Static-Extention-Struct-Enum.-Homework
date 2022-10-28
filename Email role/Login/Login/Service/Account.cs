using System;
using System.Collections.Generic;
using System.Text;

namespace Login.Service
{
    public class Account : IAccount
    {
        public void Login(string username, string password)
        {
            Console.WriteLine("You are logged in");
        }

        public string UserMail(string email)
        {
            return email;
        }
    }

    public enum Roles
    {
        SuperAdmin = 1,
        Admin = 2,
        Member = 3,

    }


}
