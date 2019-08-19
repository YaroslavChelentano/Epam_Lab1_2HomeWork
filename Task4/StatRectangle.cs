using System;
namespace lab1task4
{
    public static class StatRectangle
    {
        public static double AB, BC; // ініціалізація сторін
        public static double perimeter(double leftTopX, double leftTopY, double rightDownX, double rightDownY)
        {
            AB = rightDownX - leftTopX;
            BC = leftTopY - rightDownY;
            return (2 * (AB + BC));
        }
        public static double square(double leftTopX, double leftTopY, double rightDownX, double rightDownY)
        {
            AB = rightDownX - leftTopX;
            BC = leftTopY - rightDownY;
            return AB * BC;
        }
    }
}
