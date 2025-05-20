namespace Singleton.Tests;

public class UnitTest1
{
    [Fact]
    public void Instance_Should_Return_Same_Reference()
    {
        // Act
        var first = Logger.Instance;
        var second = Logger.Instance;

        // Assert
        Assert.Same(first, second);  // Ambos apuntan al mismo objeto
    }
}
