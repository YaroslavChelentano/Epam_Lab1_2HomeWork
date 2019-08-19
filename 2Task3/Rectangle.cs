using System;
namespace lab2task3
{
    public class RectangleVirtual : FigureVirtual
    {
        public RectangleVirtual(double x, double y) : base(x, y)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("I am Rectangle");
        }
    }
}
