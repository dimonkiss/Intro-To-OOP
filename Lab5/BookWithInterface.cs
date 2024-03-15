namespace Lab5;

public class BookWithInterface : IBook
{
    public string Name { get; set; }
    public double Price { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Book: {Name}, Price: {Price}");
    }
}