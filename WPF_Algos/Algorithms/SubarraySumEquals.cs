using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WPF_Algos.Algorithms
{
    //560. Subarray Sum Equals K
    //Medium
    //Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.

    //A subarray is a contiguous non-empty sequence of elements within an array.

    public class SubarraySumEquals
    {
        public void Run()
        {
            int[] n1 = { 1, 2, 3 };
            var r1 = SubarraySum(n1, 3);

            int[] n11 = { 1, 2, 0, 0, 3 };
            var r11 = SubarraySum(n11, 3);

            int[] n2 = { 1, 1, 1 };
            var r2 = SubarraySum(n2, 2);

            int[] n3 = { 1, -1, 0 };
            var r3 = SubarraySum(n3, 0);

            int[] n4 = { 1, 2, 1, 2, 1 };
            var r4 = SubarraySum(n4, 3);

            int[] n5 = { 1, 2, 0, 1, 1, 2, 1, 0, 1 };
            var r5 = SubarraySum(n5, 4);
        }


        public int SubarraySum(int[] nums, int k)
        {

            Dictionary<int, int> map = new Dictionary<int, int>();
            map[0] = 1;

            int sum = 0;
            int count = 0;

            foreach (int num in nums)
            {
                sum += num;

                if (map.ContainsKey(sum - k))
                    count += map[sum - k];

                if (!map.ContainsKey(sum))
                    map[sum] = 0;
                map[sum]++;
            }

            return count;
        }
    }
}
