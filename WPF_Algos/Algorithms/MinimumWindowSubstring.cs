namespace WPF_Algos.Algorithms
{
    public class MinimumWindowSubstring
    {
        //HARD

        //Given two strings s and t of lengths m and n respectively, return the minimum window
        //substring
        //of s such that every character in t(including duplicates) is included in the window.If there is no such substring, return the empty string "".
        //The testcases will be generated such that the answer is unique.
        //Input: s = "ADOBECODEBANC", t = "ABC"
        //Output: "BANC"
        //Explanation: The minimum window substring "BANC" includes 'A', 'B', and 'C' from string t.
        public void Run()
        {
            string s = "ADOBECODEBANC";
            string t = "ABC";
            MinimumWindow_Substring(s, t);
        }


        public string MinimumWindow_Substring(string s, string t)
        {
            if (s.Length == 0 || t.Length == 0) return "";

            // Dictionary to store the frequency of characters in t
            Dictionary<char, int> dictT = new Dictionary<char, int>();
            foreach (char c in t)
            {
                if (dictT.ContainsKey(c))
                    dictT[c]++;
                else
                    dictT[c] = 1;
            }

            int required = dictT.Count; // Unique characters in t that must be in the window
            int l = 0, r = 0; // Two pointers for the sliding window
            int formed = 0; // How many unique characters in t are satisfied in window

            Dictionary<char, int> windowCounts = new Dictionary<char, int>();
            int minLen = int.MaxValue;
            int minLeft = 0, minRight = 0;

            while (r < s.Length)
            {
                char c = s[r];
                if (windowCounts.ContainsKey(c))
                    windowCounts[c]++;
                else
                    windowCounts[c] = 1;

                if (dictT.ContainsKey(c) && windowCounts[c] == dictT[c])
                    formed++;

                // Try to contract the window
                while (l <= r && formed == required)
                {
                    c = s[l];

                    // Update the minimum window
                    if (r - l + 1 < minLen)
                    {
                        minLen = r - l + 1;
                        minLeft = l;
                        minRight = r;
                    }

                    windowCounts[c]--;
                    if (dictT.ContainsKey(c) && windowCounts[c] < dictT[c])
                        formed--;

                    l++; // Move left pointer forward
                }

                r++; // Expand right pointer
            }

            return minLen == int.MaxValue ? "" : s.Substring(minLeft, minLen);
        }
    }
}
