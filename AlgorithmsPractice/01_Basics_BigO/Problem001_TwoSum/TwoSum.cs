namespace AlgorithmsPractice._01_Basics_BigO.Problem001_TwoSum
{
    public static class TwoSum
    {
        public static int[] TwoSumCheck(int[] arr, int target)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        return [i, j];
                    }
                }
            }
            return Array.Empty<int>();
        }

    }
}

