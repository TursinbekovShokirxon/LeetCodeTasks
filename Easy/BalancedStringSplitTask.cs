using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

namespace LeetCodeTasks.Easy
{
    internal class BalancedStringSplitTask
    {
        public  static int BalancedStringSplit(string s)
        {
            int balance = 0;
            int counter = 0;
            foreach (char c in s)
            {
                if (c == 'R')
                {
                    balance++;
                }
                else if (c == 'L')
                {
                    balance--;
                }
                if (balance == 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
