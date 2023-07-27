namespace LeetCodeTasks.Easy
{
    public class RomanToIntTask
    {
        public static int RomanToInt(string s)
        {
            int sum = 0;
            int i = s.Length - 1;
            while (i >= 0)
            {
                if (i == 0) sum += ReturnInt(s[0]);
                else if (ReturnInt(s[i]) > ReturnInt(s[i - 1])) sum += (ReturnInt(s[i]) - ReturnInt(s[i - 1]));
                else sum += sum += ReturnInt(s[i]);
            }
            GC.Collect();
            return sum;
        }
        public static int ReturnInt(char c)
        {
            int a = 0;
            switch (c)
            {
                case 'I': { a = 1; } break;
                case 'V': { a = 5; } break;
                case 'X': { a = 10; } break;
                case 'L': { a = 50; } break;
                case 'C': { a = 100; } break;
                case 'D': { a = 500; } break;
                case 'M': { a = 1000; } break;
            }
            return a;
        }
    }
}
