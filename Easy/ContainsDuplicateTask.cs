namespace LeetCodeTasks.Easy
{
    internal class ContainsDuplicateTask
    {
        public static void StartUp()
        {
            Console.WriteLine(ContainsDuplicate(new int[] { 1, 2, 3, 4}));
        }
        public static bool ContainsDuplicate(int[] nums)
        {
            return nums.Distinct().Count()!=nums.Count();
        }

    }
}
