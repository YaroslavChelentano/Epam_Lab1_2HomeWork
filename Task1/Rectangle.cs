using System;

namespace lab1task1
{

    public class Rectangle
    {
        public double leftTopX;
        public double leftTopY;
        public double rightDownX;
        public double rightDownY;
        public double AB, BC;
        public Rectangle(double leftTopX, double leftTopY, double rightDownX, double rightDownY)
        {
            this.leftTopX = leftTopX;
            this.leftTopY = leftTopY;
            this.rightDownX = rightDownX;
            this.rightDownY = rightDownY;
            AB = rightDownX - leftTopX;
            BC = leftTopY - rightDownY;
        }
        public double perimeter()
        {
            return (2 * (AB + BC));
        }
        public double square()
        {
            return AB * BC;
        }
    }
}