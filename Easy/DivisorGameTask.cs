using System.Collections.Specialized;

namespace LeetCodeTasks.Easy
{
    internal class DivisorGameTask
    {
        public static void StartUp()
        {
            Console.WriteLine(DivisorGame(4));
        }
        public static bool DivisorGame(int n)
        {
            return n % 2 == 0;
            
        }
    }
}
