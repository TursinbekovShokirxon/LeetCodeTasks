namespace LeetCodeTasks.Easy
{
    public class RemoveElementTask
    {
        public static void StartUp()
        {
            Console.WriteLine(RemoveElement(new int[] { 3, 2, 2, 3 }, 3));


        }
        public static int RemoveElement(int[] nums, int val)
        {
            byte current = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[current] = nums[i];
                    current++;
                }
            }
            return current;
        }
    }
}
