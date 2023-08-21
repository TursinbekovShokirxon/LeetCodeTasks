using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Easy
{
    internal class SearchInsertTask
    {
        public static void startUp()
        {
            Console.WriteLine(SearchInsert(0, 1, 3, 5, 6));
        }
        public static int SearchInsert(int target, params int[] nums)
        {
        int i = nums.Length - 1;
        if (target > nums[i]) return i + 1;
        if (target < nums[0]) return 0;
        while(target < nums[i]) i /= 2;
        while (target > nums[i]) ++i;
        return i;

        }
    }
}
