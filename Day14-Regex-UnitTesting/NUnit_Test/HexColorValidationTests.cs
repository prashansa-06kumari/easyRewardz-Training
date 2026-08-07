using NUnit.Framework;
using Unit_Testing_Examples;

namespace NUnit_Test
{
    public class HexColorValidationTests
    {

        [Test]
        public void ValidHexColor_ReturnsTrue()
        {
            bool result = HexColorValidation.IsValidHex("#FF0000");

            Assert.That(result, Is.True);
        }


        [Test]
        public void HexColorWithoutHash_ReturnsFalse()
        {
            bool result = HexColorValidation.IsValidHex("FF0000");

            Assert.That(result, Is.False);
        }


        [Test]
        public void InvalidCharacters_ReturnsFalse()
        {
            bool result = HexColorValidation.IsValidHex("#GGHHHH");

            Assert.That(result, Is.False);
        }


        [Test]
        public void ShortHexColor_ReturnsFalse()
        {
            bool result = HexColorValidation.IsValidHex("#FFF");

            Assert.That(result, Is.False);
        }


        [Test]
        public void LowerCaseHex_ReturnsTrue()
        {
            bool result = HexColorValidation.IsValidHex("#abcdef");

            Assert.That(result, Is.True);
        }
    }
}