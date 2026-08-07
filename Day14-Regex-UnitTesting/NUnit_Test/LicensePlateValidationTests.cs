using NUnit.Framework;
using Unit_Testing_Examples;

namespace NUnit_Test
{
    public class LicensePlateValidationTests
    {

        [Test]
        public void ValidLicensePlate_ReturnsTrue()
        {
            bool result = LicensePlateValidation.IsValidPlate("PB10AB1234");

            Assert.That(result, Is.True);
        }


        [Test]
        public void InvalidLicensePlate_ReturnsFalse()
        {
            bool result = LicensePlateValidation.IsValidPlate("12345");

            Assert.That(result, Is.False);
        }


        [Test]
        public void LowerCasePlate_ReturnsFalse()
        {
            bool result = LicensePlateValidation.IsValidPlate("pb10ab1234");

            Assert.That(result, Is.False);
        }


        [Test]
        public void MissingCharacters_ReturnsFalse()
        {
            bool result = LicensePlateValidation.IsValidPlate("PB10A123");

            Assert.That(result, Is.False);
        }
    }
}