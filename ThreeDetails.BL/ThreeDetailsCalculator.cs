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

            if (n <= 4)
            {
                return 0;
            }

            return n;
        }
    }
}