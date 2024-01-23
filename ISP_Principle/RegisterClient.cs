namespace ISP_Principle;

internal class RegisterClient : IPersistence, IMessageEmail
{
    public void ValidateData()
    {
        Console.WriteLine("Validate data");
    }

    public void SaveDataBase()
    {
        Console.WriteLine("Save data");
    }

    public void SendEmail()
    {
        Console.WriteLine("Send email");
    }
}