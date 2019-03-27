namespace FizzBuzzApp
{
    public class FizzBuzz
    {
        public static string GetFizzBuzz(int i, bool @ascending)
        {
            string s = null;
            if (@ascending)
            {

                if (i % 3 == 0)
                    s = "Fizz";

                if (i % 5 == 0)
                    s += "Buzz";
            }
            else
            {
                if (i % 9 == 0)
                    s = "Jazz";
                if (i % 4 == 0)
                    s = "Fuzz";
            }

            return s ?? i.ToString();
        }
    }
}
