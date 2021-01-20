using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number from 1 to 100: ");
            var number = Console.ReadLine();
            string result = FizzBuzz.FizzBuzzMethod(Convert.ToInt32(number));

            Console.WriteLine($"The result: {result}");
            
            Console.ReadKey();
        }
    }
}
