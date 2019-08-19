using System;
namespace lab1task4
{
    public static class StatCircle
    {
        const double PI = 3.14; // константа PI
        public static double length(double radius)
        {
            return radius * 2 * PI;
        }
        public static double square(double radius)
        {
            return PI * (radius * radius);
        }
    }
}
