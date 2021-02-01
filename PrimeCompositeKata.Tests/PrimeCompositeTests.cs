using System.Runtime.InteropServices;
using NUnit.Framework;

namespace PrimeCompositeKata.Tests
{
    [TestFixture]
    public class PrimeCompositeTests
    {
        [Test]
        [TestCase(5, "Prime")]
        [TestCase(9, "Composite")]
        [TestCase(1, "1")]
        public void GetOutput_ValidNumber_ReturnValidResult(int number, string expectedResult)
        {
            var result = PrimeComposite.GetOutput(number);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void FizzBuzzMethod_ValueIsMoreThanHundred_ThrowsValueIsNotInRangeException()
        {
            Assert.That(() => PrimeComposite.GetOutput(101),
                Throws.Exception.TypeOf<ValueIsNotInRangeException>());
        }

        [Test]
        public void FizzBuzzMethod_ValueIsLessThanOne_ThrowsValueIsNotInRangeException()
        {
            Assert.That(() => PrimeComposite.GetOutput(0),
                Throws.Exception.TypeOf<ValueIsNotInRangeException>());
        }
    }
}
