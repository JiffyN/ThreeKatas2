using System;
using NUnit.Framework;
using ThreeKatas;

namespace HarryPotterKata.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Count5PercDisc_TwoDiffBooksInBasket_ReturnCorrectSum()
        {
            var basket = new Basket();
            basket.Books.Add(new Book("Harry Potter and the Sorcerer’s Stone"));
            basket.Books.Add(new Book("Harry Potter and the Chamber of Secrets"));

            var result = basket.Count5PercentDiscount();

            Assert.That(result, Is.EqualTo(15.2));
        }
    }
}
