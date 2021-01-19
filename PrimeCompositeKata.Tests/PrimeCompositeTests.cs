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
    }
}
