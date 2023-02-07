namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //GIVEN
            int a = 10, b = 20, c;
            //WHEN
            c = a + b;
            //THEN 
            Assert.Equal(30, c);
        }
        [Theory]
        [InlineData(2,2,4)]
        [InlineData(8,2,10)]
        [InlineData(40,2,42)]
        public void canAddTwoNums(int a, int b, int expected)
        {
            int answer = a + b;
            Assert.Equal(expected, answer);
        }

    }
}