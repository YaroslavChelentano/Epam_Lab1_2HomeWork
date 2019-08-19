using System;
namespace lab2task3
{
    public class FigureVirtual
    {
        public virtual void Draw()
        {
            Console.WriteLine("I am Figure");
        }
        readonly double X, Y;
        public FigureVirtual(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
