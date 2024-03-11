namespace Lab4;

public abstract class AbstractBook
{
    public string Name { get; set; }
    public double Price { get; set; }


    public abstract void DisplayInfo();
}