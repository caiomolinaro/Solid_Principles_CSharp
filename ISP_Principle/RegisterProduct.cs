namespace ISP_Principle;

internal class RegisterProduct : IPersistence
{
    public void ValidateData()
    {
        Console.WriteLine("Validate data");
    }

    public void SaveDataBase()
    {
        Console.WriteLine("Save data");
    }
}