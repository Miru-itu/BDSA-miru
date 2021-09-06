using System;
using Xunit;

namespace Week0.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void test_404()
        {
            bool output = Program.IsLeapYear(404);

            Assert.Equal(true, output);
        }

        [Fact]
        public void test_405()
        {
            bool output = Program.IsLeapYear(405);

            Assert.Equal(false, output);
        }

        [Fact]
        public void test_100()
        {
            bool output = Program.IsLeapYear(100);

            Assert.Equal(false, output);
        }

        [Fact]
        public void test_400()
        {
            bool output = Program.IsLeapYear(400);

            Assert.Equal(true, output);
        }
    }
}
