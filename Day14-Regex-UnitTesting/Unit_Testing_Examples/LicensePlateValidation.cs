using System.Text.RegularExpressions;

namespace Unit_Testing_Examples
{
    public class LicensePlateValidation
    {
        public static bool IsValidPlate(string plate)
        {
            string pattern = @"^[A-Z]{2}[0-9]{2}[A-Z]{2}[0-9]{4}$";

            return Regex.IsMatch(plate, pattern);
        }
    }
}