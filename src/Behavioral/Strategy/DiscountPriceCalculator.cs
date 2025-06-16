namespace Strategy;

// The Context maintains a reference to one of the concrete
// strategies and communicates with this object only via the
// strategy interface.
public class DiscountPriceCalculator
{
    private IDiscountStrategy _discountStrategy;

    public DiscountPriceCalculator(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public void SetDiscountStrategy(IDiscountStrategy strategy)
    {
        _discountStrategy = strategy;
    }

    public decimal CalculatePrice(decimal originalPrice)
    {
        return _discountStrategy.GetDiscountedPrice(originalPrice);
    }
}
