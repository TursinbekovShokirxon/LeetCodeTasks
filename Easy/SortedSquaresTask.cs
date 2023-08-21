﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Easy
{
    internal class SortedSquaresTask
    {
        public int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++) {
                nums[i]*= nums[i];
            }
            Array.Sort(nums);
            return nums;
        }
    }
}
