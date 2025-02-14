namespace FizzBuzz
{
    public static class IntegerExtensions
    {
        public static bool IsDivisibleBy(this int i, int divisibleBy)
        {
            return i % divisibleBy == 0;
        }
    }
}
