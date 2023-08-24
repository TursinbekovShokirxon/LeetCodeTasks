namespace LeetCodeTasks.Medium
{
    internal class RotateTask
    {
        public void Rotate(int[] nums, int k)
        {
            for (int i = 0; i < k; i++)
            {
                int LastNum = nums[nums.Length - 1];
                for (int j = 0; j < nums.Length - 1; j++) if (j != 0) nums[j] = nums[j+1];
                nums[0] = LastNum;
            }
        }
    }
}
