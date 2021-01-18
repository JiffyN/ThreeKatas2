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
            double totalSum;
            List<Book> diffBooks = new List<Book>() { basket.Books.First.Value };
            List<Book> equalBooks = new List<Book>() { basket.Books.First.Value };
            
            //diffBooks.Add(basket.Books.First.Value);
            basket.Books.RemoveFirst();
            for (int i = 0; i <= basket.Books.Count; i++)
            {
                if (!diffBooks[i].Title.Equals(basket.Books.First.Value.Title))
                {
                    diffBooks.Add(basket.Books.First.Value);
                }
                else
                {
                    equalBooks.Add(basket.Books.First.Value);
                }
                basket.Books.RemoveFirst();
            }
            switch (diffBooks.Count)
            {
                case 2:
                    totalSum = Count5PercentDiscount(diffBooks.Count);
                    break;
                case 3:
                    totalSum = Count10PercentDiscount(diffBooks.Count);
                    break;
                default:
                    totalSum = 0;
                    break;
            }

            totalSum += equalBooks.Count * price;
            return totalSum;
        }
    }
}
