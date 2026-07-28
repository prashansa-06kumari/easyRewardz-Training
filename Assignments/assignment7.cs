using System;

namespace Assignments
{
    class assignment7
    {       
        //question-1
        public static void countVowelsConsonants()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine()!;
            int vowels = 0;
            int consonants = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char ch = char.ToLower(str[i]);
                if (ch >= 'a' && ch <= 'z')
                {
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
            }
            Console.WriteLine("Vowels = " + vowels);
            Console.WriteLine("Consonants = " + consonants);
        }



        //question-2
        public static void reverseString()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine()!;
            string rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }
            Console.WriteLine("Reversed String = " + rev);
        }


        //question-3
        public static void palindromeString()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine()!;
            string rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }
            if (str == rev)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }



        //question-4
        public static void removeDuplicate()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine()!;
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < result.Length; j++)
                {
                    if (str[i] == result[j])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    result += str[i];
                }
            }
            Console.WriteLine("Modified String = " + result);
        }


        //question-5
        public static void longestWord()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine()!;

            string[] words = sentence.Split(' ');

            string longest = words[0];

            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > longest.Length)
                {
                    longest = words[i];
                }
            }

            Console.WriteLine("Longest Word = " + longest);
        }


        //question-6
        public static void substringOccurrence()
        {
            Console.Write("Enter main string: ");
            string str = Console.ReadLine()!;
            Console.Write("Enter substring: ");
            string sub = Console.ReadLine()!;
            int count = 0;
            for (int i = 0; i <= str.Length - sub.Length; i++)
            {
                bool match = true;
                for (int j = 0; j < sub.Length; j++)
                {
                    if (str[i + j] != sub[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                {
                    count++;
                }
            }
            Console.WriteLine("Occurrences = " + count);
        }


        //question-7
        public static void toggleCase()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine()!;
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (char.IsUpper(ch))
                {
                    result += char.ToLower(ch);
                }
                else if (char.IsLower(ch))
                {
                    result += char.ToUpper(ch);
                }
                else
                {
                    result += ch;
                }
            }
            Console.WriteLine("Modified String = " + result);
        }



        //question-8
        public static void compareStrings()
        {
            Console.Write("Enter first string: ");
            string s1 = Console.ReadLine()!;
            Console.Write("Enter second string: ");
            string s2 = Console.ReadLine()!;
            int min = s1.Length < s2.Length ? s1.Length : s2.Length;
            for (int i = 0; i < min; i++)
            {
                if (s1[i] < s2[i])
                {
                    Console.WriteLine(s1 + " comes before " + s2);
                    return;
                }
                else if (s1[i] > s2[i])
                {
                    Console.WriteLine(s2 + " comes before " + s1);
                    return;
                }
            }
            if (s1.Length == s2.Length)
            {
                Console.WriteLine("Both strings are equal.");
            }
            else if (s1.Length < s2.Length)
            {
                Console.WriteLine(s1 + " comes before " + s2);
            }
            else
            {
                Console.WriteLine(s2 + " comes before " + s1);
            }
        }
        

        //question-9
        public static void mostFrequentCharacter()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine()!;
            char maxChar = str[0];
            int maxCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxChar = str[i];
                }
            }
            Console.WriteLine("Most Frequent Character = " + maxChar);
        }



        //question-10
        public static void removeCharacter()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine()!;
            Console.Write("Enter character to remove: ");
            char ch = char.Parse(Console.ReadLine()!);
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ch)
                {
                    result += str[i];
                }
            }
            Console.WriteLine("Modified String = " + result);
        }



        //question-11
        public static void anagramCheck()
        {
            Console.Write("Enter first string: ");
            string s1 = Console.ReadLine()!.ToLower();
            Console.Write("Enter second string: ");
            string s2 = Console.ReadLine()!.ToLower();
            if (s1.Length != s2.Length)
            {
                Console.WriteLine("Not Anagrams");
                return;
            }
            int[] freq = new int[26];
            for (int i = 0; i < s1.Length; i++)
            {
                freq[s1[i] - 'a']++;
                freq[s2[i] - 'a']--;
            }
            for (int i = 0; i < 26; i++)
            {
                if (freq[i] != 0)
                {
                    Console.WriteLine("Not Anagrams");
                    return;
                }
            }
            Console.WriteLine("Anagrams");
        }


        //question-12
        public static void replaceWord()
        {
            Console.Write("Enter a sentence: ");
            string sent = Console.ReadLine()!;
            Console.Write("Enter word to replace: ");
            string oldWord = Console.ReadLine()!;
            Console.Write("Enter new word: ");
            string newWord = Console.ReadLine()!;
            string[] words = sent.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == oldWord)
                {
                    words[i] = newWord;
                }
            }
            string res = "";
            for (int i = 0; i < words.Length; i++)
            {
                res += words[i];
                if (i != words.Length - 1)
                {
                    res += " ";
                }
            }
            Console.WriteLine("Modified Sentence = " + res);
        }



    }
}