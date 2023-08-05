using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Easy
{
    internal class MergeAlternatelyTask
    {
        public static string MergeAlternately(string word1, string word2)
        {
            int i = 0, j = 0;
            string res = "";
                while (i<word1.Length | j < word2.Length)
                {
                
                if (i < word1.Length)
                    {
                        res += word1[i];
                        i++;
                    }
                if (j < word2.Length)
                {
                    res += word2[j];
                    j++;
                }   
                }
                return res;
        }
    }
}
