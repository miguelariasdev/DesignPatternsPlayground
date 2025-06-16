namespace Strategy.ConcreteStrategies
{
    public class TeenagerDiscount : IDiscountStrategy
    {
        public decimal GetDiscountedPrice(decimal originalPrice)
        {
            return originalPrice * 0.7m;
        }
    }
}
