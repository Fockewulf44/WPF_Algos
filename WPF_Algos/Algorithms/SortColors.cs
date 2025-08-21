using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Algos.Algorithms
{
    public class SortColors
    {

        //75. Sort Colors
        //Medium

        //Given an array nums with n objects colored red, white, or blue, sort them in-place so that objects of the same color are adjacent,
        //with the colors in the order red, white, and blue.

        //We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.

        //You must solve this problem without using the library's sort function.

        public void Run()
        {
            int[] nums = new int[] { 2, 0, 2, 1, 1, 0 };
            Sort(nums);
        }
        public void Sort(int[] nums)
        {
            int low = 0;
            int mid = 0;
            int high = nums.Length - 1;
            int index = 0;

            while (mid <= high)
            {
                if (nums[index] == 0)
                {
                    Swap(nums, low, index);
                    low++;
                }
                else if (nums[index] == 1)
                {
                    Swap(nums, index, high - mid - low);
                    mid++;
                }
                else if (nums[index] == 2)
                {
                    high--;
                }
                index++;

            }
        }

        public void Swap(int[] nums, int current, int replace)
        {
            int temp = nums[replace];
            nums[replace] = nums[current];
            nums[current] = temp;
        }
    }
}
