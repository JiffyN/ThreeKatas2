using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("HarryPotterKata.Tests")]
namespace ThreeKatas
{
    class Basket
    {
        private const double price = 8;

        private Dictionary<int, int> booksToPercentMap = new Dictionary<int, int>()
        {
            {1, 0},
            {2, 5},
            {3, 10},
            {4, 20},
            {5, 25}
        };
        public List<Book> Books { get; set; }
        public Basket()
        {
            Books = new List<Book>();
        }
        internal double CountPercentDiscount(int numberOfBooks, double discount)
        {
            var sum = numberOfBooks * price;
            var discountSum = sum * (discount / 100);
            return sum - discountSum;
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
                totalSum += CountPercentDiscount(listOfGroupedBooks.Count, booksToPercentMap[listOfGroupedBooks.Count]);
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
        
        internal List<(string, List<Book>)> ReturnBooksGroupedByTitle(List<Book> books)
        {
            return books.GroupBy(b => b.Title).Select(g => 
                (
                    g.Key,
                    g.Select(b => b).ToList()
                )).ToList();
        }
    }
}
