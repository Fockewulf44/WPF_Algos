using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace WPF_Algos.Algorithms
{
    public class BinarySearch
    {
        // LeetCode EASY
        //Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums.If target exists, then return its index.Otherwise, return -1.
        //You must write an algorithm with O(log n) runtime complexity.

        //Input: nums = [-1,0,3,5,9,12], target = 9
        //Output: 4
        //Explanation: 9 exists in nums and its index is 4
        //Example 2:

        //Input: nums = [-1,0,3,5,9,12], target = 2
        //Output: -1
        //Explanation: 2 does not exist in nums so return -1

        public void Run()
        {
            int[] nums = new int[] { -1, 0, 3, 5, 9, 12, 14, 18, 22, 30 };
            //                        0  1  2  3  4  5   6   7   8   9
            int target = 30;

            int result = Binary_Search(nums, target);
        }


        public int Binary_Search(int[] nums, int target)
        {
            int index = -1;
            int left = 0;
            int right = nums.Length - 1;
            int middle = 0;

            while (left <= right)
            {
                middle = (left + right) / 2;

                if (target == nums[middle])
                {
                    return middle;
                }

                if (nums[middle] < target)
                {
                    left = middle + 1;                    
                }
                else
                {
                    right = middle - 1;
                }

            }


            return index;
        }
    }
}
