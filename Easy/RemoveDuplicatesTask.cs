using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Easy
{
    internal  class RemoveDuplicatesTask
    {
        public static void startUp()
        {
            Console.WriteLine(RemoveDuplicates(new int[] {1,1,3,4 }));
        }
        public static int RemoveDuplicates(int[] nums)
        {
            int k = 1;
            int previouse = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != previouse)
                {
                    nums[k] = nums[i];
                    k++;
                }
                previouse = nums[i];
            }
            return k;
        }
    }
}
