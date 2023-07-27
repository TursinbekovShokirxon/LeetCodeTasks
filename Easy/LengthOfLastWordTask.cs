using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Easy
{
    internal class LengthOfLastWordTask
    {
        public static int LengthOfLastWord(string s)
        {
            int count = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    if (count == 0) continue;
                    else return count;
                }
                count++;
            }
            return count;
        }
    }
}
