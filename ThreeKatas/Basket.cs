using System;
using System.Collections.Generic;
using System.Linq;

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
            if (basket.Books.Count == 0)
            {
                throw new ArgumentNullException("The basket is empty");
            }
            double totalSum = 0;
            bool listIsNotEmpty = true;
            var listOfGroupedBooks = ReturnBooksGroupedByTitle(basket.Books).ToList();
            if (listOfGroupedBooks.Count > 5)
            {
                throw new MoreThanFiveGroupsException("There are more than 5 groups of books in the basket");
            }
            while (listIsNotEmpty)
            {
                if (listOfGroupedBooks.Count == 1)
                {
                    foreach (var g in listOfGroupedBooks)
                    {
                        totalSum += g.Item2.Count * price;
                        return totalSum;
                    }
                }
                else if (listOfGroupedBooks.Count == 2)
                    totalSum += Count5PercentDiscount(listOfGroupedBooks.Count);
                else if (listOfGroupedBooks.Count == 3)
                    totalSum += Count10PercentDiscount(listOfGroupedBooks.Count);
                else if (listOfGroupedBooks.Count == 4)
                    totalSum += Count20PercentDiscount(listOfGroupedBooks.Count);
                else if (listOfGroupedBooks.Count == 5)
                    totalSum += Count25PercentDiscount(listOfGroupedBooks.Count);
                foreach (var g in listOfGroupedBooks.ToList())
                {
                    g.Item2.Remove(g.Item2.First());
                    if (g.Item2.Count == 0)
                        listOfGroupedBooks.Remove(g);
                }
                if (listOfGroupedBooks.Count == 0)
                    listIsNotEmpty = false;
            }
            return totalSum;
        }

        public IEnumerable<(string, List<Book>)> ReturnBooksGroupedByTitle(List<Book> books)
        {
            return books.GroupBy(b => b.Title).Select(g => 
                (
                    g.Key,
                    g.Select(b => b).ToList()
                ));
        }
    }
}
