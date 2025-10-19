using ConsoleApp1;

namespace CountingXUnitTests
{
    public class Counting_MethodTests
    {
        [Theory]
        [InlineData("",0)]
        [InlineData("AAAAAAAAAAAAA", 0)]
        [InlineData("ABCD54SSSDEFF", 6)]
        [InlineData("55553300977222A,,////\\\\", 2)]
        public void Counting_MaxUnequalConsecutiveChars(string text, int expected)
        {
            var actual = CountFromString.MaxUnequalConsecutiveChars(text);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("", 0)]
        [InlineData("AAABCDEEEE5553", 4)]
        [InlineData("55553300977222A,,////\\\\", 0)]
        [InlineData("JJJjWWww", 3)]
        public void Counting_MaxLatinLettersConsecutiveIdentical(string text, int expected)
        {
            var actual = CountFromString.MaxLatinLettersConsecutiveIdentical(text);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("", 0)]
        [InlineData("EEEE5553", 3)]
        [InlineData("AAABCDEEEE1", 0)]
        [InlineData("55553300977222A,,,,,////\\\\", 4)]
        public void Counting_MaxDigitsConsecutiveIdentical(string text, int expected)
        {
            var actual = CountFromString.MaxDigitsConsecutiveIdentical(text);

            Assert.Equal(expected, actual);
        }
    }
}