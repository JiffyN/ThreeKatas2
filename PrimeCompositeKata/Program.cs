using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCompositeKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number from 1 to 100: ");
            var number = Console.ReadLine();
            string result = PrimeComposite.GetOutput(Convert.ToInt32(number));

            if (!result.Equals("Prime") && !result.Equals("Composite"))
                if (Convert.ToInt32(result) % 2 == 0)
                {
                    Console.WriteLine($"The number {number} is odd.");
                }
                else
                {
                    Console.WriteLine($"The number {number} is neither prime, nor composite.");
                }
            else
            {
                Console.WriteLine($"The number {number} is {result}");
            }
            Console.ReadKey();
        }
    }
    
}
