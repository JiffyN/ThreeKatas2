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
        public void Count5PercDisc_TwoDiffBooksInBasket_ReturnCorrectSum()
        {
            var basket = new Basket();
            basket.Books.Add(new Book("Harry Potter and the Sorcerer’s Stone"));
            basket.Books.Add(new Book("Harry Potter and the Chamber of Secrets"));

            var result = basket.Count5PercentDiscount(basket.Books.Count);

            Assert.That(result, Is.EqualTo(15.2));
        }
        [Test]
        public void Count10PercDisc_TwoDiffBooksInBasket_ReturnCorrectSum()
        {
            var basket = new Basket();
            basket.Books.Add(new Book("Harry Potter and the Sorcerer’s Stone"));
            basket.Books.Add(new Book("Harry Potter and the Chamber of Secrets"));
            basket.Books.Add(new Book("Harry Potter and the Prisoner of Azkaban"));

            var result = basket.Count10PercentDiscount(basket.Books.Count);

            Assert.That(result, Is.EqualTo(21.6));
        }
    }
}
