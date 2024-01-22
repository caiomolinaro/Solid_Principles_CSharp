using LSP_Principle2;

var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

Calculator numbersSum = new CalculateSum(numbers);
Console.WriteLine(numbersSum.Calculate());

CalculateSumEvenNumbers evenSum = new CalculateSumEvenNumbers(numbers);
Console.WriteLine(evenSum.Calculate());