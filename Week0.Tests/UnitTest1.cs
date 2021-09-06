using System;
using System.IO;
using Xunit;

namespace Week0.Tests
{
    public class UnitTest1
    {
        // Old tests
        // [Fact]
        // public void test_404()
        // {
        //     bool output = Program.IsLeapYear(404);

        //     Assert.Equal(true, output);
        // }

        // [Fact]
        // public void test_405()
        // {
        //     bool output = Program.IsLeapYear(405);

        //     Assert.Equal(false, output);
        // }

        // [Fact]
        // public void test_100()
        // {
        //     bool output = Program.IsLeapYear(100);

        //     Assert.Equal(false, output);
        // }

        [Fact]
        public void test_working_number()
        {

            bool output = Program.IsLeapYear(2000);
            
            Assert.Equal(true, output);
        }

        [Fact]
        public void test_false_big_number()
        {

            bool output = Program.IsLeapYear(1999);
            
            Assert.Equal(false, output);
        }
    }
}
