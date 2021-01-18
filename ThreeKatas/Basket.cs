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
            bool listIsNotEmpty = true;
            var list = basket.Books.GroupBy(b => b.Title).Select(g => 
                new
                {
                    Title = g.Key,
                    Books = g.Select(b => b).ToList()
                }).ToList();
            
            while (listIsNotEmpty)
            {
                if (list.Count == 1)
                {
                    foreach (var g in list)
                    {
                        totalSum += g.Books.Count * price;
                        return totalSum;
                    }
                }
                else if (list.Count == 2)
                    totalSum += Count5PercentDiscount(list.Count);
                else if (list.Count == 3)
                    totalSum += Count10PercentDiscount(list.Count);
                else if (list.Count == 4)
                    totalSum += Count20PercentDiscount(list.Count);
                else if (list.Count == 5)
                    totalSum += Count25PercentDiscount(list.Count);
                foreach (var g in list.ToList())
                {
                    g.Books.Remove(g.Books.First());
                    if (g.Books.Count == 0)
                        list.Remove(g);
                }
                
                if (list.Count == 0)
                    listIsNotEmpty = false;
            }
            return totalSum;
        }
    }
}
