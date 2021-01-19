using System.Collections.Generic;
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
        [Test]
        public void Count5PercDisc_TwoBooksArePassed_ReturnSumWithDisc()
        {
            var basket = new Basket();

            var result = basket.Count5PercentDiscount(2);

            Assert.That(result, Is.EqualTo(15.2));
        }
        [Test]
        public void Count10PercDisc_ThreeBooksArePassed_ReturnSumWithDisc()
        {
            var basket = new Basket();

            var result = basket.Count10PercentDiscount(3);

            Assert.That(result, Is.EqualTo(21.6));
        }

        [Test]
        public void Count20PercDisc_FourBooksArePassed_ReturnSumWithDisc()
        {
            var basket = new Basket();

            var result = basket.Count20PercentDiscount(4);

            Assert.That(result, Is.EqualTo(25.6));
        }
        [Test]
        public void Count25PercDisc_FiveBooksArePassed_ReturnSumWithDisc()
        {
            var basket = new Basket();
            
            var result = basket.Count25PercentDiscount(5);

            Assert.That(result, Is.EqualTo(30.0));
        }
        [Test]
        public void CountTotalSum_TwoEqualBooksInBasket_ReturnSumWithoutDisc()
        {
            var basket = new Basket();
            basket.Books.Add(new Book("Harry Potter and the Sorcerer’s Stone"));
            basket.Books.Add(new Book("Harry Potter and the Sorcerer’s Stone"));

            var result = basket.CountTotalSum(basket);

            Assert.That(result, Is.EqualTo(16.0));
        }
        [Test]
        public void CountTotalSum_TwoDiffBooksInBasket_ReturnSumWithDisc5Perc()
        {
            var basket = new Basket();
            basket.Books.Add(new Book("Harry Potter and the Sorcerer’s Stone"));
            basket.Books.Add(new Book("Harry Potter and the Chamber of Secrets"));

            var result = basket.CountTotalSum(basket);

            Assert.That(result, Is.EqualTo(15.2));
        }
        [Test]
        public void CountTotalSum_ThreeDiffBooksInBasket_ReturnSumWithDisc10Perc()
        {
            var basket = new Basket();
            basket.Books.Add(new Book("Harry Potter and the Order of the Phoenix"));
            basket.Books.Add(new Book("Harry Potter and the Prisoner of Azkaban"));
            basket.Books.Add(new Book("Harry Potter and the Chamber of Secrets"));

            var result = basket.CountTotalSum(basket);

            Assert.That(result, Is.EqualTo(21.6));
        }

        [Test]
        public void CountTotalSum_ThreeBooksButTwoEqual_ReturnSumWithDisc()
        {
            var basket = new Basket();
            basket.Books.Add(new Book("Harry Potter and the Order of the Phoenix"));
            basket.Books.Add(new Book("Harry Potter and the Prisoner of Azkaban"));
            basket.Books.Add(new Book("Harry Potter and the Prisoner of Azkaban"));

            var result = basket.CountTotalSum(basket);

            Assert.That(result, Is.EqualTo(23.2));
        }

        [Test]
        public void CountTotalSum_FourDiffBooks_ReturnSumWithDisc20Percent()
        {
            var basket = new Basket();
            basket.Books.Add(new Book("Harry Potter and the Chamber of Secrets"));
            basket.Books.Add(new Book("Harry Potter and the Prisoner of Azkaban"));
            basket.Books.Add(new Book("Harry Potter and the Goblet of Fire"));
            basket.Books.Add(new Book("Harry Potter and the Order of the Phoenix"));
            
            var result = basket.CountTotalSum(basket);

            Assert.That(result, Is.EqualTo(25.6));
        }

        [Test]
        public void CountTotalSum_FiveDiffBooks_ReturnSumWithDisc25Percent()
        {
            var basket = new Basket();
            basket.Books.Add(new Book("Harry Potter and the Chamber of Secrets"));
            basket.Books.Add(new Book("Harry Potter and the Prisoner of Azkaban"));
            basket.Books.Add(new Book("Harry Potter and the Goblet of Fire"));
            basket.Books.Add(new Book("Harry Potter and the Order of the Phoenix"));
            basket.Books.Add(new Book("Harry Potter and the Sorcerer’s Stone"));

            var result = basket.CountTotalSum(basket);

            Assert.That(result, Is.EqualTo(30.0));
        }

        [Test]
        public void CountTotalSum_FiveBooksButTwoEqual_ReturnSumWithDisc25Percent()
        {
            var basket = new Basket();
            basket.Books.Add(new Book("Harry Potter and the Chamber of Secrets"));
            basket.Books.Add(new Book("Harry Potter and the Prisoner of Azkaban"));
            basket.Books.Add(new Book("Harry Potter and the Goblet of Fire"));
            basket.Books.Add(new Book("Harry Potter and the Order of the Phoenix"));
            basket.Books.Add(new Book("Harry Potter and the Order of the Phoenix"));

            var result = basket.CountTotalSum(basket);

            Assert.That(result, Is.EqualTo(33.6));
        }

        [Test]
        public void CountTotalSum_EmptyBasket_ReturnArgumentNullException()
        {
            var basket = new Basket();

            Assert.That(() => basket.CountTotalSum(basket), Throws.ArgumentNullException);
        }

        [Test]
        public void CountTotalSum_MoreThanFiveGroupsInBasket_ReturnMoreThanFiveGroupsException()
        {
            var basket = new Basket();
            basket.Books.Add(new Book("Harry Potter and the Chamber of Secrets"));
            basket.Books.Add(new Book("Harry Potter and the Prisoner of Azkaban"));
            basket.Books.Add(new Book("Harry Potter and the Goblet of Fire"));
            basket.Books.Add(new Book("Harry Potter and the Order of the Phoenix"));
            basket.Books.Add(new Book("Harry Potter and the Sorcerer’s Stone"));
            basket.Books.Add(new Book("Harry Potter and the Deathly Hallows"));

            Assert.That(() => basket.CountTotalSum(basket), 
                Throws.Exception.TypeOf<MoreThanFiveGroupsException>());
        }

        [Test]
        public void ReturnBooksGroupedByTitle_WhenCalled_ReturnListOfBooksGroupedByTitle()
        {
            var expected = new List<(string title, List<Book> books)>
            {
                ("Harry Potter and the Chamber of Secrets", new List<Book>(1)),
                ("Harry Potter and the Prisoner of Azkaban", new List<Book>(1)),
                ("Harry Potter and the Goblet of Fire", new List<Book>(1)),
                ("Harry Potter and the Order of the Phoenix", new List<Book>(2)),
            };

            var basket = new Basket();
            basket.Books.Add(new Book("Harry Potter and the Chamber of Secrets"));
            basket.Books.Add(new Book("Harry Potter and the Prisoner of Azkaban"));
            basket.Books.Add(new Book("Harry Potter and the Goblet of Fire"));
            basket.Books.Add(new Book("Harry Potter and the Order of the Phoenix"));
            basket.Books.Add(new Book("Harry Potter and the Order of the Phoenix"));

            var result = basket.ReturnBooksGroupedByTitle(basket.Books).ToList();

            foreach (var valueTuple in result)
            {
                var expectedValue = expected.Single(_ => _.title == valueTuple.Item1);
                Assert.That(expectedValue.books, Is.EqualTo(valueTuple.Item2));
            }
        }
    }
}
