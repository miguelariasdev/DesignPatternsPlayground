namespace Strategy.ConcreteStrategies
{
    public class SeniorDiscount : IDiscountStrategy
    {
        public decimal GetDiscountedPrice(decimal originalPrice)
        {
            return originalPrice * 0.6m;
        }
    }
}
