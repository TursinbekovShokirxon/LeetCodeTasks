using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    public class RemoveElementTask
    {
        public static void StartUp()
        {
            foreach (var item in RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2))
            {
                Console.WriteLine(item);
            } 
        }
        public static int[] RemoveElement(int[] nums, int val) {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    for (int j = i; j < nums.Length - 1; j++)
                    {
                        nums[i] = nums[i + 1];
                    }
                    Array.Resize(ref nums, nums.Length - 2);
                }
            }
            if (nums[nums.Length - 1] == val)
            {
                Array.Resize(ref nums, nums.Length - 2);
            }
            return nums;
        }
  
    }
}
