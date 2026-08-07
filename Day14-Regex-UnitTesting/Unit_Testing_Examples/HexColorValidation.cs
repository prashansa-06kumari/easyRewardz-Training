using System.Text.RegularExpressions;

namespace Unit_Testing_Examples
{
    public class HexColorValidation
    {
        public static bool IsValidHex(string color)
        {
            string pattern = @"^#[0-9A-Fa-f]{6}$";

            return Regex.IsMatch(color, pattern);
        }
    }
}