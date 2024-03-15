namespace Lab5;

public class TextBookWithAbstract : AbstractBook
{
    public string Author { get; set; }
    public int QuantityOfPages { get; set; }
    public double Rating { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"TextBook: {Name}, Author: {Author}, Price: {Price}, Pages: {QuantityOfPages}, Rating: {Rating}");
    }
}