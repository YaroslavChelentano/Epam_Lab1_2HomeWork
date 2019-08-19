using System;
namespace lab2task4
{
    public class FigureDraw : IDrawable
    {
        public virtual void Draw()
        {
            Console.WriteLine("I am Figure");
        }
        readonly double X, Y;
        public FigureDraw(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public void DrawAll(params IDrawable[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Draw();
            }
        }
    }
}
