using System;
namespace lab2task2
{
    public abstract class FigureReadOnly
    {
        public abstract void Draw();
        readonly double X, Y;
        public FigureReadOnly(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
