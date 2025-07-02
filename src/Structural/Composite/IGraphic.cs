
namespace Composite
{
    // The component interface declares common operations for both
    // simple and complex objects of a composition
    public interface IGraphic
    {
        public void Move (int x, int y);

        public void Draw();
    }
}
