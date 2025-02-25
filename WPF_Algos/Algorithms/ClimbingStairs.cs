using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Algos.Algorithms
{
    public class ClimbingStairs
    {
        public void Run()
        {
            int n = 3;
            Climbing_Stairs(n);
            //1 2 3 5 8 13
            //1 2 3 4 5 6
        }

        public int Climbing_Stairs(int n)
        {
            if (n == 1)
                return 1;


            int buffer = 0;
            int prev1 = 1;
            int prev2 = 2;

            for (int i = 3; i <= n; i++)
            {
                buffer = prev1 + prev2;   
                prev1 = prev2;
                prev2 = buffer;
            }

            return prev2;
        }
    }
}
