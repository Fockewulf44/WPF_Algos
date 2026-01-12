using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WPF_Algos.Algorithms
{
    public class LongestRepetativeCharReplac
    {
        //Medium
        //424. Longest Repeating Character Replacement
        //You are given a string s and an integer k.You can choose any character of the string and change it to any other uppercase English character. You can perform this operation at most k times.

        //Return the length of the longest substring containing the same letter you can get after performing the above operations.

        //Example 1:

        //Input: s = "ABAB", k = 2
        //Output: 4
        //Explanation: Replace the two 'A's with two 'B's or vice versa.

        public void Run()
        {
            int result = CharacterReplacement("AABABBA", 1);
            int result1 = CharacterReplacement("ABAB", 2);
            int result2 = CharacterReplacement("BBBABBA", 1);
            int result3 = CharacterReplacement("ABBB", 2);

        }

        public int CharacterReplacement(string s, int k)
        {
            int left = 0, right = 0;
            int maxCount = 0;
            int[] count = new int[26];
            int maxLength = 0;
            while (right < s.Length)
            {
                count[s[right] - 'A']++;
                maxCount = Math.Max(maxCount, count[s[right] - 'A']);
                
                //move left pointer ahead until we have valid window
                while (right - left + 1 - maxCount > k)
                {
                    //removing letter from left
                    //and moving left pointer ahead
                    count[s[left] - 'A']--;
                    left++;
                }
                maxLength = Math.Max(maxLength, right - left + 1);
                right++;
            }
            return maxLength;
        }
    }
}
