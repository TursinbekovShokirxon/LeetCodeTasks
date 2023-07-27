using System.Diagnostics.Metrics;

namespace LeetCodeTasks.Easy
{
    internal class BalancedStringSplitTask
    {
        public static int BalancedStringSplit(string s)
        {
            int i = 0;
            int CounterRight = 0;
            int CounterLeft = 0;
            int counter = 0;
            while (s.Length > i)
            {
                while (s[i] == 'R')
                {
                    CounterRight++;
                    i++;
                }
                while (s[i] == 'L')
                {
                    CounterLeft++;
                    i++;
                }
                if (CounterLeft == CounterRight)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
