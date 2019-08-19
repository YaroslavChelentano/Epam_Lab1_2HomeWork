using System;
namespace lab2task2
{
    public class RectangleReadOnly : FigureReadOnly
    {
        public RectangleReadOnly(double x, double y) : base(x, y)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("I am Rectangle");
        }
    }
}
