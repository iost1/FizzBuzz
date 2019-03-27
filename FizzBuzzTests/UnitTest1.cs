using Xunit;
using FizzBuzzApp;

namespace FizzBuzzTests
{
    public class UnitTest1
    {
        [Fact]
        public void Send1_Expect1()
        {
            const string expected = "1";
            var actual = FizzBuzz.GetFizzBuzz(1,true);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Send3_ExpectFizz()
        {
            const string expected = "Fizz";
            var actual = FizzBuzz.GetFizzBuzz(3, true);
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void Send5_ExpectBuzz()
        {
            const string expected = "Buzz";
            var actual = FizzBuzz.GetFizzBuzz(5, true);
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void Send15_ExpectFizzBuzz()
        {
            const string expected = "FizzBuzz";
            var actual = FizzBuzz.GetFizzBuzz(15, true);
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void Send4_ExpectFuzz()
        {
            const string expected = "Fuzz";
            var actual = FizzBuzz.GetFizzBuzz(4, false);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Send9_ExpectJazz()
        {
            const string expected = "Jazz";
            var actual = FizzBuzz.GetFizzBuzz(9, false);
            Assert.Equal(expected, actual);
        }

    }
}
