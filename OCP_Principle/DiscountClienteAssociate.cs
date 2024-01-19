namespace OCP_Principle;

internal class DiscountClienteAssociate : Order
{
    public override double DiscountOrder(double finalPrice)
    {
        return finalPrice - 10;
    }
}