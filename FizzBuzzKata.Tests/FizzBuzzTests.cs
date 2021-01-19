using NUnit.Framework;

namespace FizzBuzzKata.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void FizzBuzzMethod_NumberDivisibleByThreeAndFive_ReturnFizzBuzz()
        {
            var result = FizzBuzz.FizzBuzzMethod<int>(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
        [Test]
        public void FizzBuzzMethod_NumberDivisibleByThree_ReturnFizz()
        {
            var result = FizzBuzz.FizzBuzzMethod<int>(6);

            Assert.That(result, Is.EqualTo("Fizz"));
        }
        [Test]
        public void FizzBuzzMethod_NumberDivisibleByFive_ReturnBuzz()
        {
            var result = FizzBuzz.FizzBuzzMethod<int>(10);

            Assert.That(result, Is.EqualTo("Buzz"));
        }
        [Test]
        public void FizzBuzzMethod_NumberNotDivisibleBothByThreeOrFive_ReturnTheSameNumber()
        {
            var result = FizzBuzz.FizzBuzzMethod<int>(4);

            Assert.That(result, Is.EqualTo("4"));
        }

        [Test]
        public void FizzBuzzMethod_NotIntValue_ThrowException()
        {
            Assert.That(() => FizzBuzz.FizzBuzzMethod<string>("f"), 
                Throws.Exception.TypeOf<NonIntTypeException>());
        }
    }
}
