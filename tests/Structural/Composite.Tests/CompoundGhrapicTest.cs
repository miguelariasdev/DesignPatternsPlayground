using Composite;

namespace Composite.Tests;

public class CompoundGhrapicTest
{
    [Fact]
    public void CreateCompoundGhrapicTree_AddsChildrenCorrectly()
    {
        // Arrange
        var tree = new CompoundGraphic();

        var dot1 = new Dot(1, 2);
        var dot2 = new Dot(3, 4);
        var circle = new Circle(5, 6, 10);

        // Act
        tree.Add(dot1);
        tree.Add(dot2);
        tree.Add(circle);

        // Assert
        Assert.Equal(3, tree.Children.Count);
        Assert.Contains(dot1, tree.Children);
        Assert.Contains(dot2, tree.Children);
        Assert.Contains(circle, tree.Children);
    }

    [Fact]
    public void Move_PropagatesToAllChildren()
    {
        // Arrange
        var tree = new CompoundGraphic();
        var dot = new Dot(0, 0);
        var circle = new Circle(1, 1, 5);

        tree.Add(dot);
        tree.Add(circle);

        // Act
        tree.Move(2, 3);

        // Assert
        Assert.Equal(2, dot.X);
        Assert.Equal(3, dot.Y);
        Assert.Equal(3, circle.X);
        Assert.Equal(4, circle.Y);
    }

    [Fact]
    public void Draw_PrintsAllChildrenOutput()
    {
        // Arrange
        var tree = new CompoundGraphic();
        var dot = new Dot(0, 0);
        var circle = new Circle(1, 1, 5);
        tree.Add(dot);
        tree.Add(circle);

        using var sw = new StringWriter();
        Console.SetOut(sw);

        // Act
        tree.Draw();

        // Assert
        var output = sw.ToString();
        Assert.Contains("Draw Dot at (0, 0)", output);
        Assert.Contains("Draw a circle at (1, 1) with radius 5", output);
    }

    [Fact]
    public void NestedCompoundGraphics_AllowDeepComposition()
    {
        // Arrange
        var inner = new CompoundGraphic();
        var outer = new CompoundGraphic();

        var dot = new Dot(1, 1);
        inner.Add(dot);
        outer.Add(inner);

        // Act
        outer.Move(2, 2);

        // Assert
        Assert.Equal(3, dot.X);
        Assert.Equal(3, dot.Y);
    }
}
