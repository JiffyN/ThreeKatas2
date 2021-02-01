using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using NUnit.Framework;
using ThreeKatas;

namespace HarryPotterKata.Tests
{
    [TestFixture]
    class BasketTests
    {
        // Harry Potter and the Sorcerer’s Stone
        // Harry Potter and the Chamber of Secrets
        // Harry Potter and the Prisoner of Azkaban
        // Harry Potter and the Goblet of Fire
        // Harry Potter and the Order of the Phoenix

        private Basket basket;
        [SetUp]
        public void SetUp()
        {
            basket = new Basket();
        }

        [Test]
        [TestCase(2, 5, 15.2)]
        [TestCase(3, 10, 21.6)]
        [TestCase(4, 20, 25.6)]
        [TestCase(5, 25, 30.0)]
        public void CountPercentDiscount_ValidNumberOfBooks_ReturnSumWithDisc(int numOfBooks, 
                                                                              int discount, 
                                                                              double expectedResult)
        {
            var result = basket.CountPercentDiscount(numOfBooks, discount);

            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void CountTotalSum_TwoEqualBooksInBasket_ReturnSumWithoutDisc()
        {
            basket.Books.Add(new Book("Harry Potter and the Sorcerer’s Stone"));
            basket.Books.Add(new Book("Harry Potter and the Sorcerer’s Stone"));

            var result = basket.CountTotalSum(basket);

            Assert.AreEqual(16.0, result);
        }
        [Test]
        public void CountTotalSum_TwoDiffBooksInBasket_ReturnSumWithDisc5Perc()
        {
            basket.Books.Add(new Book("Harry Potter and the Sorcerer’s Stone"));
            basket.Books.Add(new Book("Harry Potter and the Chamber of Secrets"));

            var result = basket.CountTotalSum(basket);
            
            Assert.AreEqual(15.2, result);
        }
        [Test]
        public void CountTotalSum_ThreeDiffBooksInBasket_ReturnSumWithDisc10Perc()
        {
            basket.Books.Add(new Book("Harry Potter and the Order of the Phoenix"));
            basket.Books.Add(new Book("Harry Potter and the Prisoner of Azkaban"));
            basket.Books.Add(new Book("Harry Potter and the Chamber of Secrets"));

            var result = basket.CountTotalSum(basket);

            Assert.AreEqual(21.6, result);
        }

        [Test]
        public void CountTotalSum_ThreeBooksButTwoEqual_ReturnSumWithDisc()
        {
            basket.Books.Add(new Book("Harry Potter and the Order of the Phoenix"));
            basket.Books.Add(new Book("Harry Potter and the Prisoner of Azkaban"));
            basket.Books.Add(new Book("Harry Potter and the Prisoner of Azkaban"));

            var result = basket.CountTotalSum(basket);

            Assert.AreEqual(23.2, result);
        }

        [Test]
        public void CountTotalSum_FourDiffBooks_ReturnSumWithDisc20Percent()
        {
            basket.Books.Add(new Book("Harry Potter and the Chamber of Secrets"));
            basket.Books.Add(new Book("Harry Potter and the Prisoner of Azkaban"));
            basket.Books.Add(new Book("Harry Potter and the Goblet of Fire"));
            basket.Books.Add(new Book("Harry Potter and the Order of the Phoenix"));
            
            var result = basket.CountTotalSum(basket);

            Assert.AreEqual(25.6, result);
        }

        [Test]
        public void CountTotalSum_FiveDiffBooks_ReturnSumWithDisc25Percent()
        {
            basket.Books.Add(new Book("Harry Potter and the Chamber of Secrets"));
            basket.Books.Add(new Book("Harry Potter and the Prisoner of Azkaban"));
            basket.Books.Add(new Book("Harry Potter and the Goblet of Fire"));
            basket.Books.Add(new Book("Harry Potter and the Order of the Phoenix"));
            basket.Books.Add(new Book("Harry Potter and the Sorcerer’s Stone"));

            var result = basket.CountTotalSum(basket);
            
            Assert.AreEqual(30.0, result);
        }

        [Test]
        public void CountTotalSum_FiveBooksButTwoEqual_ReturnSumWithDisc25Percent()
        {
            basket.Books.Add(new Book("Harry Potter and the Chamber of Secrets"));
            basket.Books.Add(new Book("Harry Potter and the Prisoner of Azkaban"));
            basket.Books.Add(new Book("Harry Potter and the Goblet of Fire"));
            basket.Books.Add(new Book("Harry Potter and the Order of the Phoenix"));
            basket.Books.Add(new Book("Harry Potter and the Order of the Phoenix"));

            var result = basket.CountTotalSum(basket);

            Assert.AreEqual(33.6, result);
        }

        [Test]
        public void CountTotalSum_EmptyBasket_ReturnArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => basket.CountTotalSum(basket));
        }

        [Test]
        public void CountTotalSum_MoreThanFiveGroupsInBasket_ReturnMoreThanFiveGroupsException()
        {
            basket.Books.Add(new Book("Harry Potter and the Chamber of Secrets"));
            basket.Books.Add(new Book("Harry Potter and the Prisoner of Azkaban"));
            basket.Books.Add(new Book("Harry Potter and the Goblet of Fire"));
            basket.Books.Add(new Book("Harry Potter and the Order of the Phoenix"));
            basket.Books.Add(new Book("Harry Potter and the Sorcerer’s Stone"));
            basket.Books.Add(new Book("Harry Potter and the Deathly Hallows"));

            Assert.Throws<MoreThanFiveGroupsException>(() => basket.CountTotalSum(basket));
        }

        [Test]
        public void ReturnBooksGroupedByTitle_WhenCalled_ReturnListOfBooksGroupedByTitle()
        {
            var expected = new List<(string title, List<Book> books)>
            {
                ("Harry Potter and the Chamber of Secrets", new List<Book>()
                {
                    new Book("Harry Potter and the Chamber of Secrets")
                }),
                ("Harry Potter and the Prisoner of Azkaban", new List<Book>()
                {
                    new Book("Harry Potter and the Prisoner of Azkaban")
                }),
                ("Harry Potter and the Goblet of Fire", new List<Book>()
                {
                    new Book("Harry Potter and the Goblet of Fire")
                }),
                ("Harry Potter and the Order of the Phoenix", new List<Book>()
                {
                    new Book("Harry Potter and the Order of the Phoenix"),
                    new Book("Harry Potter and the Order of the Phoenix")
                }),
            };
            basket.Books.Add(new Book("Harry Potter and the Chamber of Secrets"));
            basket.Books.Add(new Book("Harry Potter and the Prisoner of Azkaban"));
            basket.Books.Add(new Book("Harry Potter and the Goblet of Fire"));
            basket.Books.Add(new Book("Harry Potter and the Order of the Phoenix"));
            basket.Books.Add(new Book("Harry Potter and the Order of the Phoenix"));

            var result = basket.ReturnBooksGroupedByTitle(basket.Books).ToList();

            foreach (var valueTuple in result)
            {
                var expectedValue = expected.Single(_ => _.title == valueTuple.Item1);
                CollectionAssert.AreEquivalent(expectedValue.books, valueTuple.Item2);
            }
        }
    }
}
