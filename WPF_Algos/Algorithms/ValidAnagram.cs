namespace WPF_Algos.Algorithms
{
    public class ValidAnagram
    {

        public void Run()
        {
            bool result1 = IsAnagram("anagram", "nagaram"); // True
            bool result2 = IsAnagram("rat", "car");         // False
        }

        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            foreach (char c in t)
            {
                if (!charCount.ContainsKey(c))
                    return false;

                charCount[c]--;

                if (charCount[c] < 0)
                    return false;
            }
            return true;
        }
    }
}
