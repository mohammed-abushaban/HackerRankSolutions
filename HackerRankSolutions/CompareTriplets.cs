namespace HackerRankSolutions
{
    public class CompareTriplets
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new(new[] { 0, 0 });
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i]) result[0]++;
                else if (b[i] > a[i]) result[1]++;
            }
            return result;
        }
    }
}