using NUnit.Framework;

namespace FizzBuzzKata.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void FizzBuzzMethod_NumberDivisibleByThreeAndFive_ReturnFizzBuzz()
        {
            var result = FizzBuzz.FizzBuzzMethod(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
        [Test]
        public void FizzBuzzMethod_NumberDivisibleByThree_ReturnFizz()
        {
            var result = FizzBuzz.FizzBuzzMethod(6);

            Assert.That(result, Is.EqualTo("Fizz"));
        }
        [Test]
        public void FizzBuzzMethod_NumberNotDivisibleBothByThreeOrFive_ReturnTheSameNumber()
        {
            var result = FizzBuzz.FizzBuzzMethod(4);

            Assert.That(result, Is.EqualTo("4"));
        }
    }
}
