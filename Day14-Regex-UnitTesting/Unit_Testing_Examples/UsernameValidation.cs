using System.Text.RegularExpressions;

namespace Unit_Testing_Examples
{
    public class UsernameValidation
    {
        public static bool IsValidUsername(string username)
        {
            string pattern = @"^[a-zA-Z0-9_]{5,15}$";

            return Regex.IsMatch(username, pattern);
        }
    }
}