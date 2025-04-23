using Xunit;
using System;

namespace HandsOn4.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
    }

    public class ATests
    {
        [Fact]
        public void Test_f1()
        {
            Assert.Equal(2, A.f1(1));
        }

        [Fact]
        public void Test_f2()
        {
            Assert.Equal(4, A.f2(2));
        }

        [Fact]
        public void Test_f5_ValidInput()
        {
            Assert.Equal(2.5, A.f5(5, 2));
        }

        [Fact]
        public void Test_f5_DivideByZero()
        {
            Assert.Throws<DivideByZeroException>(() => A.f5(5, 0));
        }

        [Fact]
        public void Test_f6_ValidInput()
        {
            Assert.Equal(8, A.f6(3));
        }

        [Fact]
        public void Test_f6_NegativeInput()
        {
            Assert.Throws<ArgumentException>(() => A.f6(-1));
        }

        [Fact]
        public void Test_f7_ValidInput()
        {
            Assert.Equal("hello more stuff", A.f7("hello"));
        }

        [Fact]
        public void Test_f7_NullOrEmptyInput()
        {
            Assert.Throws<ArgumentException>(() => A.f7(null));
            Assert.Throws<ArgumentException>(() => A.f7(""));
        }

        [Fact]
        public void Test_f8()
        {
            var a = new Class1();
            Assert.Equal(9, a.f8(1));
        }
    }
}