using Xunit;
using FizzBuzzApp;

namespace FizzBuzzTests
{
    public class UnitTest1
    {
        [Fact]
        public void Send1_Expect1()
        {
            const int expected = 1;
            var actual = FizzBuzz.GetFizzBuzz(expected);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Send3_ExpectFizz()
        {
            const string expected = "Fizz";
            var actual = FizzBuzz.GetFizzBuzz(3);
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void Send5_ExpectBuzz()
        {
            const string expected = "Buzz";
            var actual = FizzBuzz.GetFizzBuzz(5);
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void Send15_ExpectFizzBuzz()
        {
            const string expected = "FizzBuzz";
            var actual = FizzBuzz.GetFizzBuzz(15);
            Assert.Equal(expected,actual);
        }

    }
}
