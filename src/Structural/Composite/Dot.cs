
namespace Composite
{
    // The leaf class represents end objects of a composition.
    // A leaf object can't have any sub-objects. Usually, it's leaf
    // objects that do the actual work, while composite objects only
    // delegate to their sub-components.
    public class Dot : IGraphic
    {
        public int X { get; private set; }

        public int Y { get; private set; }

        public Dot(int x, int y)
        {
            X = x;
            Y = y;
        }

        public virtual void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public virtual void Draw()
        {
            Console.WriteLine($"Draw Dot at ({X}, {Y})");
        }
    }
}
