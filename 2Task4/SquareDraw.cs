using System;
namespace lab2task4
{
    public class SquareDraw : FigureDraw, IDrawable
    {
        public SquareDraw(double x, double y) : base(x, y)
        {
        }
        public override void Draw()
        {
            Console.WriteLine("I am Square");
        }
    }
}
