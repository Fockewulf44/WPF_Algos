using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WPF_Algos.Algorithms
{
    //46. Permutations
    //Medium
    //Topics
    //premium lock icon
    //Companies
    //Given an array nums of distinct integers, return all the possible permutations.You can return the answer in any order.




    //Example 1:

    //Input: nums = [1, 2, 3]
    //Output: [[1, 2, 3],[1, 3, 2],[2, 1, 3],[2, 3, 1],[3, 1, 2],[3, 2, 1]]
    //Example 2:

    //Input: nums = [0, 1]
    //Output: [[0, 1],[1, 0]]
    //Example 3:

    //Input: nums = [1]
    //Output: [[1]]


    public class Permutation
    {
        public void Run()
        {
            int[] nums = new int[] { 1, 2, 3 };
            var result = Permute(nums);
        }

        public IList<IList<int>> Permute(int[] nums)
        {
            var res = new List<IList<int>>();
            Backtrack(nums, new List<int>(), new bool[nums.Length], res);
            return res;
        }

        void Backtrack(int[] nums, List<int> path, bool[] used, List<IList<int>> res)
        {
            if (path.Count == nums.Length)
            {
                res.Add(new List<int>(path));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (used[i]) continue;

                used[i] = true;
                path.Add(nums[i]);

                Backtrack(nums, path, used, res);

                path.RemoveAt(path.Count - 1); // undo
                used[i] = false;
            }
        }
    }
}
