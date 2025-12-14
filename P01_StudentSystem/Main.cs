using P01_StudentSystem.Data;

class Program
{
    static void Main()
    {
        using var context = new StudentSystemContext();
        Console.WriteLine("EF Core is ready!");
    }
}

