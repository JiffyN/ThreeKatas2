using NUnit.Framework;

namespace PrimeCompositeKata.Tests
{
    [TestFixture]
    public class PrimeCompositeTests
    {
        [Test]
        public void GetOutput_NumberIsPrime_ReturnPrime()
        {
            var result = PrimeComposite.GetOutput(5);

            Assert.That(result, Is.EqualTo("Prime"));
        }

        [Test]
        public void GetOutput_NumberIsCompositeAndOdd_ReturnComposite()
        {
            var result = PrimeComposite.GetOutput(9);

            Assert.That(result, Is.EqualTo("Composite"));
        }
        
        [Test]
        public void GetOutput_StringValue_ThrowValueIsNotOfIntTypeException()
        {
            Assert.That(() => PrimeComposite.GetOutput<string>("f"),
                Throws.Exception.TypeOf<ValueIsNotOfIntTypeException>());
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
        [Test]
        public void FizzBuzzMethod_ValueIsEqualToOne_ReturnTheSameNumber()
        {
            var result = PrimeComposite.GetOutput(1);

            Assert.That(result, Is.EqualTo("1"));
        }
    }
}
