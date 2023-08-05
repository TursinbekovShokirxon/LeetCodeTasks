using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Easy
{
    internal class GcdOfStringsTask
    {
        public string GcdOfStrings(string str1, string str2)
        {
            string a = "";

            if (str1.Length > str2.Length) { a += str2[0]; return gcd(str2, str1, a); }
            else { a += str1[0]; return gcd(str1, str2, a); }       
        }
        public string gcd(string str1,string str2,string a)
        {
            string res = "";
            bool isA = false;           
            int counter = 1;
            res = str2;
            while (str2!= "")
            {
                
                while (str2.Contains(str1))
                {
                    str2 = str2.Replace(str1, "");
                    isA = true;
                }
                if (!isA) return "";
                if (str2!= "")
                {
                    str2 = res;
                    a += str2[counter];
                    counter++;
                }
                if (counter == str1.Length-1)
                {
                    return "";
                }
            }
            return str1;
        }
    }
}
