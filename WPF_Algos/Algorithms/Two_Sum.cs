using System.Globalization;

namespace WPF_Algos.Algorithms
{
    public class Two_Sum
    {
        public void Run()
        {
            int[] nums = new int[] { 2, 11, 4, 3, 6, 7, 15 };
            int target = 9;

            var output = TwoSum(nums, target);
        }

        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> keyValues = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (keyValues.TryGetValue(target - nums[i], out int value))
                {
                    return new int[] { i, value };
                }
                if (!keyValues.ContainsKey(nums[i]))
                    keyValues.Add(nums[i], i);
            }

            return new int[] { 0, 0 };
        }
    }
}
