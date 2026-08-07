using NUnit.Framework;
using Unit_Testing_Examples;

namespace NUnit_Test
{
    public class SSNValidatorTests
    {

        [Test]
        public void ValidSSN_ReturnsTrue()
        {
            bool result =
                SSNValidator.IsValidSSN(
                    "123-45-6789"
                );


            Assert.That(result, Is.True);
        }


        [Test]
        public void SSNWithoutHyphen_ReturnsFalse()
        {
            bool result =
                SSNValidator.IsValidSSN(
                    "123456789"
                );


            Assert.That(result, Is.False);
        }


        [Test]
        public void SSNWithWrongDigits_ReturnsFalse()
        {
            bool result =
                SSNValidator.IsValidSSN(
                    "12-345-6789"
                );


            Assert.That(result, Is.False);
        }


        [Test]
        public void EmptySSN_ReturnsFalse()
        {
            bool result =
                SSNValidator.IsValidSSN(
                    ""
                );


            Assert.That(result, Is.False);
        }
    }
}