using NUnit.Framework;

namespace FizzBuzzKata.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void FizzBuzzMethod_NumberNotDivisibleBothByThreeOrFive_ReturnTheSameNumber()
        {
            var result = FizzBuzz.FizzBuzzMethod(4);

            Assert.That(result, Is.EqualTo("4"));
        }
    }
}
