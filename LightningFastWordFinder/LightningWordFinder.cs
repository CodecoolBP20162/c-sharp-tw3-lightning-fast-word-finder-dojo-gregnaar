using System;
using System.Text.RegularExpressions;

namespace LightningFastWordFinder
{
    class LightningWordFinder
    {
        public string GetLongestWord(string text)
        {
            int longestLength = 3;
            string longestWord = "the";
            string[] words = text.Split(' ');
            

            for (int i = 0; i < words.Length; i++)
            {
                if (longestLength < words[i].Length)
                {
                    if (Regex.IsMatch(words[i], @"^([A-Za-z]*)+$"))
                    {
                        longestLength = words[i].Length;
                        longestWord = words[i];
                    }
                }
                else
                {
                    continue;
                }
            }
            
            return longestWord;
        }
    }
}
