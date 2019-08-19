using System;
namespace lab2task4
{
    public class RectangleDraw : FigureDraw, IDrawable
    {
        public RectangleDraw(double x, double y) : base(x, y)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("I am Rectangle");
        }
    }
}
