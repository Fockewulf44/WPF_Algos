using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WPF_Algos.Algorithms
{
    //189. Rotate Array
    //Medium
    //Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.

    //Example 1:

    //Input: nums = [1, 2, 3, 4, 5, 6, 7], k = 3
    //Output: [5, 6, 7, 1, 2, 3, 4]
    //Explanation:
    //rotate 1 steps to the right: [7, 1, 2, 3, 4, 5, 6]
    //rotate 2 steps to the right: [6, 7, 1, 2, 3, 4, 5]
    //rotate 3 steps to the right: [5, 6, 7, 1, 2, 3, 4]
    //Example 2:

    //Input: nums = [-1,-100,3,99], k = 2
    //Output: [3, 99, -1, -100]
    //Explanation: 
    //rotate 1 steps to the right: [99, -1, -100, 3]
    //rotate 2 steps to the right: [3, 99, -1, -100]

    public class Rotate_Array
    {

        public void Run()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            Rotate(nums, k);
            // Output: [5,6,7,1,2,3,4]

            nums = new int[] { -1, -100, 3, 99 };
            // Output: [3,99,-1,-100]
            k = 2;
            Rotate(nums, k);
        }

        public void Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            k %= n;

            Reverse(nums, 0, n - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, n - 1);
        }

        private void Reverse(int[] nums, int left, int right)
        {
            while (left < right)
            {
                (nums[left], nums[right]) = (nums[right], nums[left]);
                left++;
                right--;
            }
        }
    }
}
