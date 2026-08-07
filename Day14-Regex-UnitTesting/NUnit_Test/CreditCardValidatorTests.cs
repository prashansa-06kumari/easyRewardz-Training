using NUnit.Framework;
using Unit_Testing_Examples;

namespace NUnit_Test
{
    public class CreditCardValidatorTests
    {

        [Test]
        public void ValidCardNumber_ReturnsTrue()
        {
            bool result =
                CreditCardValidator.IsValidCard(
                    "1234567812345678"
                );


            Assert.That(result, Is.True);
        }


        [Test]
        public void CardWithLessDigits_ReturnsFalse()
        {
            bool result =
                CreditCardValidator.IsValidCard(
                    "12345678"
                );


            Assert.That(result, Is.False);
        }


        [Test]
        public void CardWithCharacters_ReturnsFalse()
        {
            bool result =
                CreditCardValidator.IsValidCard(
                    "1234abcd12345678"
                );


            Assert.That(result, Is.False);
        }


        [Test]
        public void EmptyCardNumber_ReturnsFalse()
        {
            bool result =
                CreditCardValidator.IsValidCard(
                    ""
                );


            Assert.That(result, Is.False);
        }
    }
}