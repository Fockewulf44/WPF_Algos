using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Algos.Algorithms
{

    //283. Move Zeroes
    //Easy
    //Topics
    //premium lock icon
    //Companies
    //Hint
    //Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

    //Note that you must do this in-place without making a copy of the array.

    //Example 1:

    //Input: nums = [0, 1, 0, 3, 12]
    //Output: [1, 3, 12, 0, 0]
    //Example 2:

    //Input: nums = [0]
    //Output: [0]

    public class MoveZeroes
    {
        public void Run()
        {
            int[] nums1 = { 0, 1, 0, 3, 12 };
            var r1 = MoveZeroesToEnd(nums1);
            // Output: [1, 3, 12, 0, 0]
            int[] nums2 = { 0 };
            var r2 = MoveZeroesToEnd(nums2);
            // Output: [0]
        }

        public int[] MoveZeroesToEnd(int[] nums)
        {

            int right = 0;
            int left = 0;


            while (right < nums.Length)
            {
                if (nums[right] == 0)
                {
                    right++;
                }
                else
                {
                    int temp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = temp;
                    left++;
                    right++;
                }
            }

            return nums;
        }
    }
}
