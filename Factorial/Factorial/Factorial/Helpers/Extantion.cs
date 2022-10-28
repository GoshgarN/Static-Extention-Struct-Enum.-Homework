using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial.Helpers
{
   public static class Extantion
    {
        public static int Factorial(this int a)
        {
            if (a <= 1)
                return 1;
            else
                return a * Factorial(a - 1);



        }

    }
}
