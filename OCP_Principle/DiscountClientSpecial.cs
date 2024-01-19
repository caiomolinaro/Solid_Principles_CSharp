namespace OCP_Principle
{
    internal class DiscountClientSpecial : Order
    {
        public override double DiscountOrder(double finalPrice)
        {
            return finalPrice - 50;
        }
    }
}