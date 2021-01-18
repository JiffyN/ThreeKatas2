using System;
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
        // Harry Potter and the Half-Blood Prince
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
        public void CountTotalSum_TwoDiffBooksInBasket_ReturnSumWithDisc()
        {
            var basket = new Basket();
            basket.Books.Add(new Book("Harry Potter and the Sorcerer’s Stone"));
            basket.Books.Add(new Book("Harry Potter and the Chamber of Secrets"));

            var result = basket.CountTotalSum(basket);

            Assert.That(result, Is.EqualTo(15.2));
        }
        [Test]
        public void CountTotalSum_ThreeDiffBooksInBasket_ReturnSumWithDisc()
        {
            var basket = new Basket();
            basket.Books.Add(new Book("Harry Potter and the Order of the Phoenix"));
            basket.Books.Add(new Book("Harry Potter and the Order of the Phoenix"));
            basket.Books.Add(new Book("Harry Potter and the Chamber of Secrets"));
            //basket.Books.Add(new Book("Harry Potter and the Chamber of Secrets"));
            //basket.Books.Add(new Book("Harry Potter and the Goblet of Fire"));
            //basket.Books.Add(new Book("Harry Potter and the Goblet of Fire"));
            //basket.Books.Add(new Book("Harry Potter and the Prisoner of Azkaban"));
            //basket.Books.Add(new Book("Harry Potter and the Prisoner of Azkaban"));
            //basket.Books.Add(new Book("Harry Potter and the Half-Blood Prince"));
            //basket.Books.Add(new Book("Harry Potter and the Half-Blood Prince"));

            var result = basket.CountTotalSum(basket);

            Assert.That(result, Is.EqualTo(21.6));
        }

    }
}
