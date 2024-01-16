namespace Single_Responsability_Principle;

internal class RegisterLog : ILogger

{
    public void Info(string info)
    {
        Console.WriteLine(info);
    }
}