using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Medium
{
    public class RemoveDuplicatesTask
    {
        public static int RemoveDuplicates(params int[] nums)
        {
            if(nums.Length<=2) return nums.Length;
            List<int> result = new List<int>();
            for (int i = 0,j=0; i < nums.Length; i++)
            {

                    if (j != 0 && result[j] != result[j - 1]) { result.Add(nums[i]); j++; }
                    else if (j == 0) { result.Add(nums[i]); j++; }; 
                
            }
            return result.Count;
        }
    }
}

