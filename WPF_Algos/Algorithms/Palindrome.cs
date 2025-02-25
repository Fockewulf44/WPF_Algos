using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Algos.Algorithms
{
    public class Palindrome
    {
        public void Run()
        {
            int number = 121;
            //int number = 121;
            //int number = 1221;
            //int number = 22522;

            var result = IsPalindrome(number);
        }

        public bool IsPalindrome(int x)
        {
            int reversed = 0;
            int xcopy = x;

            while (xcopy > 0)
            {                
                reversed = reversed * 10 + xcopy % 10;
                xcopy /= 10;
            }

            return reversed == x;
        }
    }
}
