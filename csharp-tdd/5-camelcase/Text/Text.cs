using System;

namespace Text
{
    public class Str
    {
        /// <summary>
        /// Counts the number of words in a camelCase string.
        /// </summary>
        /// <param name="s">The string to analyze.</param>
        /// <returns>The number of words in the string.</returns>
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            int count = 1;

            foreach (char c in s)
            {
                if (char.IsUpper(c))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
