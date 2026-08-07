using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Unit_Testing_Examples
{
    public class RepeatingWordFinder
    {
        public static List<string> FindRepeatedWords(string text)
        {
            string[] words = 
                Regex.Split(text.ToLower(), @"\s+");


            List<string> repeatedWords =
                new List<string>();


            for(int i = 0; i < words.Length; i++)
            {
                for(int j = i + 1; j < words.Length; j++)
                {
                    if(words[i] == words[j] &&
                       !repeatedWords.Contains(words[i]))
                    {
                        repeatedWords.Add(words[i]);
                    }
                }
            }


            return repeatedWords;
        }
    }
}