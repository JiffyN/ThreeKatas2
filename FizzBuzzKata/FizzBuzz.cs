using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public static string FizzBuzzMethod(int number)
        {
            if (number % 3 != 0 && number % 5 != 0)
                return number.ToString();
            return number.ToString();
        }
    }
}
