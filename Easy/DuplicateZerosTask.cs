using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Easy
{
    internal class DuplicateZerosTask
    {
        public static void StartUp()
        {
            DuplicateZeros(0, 0, 0, 0, 0, 0, 0);

        }
        public static void DuplicateZeros(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {

                    int j = arr.Length - 1;
                    for (; j > i; j--) arr[j] = arr[j - 1];
                    arr[j] = 0;
                    i++;
                }
            }
       
        }
    }
}
