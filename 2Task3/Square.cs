using System;
namespace lab2task3
{
    public class SquareVirtual : FigureVirtual
    {
        public SquareVirtual(double x, double y) : base(x, y)
        {
        }
        public override void Draw()
        {
            Console.WriteLine("I am Square");
        }
    }
}
