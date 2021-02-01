using NUnit.Framework;

namespace FizzBuzzKata.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(15, "FizzBuzz")] 
        [TestCase(6, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(4, "4")]
        public void FizzBuzzMethod_NumberFromOneToHundred_ReturnValidValue(int number, string expectedResult)
        {
            var result = FizzBuzz.FizzBuzzMethod(number);

            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void FizzBuzzMethod_ValueIsMoreThanHundred_ThrowsValueIsNotInRangeException()
        {
            Assert.Throws<ValueIsNotInRangeException>(() => FizzBuzz.FizzBuzzMethod(101));
        }

        [Test]
        public void FizzBuzzMethod_ValueIsLessThanOne_ThrowsValueIsNotInRangeException()
        {
            Assert.Throws<ValueIsNotInRangeException>(() => FizzBuzz.FizzBuzzMethod(0));
        }
    }
}
