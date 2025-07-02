using Strategy.ConcreteStrategies;

namespace Strategy.Tests;

public class DiscountPriceCalculatorTests
{
    [Theory]
    [InlineData(100, 70)] // Teenager
    [InlineData(100, 60)] // Senior
    [InlineData(100, 90)] // Student
    public void DiscountPriceCalculator_ShouldApplyCorrectDiscounts(decimal originalPrice, decimal expectedPrice)
    {
        IDiscountStrategy strategy;

        if (expectedPrice == 70)
        {
            strategy = new TeenagerDiscount();
        }
        else if (expectedPrice == 60)
        {
            strategy = new SeniorDiscount();
        }
        else if (expectedPrice == 90)
        {
            strategy = new StudentDiscountStrategy();
        }
        else
        {
            throw new ArgumentException("Invalid expected price for discount strategy test.");
        }

        var calculator = new DiscountPriceCalculator(strategy);

        var discountedPrice = calculator.CalculatePrice(originalPrice);

        Assert.Equal(expectedPrice, discountedPrice);
    }

    [Fact]
    public void DiscountPriceCalculator_CanChangeStrategyAtRuntime()
    {
        var calculator = new DiscountPriceCalculator(new TeenagerDiscount());

        var initialPrice = calculator.CalculatePrice(100);
        Assert.Equal(70, initialPrice);

        calculator.SetDiscountStrategy(new SeniorDiscount());
        var updatedPrice = calculator.CalculatePrice(100);
        Assert.Equal(60, updatedPrice);
    }
}
