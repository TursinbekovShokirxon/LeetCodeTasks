using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Easy
{
    public class IsLongPressedNameTask
    {
        public static bool IsLongPressedName(string name, string typed)
        {
            int counter = 0;//"leelee", "lleeelee"
            IList<bool> list = new List<bool>();

            for (int i = 0; i < name.Length; i++)
            {
                bool isA = false;
                bool isB = false;
                for (int j = counter; j < typed.Length; j++)
                {
                    if (name[i] == typed[j]) { counter++; isA = true; }
                    if (i < name.Length - 2 && i < typed.Length - 2)
                    {
                        if (name[i + 1] == typed[j + 1]) { counter++; isB = true; }
                        else break;
                    }
                }
                if (!isA) break;
                if (isB) list.Add(isB);
                list.Add(isA);
            }
            return list.Count() == name.Length ? true : false;
        }
    }
}