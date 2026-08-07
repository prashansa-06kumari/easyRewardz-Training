using System.Text.RegularExpressions;

namespace Unit_Testing_Examples
{
    public class SpaceReplacer
    {
        public static string ReplaceSpaces(string text)
        {
            return Regex.Replace(text, @"\s+", "_");
        }
    }
}