using ThreeDetails.BL;

namespace ThreeDetails.Test
{
    public class ThreeDetailsCalculatorTest
    {
        [Theory]
        [InlineData(6, 2)]
        [InlineData(7, 1)]
        [InlineData(4, 0)]
        [InlineData(10, 2)]
        [InlineData(15, 1)]
        [InlineData(3, 1)]
        [InlineData(16, 0)]
        [InlineData(40, 8)]
        [InlineData(29, 3)]
        [InlineData(24, 8)]

        public void Test1(int input, int expected)
        {
            //arrange
            IThreeDetailsCalculator details = new ThreeDetailsCalculator();

            //act
            int actual = details.ThreeDetails(input);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}