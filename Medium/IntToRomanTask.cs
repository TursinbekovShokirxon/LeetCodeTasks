namespace LeetCodeTasks.Medium
{
    internal class IntToRomanTask
    {
        public static void StartUp() {
            foreach (var item in PlusOne (1,2,3))
            {
                Console.WriteLine(item);
            }
        }
        public static int[] PlusOne(params int[] digits)
        {
            List<int> result = new List<int>();
            var strings="";
            foreach (var item in digits)
            {
                strings += item.ToString();
            }
           
            int sum=Convert.ToInt32(strings)+1;
            while (sum > 0) {
                result.Add(sum%10);
                sum /= 10;
            }
            result.Reverse();
            return result.ToArray() ;
        }
    }
}
