namespace HackerRankSolutions
{
    public class AVeryBigSum
    {
        public static long aVeryBigSum(List<long> ar)
        {
            var sum = ar[0];
            for (int i = 1; i < ar.Count; i++)
            {
                sum += ar[i];
            }
            return sum;
        }
    }
}