using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Shapes;
using System.Configuration;
using System.Net.Http.Headers;
namespace WPF_Algos.Algorithms
{
    //Given an array of integers, calculate the ratios of its elements that are positive,
    //negative, and zero.Print the decimal value of each fraction on a new line with  places after the decimal.

    public class PlusMinus
    {
        public void Run()
        {
            //int[] arr = new int[] { 1, 1, -1, -1, 0 };
            int[] arr = new int[] { 1, -2, -7, 9, 1, -8, -5 };

            Plus_Minus(arr);
        }
        public void Plus_Minus(int[] arr)
        {
            int negative = 0;
            int positive = 0;
            int zero = 0;
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                switch (arr[i])
                {
                    case 0:
                        zero++;
                        break;
                    case > 0:
                        positive++;
                        break;
                    case < 0:
                        negative++;
                        break;
                    default:

                        //break;
                }
            }

            string[] result = new string[3];

            result[0] = AddZeroes(Math.Round((decimal)positive / length, 6));
            result[1] = AddZeroes(Math.Round((decimal)negative / length, 6));
            result[2] = AddZeroes(Math.Round((decimal)zero / length, 6));

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        public string AddZeroes(decimal number)
        {
            string missZeroes = "";
            if (decimal.IsInteger(number))
            {
                missZeroes = ".000000";
            }
            else
            {
                int missZeroes1 = 8 - number.ToString().Length;
                missZeroes = Math.Pow(10, missZeroes1).ToString().Remove(0, 1);
            }

            return number.ToString() + missZeroes;
        }
    }
}
