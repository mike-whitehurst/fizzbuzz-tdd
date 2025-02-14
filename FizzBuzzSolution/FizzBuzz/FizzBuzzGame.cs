namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public static List<string> Play(int number)
        {
            var list = new List<string>();

            for (int i = 1; i <= number; i++)
            {
                list.Add(PlaySingle(i));
            }

            return list;
        }

        internal static string PlaySingle(int number)
        {
            // Note: This could instead be divisible by 15, but the requirements didn't ask for that.
            if (number.IsDivisibleBy(3) && number.IsDivisibleBy(5))
            {
                return "FizzBuzz";
            }

            if (number.IsDivisibleBy(3))
            {
                return "Fizz";
            }

            if (number.IsDivisibleBy(5))
            {
                return "Buzz";
            }

            return number.ToString();
        }
    }
}