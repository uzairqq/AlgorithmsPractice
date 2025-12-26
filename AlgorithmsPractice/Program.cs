using AlgorithmsPractice._01_Basics_BigO.Problem002___ContainsDuplicate;

namespace AlgorithmsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContainsDuplicate.CheckDuplicates(new[] { 2, 7, 11, 15 }));   // false
            Console.WriteLine(ContainsDuplicate.CheckDuplicates(new[] { 1, 2, 3, 4 }));     // false
            Console.WriteLine(ContainsDuplicate.CheckDuplicates(new[] { 5, 5, 5 }));        // true
            Console.WriteLine(ContainsDuplicate.CheckDuplicates(Array.Empty<int>()));       // false

            Console.WriteLine("All tests executed.");
            Console.ReadLine();
        }
    }
}
