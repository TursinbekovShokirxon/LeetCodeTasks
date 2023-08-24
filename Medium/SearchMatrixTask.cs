using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Medium
{
    internal class SearchMatrixTask
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                int length = matrix[i].Length;
                int right = matrix[i][length - 1];
                for (int j = 0; j < length; j++)
                {
                    if (target > right) break;
                    else
                    {
                        bool isA = false;
                        for (int k = 0; k < length; k++)
                        {
                         if(target== matrix[i][k])
                            {
                                isA = true;
                            }
                        }
                        return isA;
                    }
                }
            }
            return false;

        }
    }
}
