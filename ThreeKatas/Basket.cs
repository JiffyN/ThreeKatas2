using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ThreeKatas
{
    public class Basket
    {
        public const double price = 8;
        public List<Book> Books { get; set; }
        public Basket()
        {
            Books = new List<Book>();
        }
        public double Count5PercentDiscount(int numberOfBooks)
        {
            var sum = numberOfBooks * price;
            var discount = sum * 0.05;
            return sum - discount;
        }

        public double Count10PercentDiscount(int numberOfBooks)
        {
            var sum = numberOfBooks * price;
            var discount = sum * 0.1;
            return sum - discount;
        }

        public double Count20PercentDiscount(int numberOfBooks)
        {
            var sum = numberOfBooks * price;
            var discount = sum * 0.2;
            return sum - discount;
        }

        public double Count25PercentDiscount(int numberOfBooks)
        {
            var sum = numberOfBooks * price;
            var discount = sum * 0.25;
            return sum - discount;
        }
        
        public double CountTotalSum(Basket basket)
        {
            double totalSum = 0;
            List<string> diffBooks = new List<string>() { };
            var list = basket.Books.GroupBy(b => b.Title).Select(g => 
                new
                {
                    Title = g.Key,
                    Count = g.Count(),
                    Books = g.Select(b => b).ToList()
                }).ToList();
            foreach (var g in list)
            {
                if (list.Count == 1)
                {
                    totalSum = g.Books.Count * price;
                    break;
                }
                if (!diffBooks.Contains(g.Title))
                {
                    diffBooks.Add(g.Title);
                    g.Books.Remove(g.Books.First());
                }
            }
            if(diffBooks.Count == 2)
               totalSum += Count5PercentDiscount(diffBooks.Count);
            else if(diffBooks.Count == 3)
                totalSum += Count10PercentDiscount(diffBooks.Count);
            
            return totalSum;
        }
    }
}
