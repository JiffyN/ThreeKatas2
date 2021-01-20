using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ThreeKatas
{
    class Program
    {
        // Harry Potter and the Sorcerer’s Stone
        // Harry Potter and the Chamber of Secrets
        // Harry Potter and the Prisoner of Azkaban
        // Harry Potter and the Goblet of Fire
        // Harry Potter and the Order of the Phoenix
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book("Harry Potter and the Sorcerer’s Stone"),
                new Book("Harry Potter and the Sorcerer’s Stone"),
                new Book("Harry Potter and the Prisoner of Azkaban"),
                new Book("Harry Potter and the Prisoner of Azkaban"),
                new Book("Harry Potter and the Order of the Phoenix"),
            };
            Basket basket = new Basket(){Books = books};
            Console.WriteLine();
            Console.WriteLine($"The total sum of the books is {basket.CountTotalSum(basket)} dollars.");
            Console.ReadKey();
        }
    }
}
