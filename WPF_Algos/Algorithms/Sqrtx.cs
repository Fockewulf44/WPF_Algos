using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Algos.Algorithms
{
    public class Sqrtx
    {
        public void Run()
        {
            var tc1 = Sqrt_x(9);
            var tc2 = Sqrt_x(4);
            var tc3 = Sqrt_x(2147395599);
            var tc4 = Sqrt_x(2147483647);
            var tc5 = Sqrt_x(9);
            var tc6 = Sqrt_x(9);
            var tc7 = Sqrt_x(9);
        }

        public int Sqrt_x(int x)
        {
            long y = x;

            while ((long)y * y > x)
            {                
                y = (y + x / y) / 2;
            }

            return (int)y;
        }
    }
}
