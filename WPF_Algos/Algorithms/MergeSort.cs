using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;


namespace WPF_Algos.Algorithms
{
    public class MergeSort
    {
        public MergeSort()
        {

        }

        public void Run()
        {
            //int[] nums = new int[] { 9, 2, 5, 1, 3, 10, 4, 15 };
            int[] nums = new int[] { 5, 1, 1, 2, 0, 0 };


            int[] result = Merge_Sort(nums, right: nums.Length - 1);
        }

        public int[] Merge_Sort(int[] nums, int left = 0, int right = 0)
        {
            //9, 2, 5, 1, 3, 10, 4, 15
            //9, 2, 5, 1
            //2, 9, 5, 1
            //2, 9, 5, 1
            //1, 2, 5, 9

            if (right - left < 2)
            {
                return Sort(nums, left, right);
            }

            int[] mergedSortedLeft;
            int[] mergedSortedRight;

            //Dividing array into two
            int mid = (left + right) / 2;

            mergedSortedLeft = Merge_Sort(nums, left, mid);
            mergedSortedRight = Merge_Sort(nums, mid + 1, right);


            //Merging two divided arrays
            int[] result = Merge(mergedSortedLeft, mergedSortedRight);


            return result;
        }

        public int[] Sort(int[] nums, int left, int right)
        {
            int[] result = new int[2];
            if (right - left > 0)
            {
                if (nums[right] < nums[left])
                {
                    result[0] = nums[right];
                    result[1] = nums[left];
                }
                else
                {
                    result[0] = nums[left];
                    result[1] = nums[right];
                }
            }
            else
            {
                return new int[] { nums[left] };
            }

            return result;
        }

        public int[] Merge(int[] left, int[] right)
        {
            // 2 9
            // 1 5
            // 3 10
            // 4 15
            int l = 0;
            int r = 0;
            int count = 0;

            int[] result = new int[left.Length + right.Length];

            while (count < left.Length + right.Length)
            {
                if (l < left.Length && (r >= right.Length || left[l] <= right[r]))
                {
                    result[count] = left[l];
                    l++;

                }

                else if (r < right.Length && (l >= left.Length || right[r] < left[l]))
                {

                    result[count] = right[r];
                    r++;

                }

                count++;
            }

            return result;
        }
    }
}