using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Easy
{
    internal class FindNumbersTask
    {
        public int FindNumbers(int[] nums)
        {
            int counterEvenNums = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                byte counter = 0;
                while (nums[i] > 0)
                {
                    nums[i] /= 10;
                    counter++;
                }
                if (counter % 2 == 0)
                {
                    counterEvenNums++;
                }
            }
            return counterEvenNums;
    }
    }
}
