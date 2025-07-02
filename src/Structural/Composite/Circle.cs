
namespace Composite
{
    // Component class
    public class Circle : Dot
    {
        public int Radius { get; private set; }

        public Circle(int x, int y, int radius) : base(x, y)
        {
            Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Draw a circle at ({X}, {Y}) with radius {Radius}");
        }
    }
}
