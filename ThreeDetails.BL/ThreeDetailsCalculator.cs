namespace ThreeDetails.BL
{
    public class ThreeDetailsCalculator : IThreeDetailsCalculator
    {
        Dictionary<int, int> repeatedSeries = new Dictionary<int, int>();

        public int ThreeDetails(int n)
        {
            if (n == 3)
            {
                return 1;
            }
            
            if (n <= 2 || n == 4)
            {
                return 0;
            }

            if (repeatedSeries.ContainsKey(n))
            {
                return repeatedSeries[n];
            }

            var list = Enumerable.Range(1, n);

            var evenNumberCount = list.Where(x => x % 2 == 0).Count();

            var oddNumberCount = list.Count() - evenNumberCount;

            repeatedSeries.Add(n, ThreeDetails(evenNumberCount) + ThreeDetails(oddNumberCount));
            
            return ThreeDetails(evenNumberCount) + ThreeDetails(oddNumberCount);
        }
    }
}