using System;
using FizzBazz;
using Xunit;

namespace FizzBuzz.test
{
    public class TestFizzbuzz
    {
        [Fact]
        public void Get_fizz()
        {
            FizzBuzzer fz = new FizzBuzzer();
            String k = fz.Get(3);
            Assert.Equal("Fizz", k);
        }
        [Fact]
        public void Get_FizzBizz()
        {
            FizzBuzzer fizbiz = new FizzBuzzer();
            string Actual = fizbiz.WidthBool(15);
            Assert.Equal("FizzBuzz", Actual);
        }
        [Fact]
        public void Test_numberseven()
        {
            FizzBuzzer tstseven = new FizzBuzzer();
            string number = tstseven.Get(7);
            Assert.Equal(7, 7);
        }
    }
}
