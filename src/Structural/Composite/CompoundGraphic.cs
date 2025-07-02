
namespace Composite
{
    // The composite class represents complex components that may
    // have children. Composite objects usually delegate the actual
    // work to their children and then "sum up" the result.
    public class CompoundGraphic : IGraphic
    {
        // childrens
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
            foreach (var child in _children)
            {
                child.Draw();
            }
        }
    }
}
