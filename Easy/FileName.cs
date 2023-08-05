using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Easy
{
    internal class MergeTask
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = m,j=0; i < nums1.Length; i++,j++)
            {
                nums1[i] = nums2[i];
            }
            Array.Sort(nums1);
        }
    }
}
