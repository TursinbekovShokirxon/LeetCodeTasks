using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Medium
{
    internal class HIndexTask
    {
        public int HIndex(int[] citations)
        {
            int res = 0;
            for (int i = citations.Length-1; i >0; i--)
            {
                if (res < citations[i]) res++;
                else return res;
            }
            return res;

        }
    }
}
