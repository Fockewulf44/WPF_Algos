using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Algos.Algorithms
{
    //Longest Substring Without Repeating Characters
    //    Example 1:

    //Input: s = "abcabcbb"
    //Output: 3
    //Explanation: The answer is "abc", with the length of 3. Note that "bca" and "cab" are also correct answers.

    public class LongestSubstring
    {
        public void Run()
        {
            var result1 = Longest_Substring("abcabcbb");
            var result2 = Longest_Substring("bacabcbb");
            var result3 = Longest_Substring("bbbbb");
            var result4 = Longest_Substring("pwwkew");
        }

        public string Longest_Substring(string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            Dictionary<char, int> lastIndex = new Dictionary<char, int>();
            int windowStart = 0;
            int bestStart = 0;
            int bestLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (lastIndex.TryGetValue(c, out int prevIndex) && prevIndex >= windowStart)
                {
                    windowStart = prevIndex + 1;
                }

                lastIndex[c] = i;

                int windowLength = i - windowStart + 1;
                if (windowLength > bestLength)
                {
                    bestLength = windowLength;
                    bestStart = windowStart;
                }
            }

            return s.Substring(bestStart, bestLength);
        }
    }
}
