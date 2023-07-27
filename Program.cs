using LeetCodeTasks.Easy;
using System;

namespace LeetCodeTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BalancedStringSplitTask.BalancedStringSplit("RLRRLLRLRL"));
        }
        public static int MinSpeedOnTime(int[] dist, double hour)
        {
            double SumDistance = 0;
            if (hour.ToString().Length <= 4)
            {
                if (hour >= 2)
                {
                    SumDistance = dist.Sum();
                    SumDistance /= hour;
                    int index = SumDistance.ToString().IndexOf(',');
                    if (index != -1) {
                        if (SumDistance.ToString()[index + 1] >= 5)
                        {
                            SumDistance = (int)SumDistance + 1;
                        }
                        else
                        {
                            SumDistance = (int)SumDistance;
                        }
                    }
                    return (int)SumDistance;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                new Exception();
            }
            return 0;

        }
    }
}