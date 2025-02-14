namespace FizzBuzz.Tests
{
    public class FizzBuzzGameTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        public void PlaySingle_PrintsNumber_WhenOtherConditionsAreNotMet(int number)
        {
            var result = FizzBuzzGame.PlaySingle(number);

            Assert.Equal(number.ToString(), result);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void PlaySingle_PrintsBuzz_WhenDivisibleBy5(int number)
        {
            var result = FizzBuzzGame.PlaySingle(number);

            Assert.Equal("Buzz", result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void PlaySingle_PrintsFizz_WhenDivisibleBy3(int number)
        {
            var result = FizzBuzzGame.PlaySingle(number);

            Assert.Equal("Fizz", result);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void PlaySingle_PrintsFizzBuzz_WhenDivisibleBy3And5(int number)
        {
            var result = FizzBuzzGame.PlaySingle(number);

            Assert.Equal("FizzBuzz", result);
        }

        [Theory]
        [InlineData(3, new string[] { "1", "2", "Fizz" })]
        [InlineData(10, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz" })]
        [InlineData(20, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz", "16", "17", "Fizz", "19", "Buzz" })]
        public void Play_PrintsStringsFrom1ToN_WhenValidNumberProvided(int number, string[] expectedResult)
        {
            var result = FizzBuzzGame.Play(number);

            Assert.Equal(expectedResult, result.ToArray());
        }
    }
}