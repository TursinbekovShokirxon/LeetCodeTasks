using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Easy
{
    internal class MaxProfitTask
    {
        public static int MaxProfit(params int[] prices)
        {
            int min = int.MaxValue;
            int maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (min > prices[i])
                {
                    min= prices[i]; 
                }

                int profit = prices[i]-min;
                if (profit > maxProfit)
                {
                 maxProfit = profit;   
                }
            }
            return maxProfit;
        }
    }
}
