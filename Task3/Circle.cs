using System;
namespace lab1task3
{
    public class Circle
    {
        const double PI = 3.14; // константа PI
        public double length(double radius)
        {
            return radius * 2 * PI;
        }
        public double square(double radius)
        {
            return PI * (radius * radius);
        }
    }

}