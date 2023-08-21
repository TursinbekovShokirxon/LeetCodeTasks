namespace LeetCodeTasks.Easy
{
    internal class FindMaxConsecutiveOnesTask
    {
        public static void StartUp()
        {
            Console.WriteLine(FindMaxConsecutiveOnes(1, 1, 0, 1, 1, 1));
        }
        public static int FindMaxConsecutiveOnes(params int[] nums)
        {
            int MaxCount = 0;
            int CurrenCount = 0;
            foreach (int i in nums)
            {
                if (i == 1)
                {
                    CurrenCount++;
                    MaxCount=Math.Max(CurrenCount, MaxCount);

                }
                else CurrenCount = 0;
            }
            return MaxCount;

        }
    }
}
