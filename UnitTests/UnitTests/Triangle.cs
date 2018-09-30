using System;

namespace UnitTests
{
    public class Triangle
    {
        public Triangle() { }

        public static bool TriangleSides(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                return false;
            return a + b > c && b + c > a && c + a > b ? true : false;
        }
    }
}
