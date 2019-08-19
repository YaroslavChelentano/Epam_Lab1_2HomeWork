using System;

namespace lab1task2
{

    public class Rectangle_Auto_Implemented
    {

        public double leftTopX { get; set; }
        public double leftTopY { get; set; }
        public double rightDownX { get; set; }
        public double rightDownY { get; set; }
        public double AB, BC;
        /*
        public Rectangle_Auto_Implemented(double leftTopX, double leftTopY, double rightDownX, double rightDownY)
        {
            this.leftTopX = leftTopX;
            this.leftTopY = leftTopY;
            this.rightDownX = rightDownX;
            this.rightDownY = rightDownY;
            AB = leftTopX - rightDownX;
            BC = leftTopY - rightDownY;
        }
        */
        public double GetPerimeter
        {
            get
            {
                AB = rightDownX - leftTopX;
                BC = leftTopY - rightDownY;
                return 2 * (AB + BC);
            }
        }

        public double GetSquare
        {
            get
            {
                AB = rightDownX - leftTopX;
                BC = leftTopY - rightDownY;
                return AB * BC;
            }
        }
    }
}