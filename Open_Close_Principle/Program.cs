using Open_Close_Principle_Extensions_Methods;
using Open_Close_Principle_Extensions_Methods.Extensions;

Product product1 = new Product(
    1,
    "Pen",
    "Blue pen",
    2.00M,
    3.40M,
    100,
    true
    );

Console.WriteLine($"{product1.Name} Profit = {product1.ProfitMargin()}");