
namespace Composite
{
    // Container class (composite)
    internal class CompoundGraphic : IGraphic
    {
        private readonly List<IGraphic> _children = new();

        public IReadOnlyList<IGraphic> Children => _children;

        public void Add(IGraphic child) => _children.Add(child);
        public void Remove(IGraphic child) => _children.Remove(child);

        public void Move(int dx, int dy)
        {
            foreach (var child in _children)
            {
                child.Move(dx, dy);
            }
        }

        public void Draw()
        {
            Console.WriteLine("Begin CompoundGraphic");
            foreach (var child in _children)
            {
                child.Draw();
            }
            Console.WriteLine("End   CompoundGraphic");
        }
    }
}
