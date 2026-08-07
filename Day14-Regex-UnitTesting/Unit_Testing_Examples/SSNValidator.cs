using System.Text.RegularExpressions;

namespace Unit_Testing_Examples
{
    public class SSNValidator
    {
        public static bool IsValidSSN(string ssn)
        {
            string pattern = @"^\d{3}-\d{2}-\d{4}$";

            return Regex.IsMatch(ssn, pattern);
        }
    }
}