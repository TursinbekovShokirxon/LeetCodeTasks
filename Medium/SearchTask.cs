using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Medium
{
    public class SearchTask
    {
        public static int Search( int target,params int[] nums)
        {
            var res=nums.ToList();
            bool isA=nums.Contains(target);
            if (isA)
            {
                int minIndex=res.IndexOf(target);
                return minIndex;
            }
            else return -1;
        }
    }
}
