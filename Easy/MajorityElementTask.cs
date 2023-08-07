using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Easy
{
    internal class MajorityElementTask
    {
        public static void StartUp()
        {
            Console.WriteLine(MajorityElement(new int[] { 2, 2,1,1, 1, 1, 2,2  }));
        }
        public static int MajorityElement(int[] nums)
        {
              Array.Sort(nums);
            return nums[nums.Length/2];
        }
    }
}
