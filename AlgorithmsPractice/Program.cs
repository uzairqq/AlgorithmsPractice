using AlgorithmsPractice._01_Basics_BigO.Problem001_TwoSum;

namespace AlgorithmsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TwoSum.TwoSumCheck([2, 7, 11, 15], 9);   // expect [0,1]
            TwoSum.TwoSumCheck([3, 2, 4], 6);        // expect [1,2]
            TwoSum.TwoSumCheck([3, 3], 6);           // expect [0,1]
            TwoSum.TwoSumCheck([1, 2, 3], 6);        // expect no pair
        }
    }
}
