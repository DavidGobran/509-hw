using System;

namespace HandsOn4
{
    public class Class1
    {
        public static int f1(int x)
        {
            x = x + 1;
            return x;
        }

        public static int f2(int x)
        {
            x = x + 2;
            return x;
        }

        public static double f5(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("y cannot be zero");
            }
            return (double)x / y;
        }

        public static int f6(int x)
        {
            if (x < 0)
            {
                throw new ArgumentException("x can't be negative");
            }

            return x + 5;
        }

        public static string f7(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                throw new ArgumentException("Input string cannot be null or empty");
            }
            var ss = s + " more stuff";
            return ss;
        }

        public virtual int f8(int x)
        {
            // Simulate database call
            return x + 8;
        }
    }

    internal class B
    {
        internal static int g1(int x, Class1 a)
        {
            return a.f8(x);
        }
    }
}
