using System;
using System.Collections.Generic;
using System.Text;

namespace Login.Service
{
   public interface IAccount
    {
        public void Login(string username, string password);

       public  string UserMail(string email);
    }
}
