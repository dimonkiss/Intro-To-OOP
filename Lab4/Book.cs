namespace Lab3;

public class Book
{
    private string Name;
    private double Price;
    
    public Book()
    {
        // За замовчуванням присвоюємо пусті рядок для імені та 0.0 для ціни
        Name = "";
        Price = 0.0;
    }
    
    public Book(string name, double price)
    {
        Name = name;
        Price = price;
    }
    
    public string NameProp
    {
        get { return Name; }
        set { Name = value; }
    }

    public double PriceProp
    {
        get { return Price; }
        set { Price = value; }
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Price: $" + Price);
    }
    
    public virtual double CalculateBookPopularityRating(double weeklySales, double monthlySales)
    {
        // Можна реалізувати складнішу логіку розрахунку залежно від конкретних вимог
        return weeklySales * 0.5 + monthlySales * 0.5;
    }
}