namespace LSP_Principle_1;

internal class Seller : Employee
{
    public double commission = 1500;

    public Seller(string? name, string? role) : base(name, role)
    {
    }

    public override double CalculateSalary(double salary)
    {
        return salary + commission;
    }
}