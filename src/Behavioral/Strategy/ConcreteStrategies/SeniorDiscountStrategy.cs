namespace Strategy.ConcreteStrategies
{
    public class StudentDiscountStrategy : IDiscountStrategy
    {
        public decimal GetDiscountedPrice(decimal originalPrice)
        {
            return originalPrice * 0.9m;
        }
    }
}
