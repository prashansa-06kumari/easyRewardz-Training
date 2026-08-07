using System.Text.RegularExpressions;

namespace Unit_Testing_Examples
{
    public class CreditCardValidator
    {
        public static bool IsValidCard(string cardNumber)
        {
            string pattern = @"^[0-9]{16}$";

            return Regex.IsMatch(cardNumber, pattern);
        }
    }
}