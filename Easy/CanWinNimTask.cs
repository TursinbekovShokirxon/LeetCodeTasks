using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Easy
{
    internal class CanWinNimTask
    {
        public static void StartUp()
        {
            Console.WriteLine(CanWinNim(5));
        }
        public static bool CanWinNim(int n)
        {
            return n % 4 != 0;
        }
    }
}
