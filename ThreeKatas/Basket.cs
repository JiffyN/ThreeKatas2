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
        public LinkedList<Book> Books { get; set; }
        public Basket()
        {
            Books = new LinkedList<Book>();
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
            List<Book> diffBooks = new List<Book>();
            diffBooks.Add(basket.Books.First.Value);
            if (!basket.Books.First.Value.Title.Equals(basket.Books.First.Next.Value.Title))
            {
                diffBooks.Add(basket.Books.First.Next.Value);
            }
            else
            {
                totalSum = price * basket.Books.Count;
            }
            if (diffBooks.Count == 2)
            {
                totalSum = Count5PercentDiscount(diffBooks.Count);
            }

            return totalSum;
        }
    }
}
