namespace HackerRankSolutions
{
    public class SimpleArraySum
    {
        public static int simpleArraySum(List<int> ar)
        {
            if (ar.Count == 0 || ar == null) return 0;
            int sum = ar[0];
            for (int i = 1; i < ar.Count; i++)
            {
                sum += ar[i];
            }
            return sum;
        }
    }
}