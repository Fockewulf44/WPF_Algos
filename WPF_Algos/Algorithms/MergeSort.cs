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
            int[] nums = new int[] { 9, 2, 5, 1, 3, 10, 4, 15 };
            int[] nums1 = new int[] { 5, 1, 1, 2, 0, 0 };


            int[] result = Merge_Sort(nums, right: nums.Length - 1);
            int[] result2 = Merge_Sort(nums1, right: nums1.Length - 1);
        }

        public int[] Merge_Sort(int[] nums, int left = 0, int right = 0)
        {
            //9, 2, 5, 1, 3, 10, 4, 15
            //9, 2, 5, 1
            //2, 9, 5, 1
            //2, 9, 5, 1
            //1, 2, 5, 9

            if (right - left < 1)
                return new int[] { nums[left] };

            //Dividing array into two
            int mid = (left + right) / 2;

            //Merging two divided arrays
            int[] result = Merge(Merge_Sort(nums, left, mid), Merge_Sort(nums, mid + 1, right));


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
            int index = 0;

            int[] result = new int[left.Length + right.Length];

            while (l < left.Length && r < right.Length)
            {
                if (left[l] <= right[r])
                {
                    result[index++] = left[l++];                    
                }
                else
                {
                    result[index++] = right[r++];                    
                }                
            }

            while(l < left.Length)
            {
                result[index++] = left[l++];
            }

            while (r < right.Length)
            {
                result[index++] = right[r++];
            }

            return result;
        }
    }
}