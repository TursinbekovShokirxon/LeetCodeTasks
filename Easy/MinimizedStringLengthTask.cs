using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Easy
{
    public class MinimizedStringLengthTask
    {
        public static int MinimizedStringLength(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                for (int j = i + 1; j < s.Length; j++)
                { if (s[j] == c) { s = s.Remove(j, 1); j--;}}
            }
            return s.Length;

        }
    }
}

