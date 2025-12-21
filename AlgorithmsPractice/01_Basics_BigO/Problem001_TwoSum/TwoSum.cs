
namespace AlgorithmsPractice._01_Basics_BigO.Problem001_TwoSum
{

    public static class TwoSum
    {
        public static List<int> CheckTwoSum(int target, int[] arr)
        {
            var list = new List<int>();
            var flag = false;
           

            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        flag = true;
                        list.Add(i);
                        list.Add(j);
                        break;
                    }
                }
                if (flag == true)
                    break;
            }
            return list;
        }
    }
}
