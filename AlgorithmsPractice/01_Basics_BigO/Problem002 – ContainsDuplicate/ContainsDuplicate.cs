using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice._01_Basics_BigO.Problem002___ContainsDuplicate
{
    internal static class ContainsDuplicate
    {
        public static bool CheckDuplicates(int[] num)
        {
            var arr = num;
            for(var i = 0; i < arr.Length; i++)
            {
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j]) 
                    {
                        return true;
                    } 
                }
            }
            return false;
        }
    }
}
