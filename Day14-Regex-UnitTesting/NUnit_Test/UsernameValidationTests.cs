using NUnit.Framework;
using Unit_Testing_Examples;

namespace NUnit_Test
{
    public class UsernameValidationTests
    {

        [Test]
        public void ValidUsername_ReturnsTrue()
        {
            bool result = UsernameValidation.IsValidUsername("John_123");

            Assert.That(result, Is.True);
        }


        [Test]
        public void UsernameLessThanFiveCharacters_ReturnsFalse()
        {
            bool result = UsernameValidation.IsValidUsername("abc");

            Assert.That(result, Is.False);
        }


        [Test]
        public void UsernameWithSpecialCharacter_ReturnsFalse()
        {
            bool result = UsernameValidation.IsValidUsername("John@123");

            Assert.That(result, Is.False);
        }


        [Test]
        public void UsernameMoreThanFifteenCharacters_ReturnsFalse()
        {
            bool result = UsernameValidation.IsValidUsername("abcdefghijklmnopqr");

            Assert.That(result, Is.False);
        }


        [Test]
        public void UsernameWithOnlyNumbers_ReturnsTrue()
        {
            bool result = UsernameValidation.IsValidUsername("12345");

            Assert.That(result, Is.True);
        }
    }
}