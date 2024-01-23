namespace LSP_Principle2;

internal class CalculateSumEvenNumbers : Calculator
{
    public CalculateSumEvenNumbers(int[] numbers) : base(numbers)
    { }

    public override int Calculate() =>
        _numbers.Where(x => x % 2 == 0).Sum();
}