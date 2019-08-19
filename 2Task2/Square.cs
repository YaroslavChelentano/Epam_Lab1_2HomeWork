using System;
namespace lab2task2
{
    public class SquareReadOnly : FigureReadOnly
    {
        public SquareReadOnly(double x, double y) : base(x, y)
        {
        }
        public override void Draw()
        {
            Console.WriteLine("I am Square");
        }
    }
}
