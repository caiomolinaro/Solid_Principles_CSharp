namespace Open_Close_Principle_Extensions_Methods.Extensions;

public static class ProductExtensions
{
    public static double ProfitMargin(this Product product)
    {
        try
        {
            var netProfit = product.Sale - product.Cost;
            var profitMargin = (netProfit / product.Sale) * 100;
            return Convert.ToDouble(profitMargin);
        }
        catch (Exception)
        {
            throw new InvalidOperationException("Error to calcule");
        }
    }
}