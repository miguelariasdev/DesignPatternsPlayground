namespace Strategy;

// It declares a method the context uses to execute a strategy.
public interface IDiscountStrategy
{
    decimal GetDiscountedPrice(decimal originalPrice);
}
