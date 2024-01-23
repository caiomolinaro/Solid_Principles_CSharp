namespace LSP_Principle2;

internal class CalculateSum : Calculator
{
    public CalculateSum(int[] numbers) : base(numbers)
    { }

    public override int Calculate() => _numbers.Sum();
}