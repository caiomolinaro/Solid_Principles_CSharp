namespace Open_Close_Principle_Extensions_Methods;

public class Product
{
    public int ProductId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    private decimal _cost = 0;

    public decimal Cost
    {
        get => _cost;
        private set
        {
            if (value > 0)
                _cost = value;
        }
    }

    private decimal _sale = 1;

    public Product(int productId, string? name, string? description, decimal cost, decimal sale, int stock, bool active)
    {
        ProductId = productId;
        Name = name;
        Description = description;
        Cost = cost;
        Sale = sale;
        Stock = stock;
        Active = active;
    }

    public decimal Sale
    {
        get => _sale;
        private set
        {
            if (value > 0)
                _sale = value;
        }
    }

    public int Stock { get; set; }
    public bool Active { get; set; }
}