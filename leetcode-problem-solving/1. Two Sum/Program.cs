using System;

namespace _1._Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int y = i + 1; y < nums.Length; y++)
                {
                    if (nums[i] + nums[y] == target)
                    {
                        return new int[] { i, y };
                    }
                }
            }

            return new int[] { };
        }
    }
}
