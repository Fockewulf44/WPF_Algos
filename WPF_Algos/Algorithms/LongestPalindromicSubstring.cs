using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Animation;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WPF_Algos.Algorithms
{
    public class LongestPalindromicSubstring
    {
        //Longest Palindromic Substring
        //Example 1:

        //Input: s = "babad"
        //Output: "bab"
        //Explanation: "aba" is also a valid answer.
        //Example 2:

        //Input: s = "cbbd"
        //Output: "bb"

        public void Run()
        {
            var result1 = Longest_Palindrome("babad");
            var result2 = Longest_Palindrome("cbbd");
            var result3 = Longest_Palindrome("dfahafd");
            var result4 = Longest_Palindrome("dfaafd");
        }

        public string Longest_Palindrome(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length < 1)
                return string.Empty;

            int start = 0;
            int end = 0;

            for (int i = 0; i < s.Length; i++)
            {
                ExpandFromCenter(s, i, i, ref start, ref end);
                ExpandFromCenter(s, i, i + 1, ref start, ref end);
            }

            return s.Substring(start, end - start + 1);
        }

        public void ExpandFromCenter(string s, int left, int right, ref int start, ref int end)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            if (right - left - 1 > end - start)
            {
                start = left + 1;
                end = right - 1;
            }
        }

    }
}
