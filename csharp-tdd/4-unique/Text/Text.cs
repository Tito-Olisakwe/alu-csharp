using System;
using System.Collections.Generic;

namespace Text
{
    public class Str
    {
        /// <summary>
        /// Finds the index of the first non-repeating character in a string.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns>The index of the first non-repeating character, or -1 if none exists.</returns>
        public static int UniqueChar(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return -1;
            }

            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                }
                else
                {
                    charCounts[c] = 1;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (charCounts[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
