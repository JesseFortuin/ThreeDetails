namespace ThreeDetails.BL
{
    public class ThreeDetailsCalculator : IThreeDetailsCalculator
    {
        public int ThreeDetails(int n)
        {
            if (n == 3)
            {
                return 1;
            }
            
            if (n <= 2)
            {
                return 0;
            }

            var list = Enumerable.Range(1, n);

            var evenNumberCount = list.Where(x => x % 2 == 0).Count();

            var oddNumberCount = list.Where(x => x % 2 != 0).Count();

            return ThreeDetails(evenNumberCount) + ThreeDetails(oddNumberCount);
        }
    }
}