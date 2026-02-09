using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WPF_Algos.Algorithms
{
    //525. Contiguous Array
    //Medium
    //Topics
    //premium lock icon
    //Companies
    //Given a binary array nums, return the maximum length of a contiguous subarray with an equal number of 0 and 1.

    //Example 1:

    //Input: nums = [0, 1]
    //Output: 2
    //Explanation: [0, 1] is the longest contiguous subarray with an equal number of 0 and 1.
    //Example 2:

    //Input: nums = [0, 1, 0]
    //Output: 2
    //Explanation: [0, 1] (or[1, 0]) is a longest contiguous subarray with equal number of 0 and 1.
    //Example 3:

    //Input: nums = [0, 1, 1, 1, 1, 1, 0, 0, 0]
    //Output: 6
    //Explanation: [1, 1, 1, 0, 0, 0] is the longest contiguous subarray with equal number of 0 and 1.

    public class ContiguosArray
    {
        public void Run()
        {
            int[] nums1 = new int[] { 0, 1, 0 };
            var r1 = FindMaxLength(nums1);

            int[] nums2 = new int[] { 0, 1, 1, 1, 1, 1, 0, 0, 0 };
            var r2 = FindMaxLength(nums2);

            int[] nums3 = new int[] { 0, 1, 0, 1 };
            var r3 = FindMaxLength(nums3);
        }

        public int FindMaxLength(int[] nums)
        {
            var map = new Dictionary<int, int>();
            map[0] = -1;

            int sum = 0;
            int maxLen = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i] == 1 ? 1 : -1;

                if (map.ContainsKey(sum))
                {
                    maxLen = Math.Max(maxLen, i - map[sum]);
                }
                else
                {
                    map[sum] = i;
                }
            }

            return maxLen;
        }
    }
}
