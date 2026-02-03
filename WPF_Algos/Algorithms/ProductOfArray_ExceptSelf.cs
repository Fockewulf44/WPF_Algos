using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WPF_Algos.Algorithms
{
    //    238. Product of Array Except Self
    //Medium
    //Topics
    //premium lock icon
    //Companies
    //Hint
    //Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

    //The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

    //You must write an algorithm that runs in O(n) time and without using the division operation.

    //Example 1:

    //Input: nums = [1, 2, 3, 4]
    //Output: [24, 12, 8, 6]
    //Example 2:

    //Input: nums = [-1, 1, 0, -3, 3]
    //Output: [0, 0, 9, 0, 0]
    public class ProductOfArray_ExceptSelf
    {
        public void Run()
        {
            int[] nums1 = { 1, 2, 3, 4 };
            var r1 = ProductExceptSelf(nums1);
            // Output: [24,12,8,6]
            int[] nums2 = { -1, 1, 0, -3, 3 };
            var r2 = ProductExceptSelf(nums2);
            // Output: [0,0,9,0,0]
        }

        public int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];

            //left prefix products
            result[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                result[i] = result[i - 1] * nums[i - 1];
            }

            //right suffix products
            int lastResult = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] = result[i] * lastResult;
                lastResult *= nums[i];
            }

            return result;
        }
    }
}
