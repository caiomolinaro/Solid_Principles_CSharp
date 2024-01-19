namespace OCP_Principle
{
    internal class DiscountClientVIP : Order
    {
        public override double DiscountOrder(double finalPrice)
        {
            return finalPrice - 100;
        }
    }
}