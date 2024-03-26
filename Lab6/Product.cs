namespace Lab6;

public class Product
{
    private string name;
    private DateTime expiryDate;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public DateTime ExpiryDate
    {
        get { return expiryDate; }
        set { expiryDate = value; }
    }

    // Конструктор для зручності ініціалізації
    public Product(string name, DateTime expiryDate)
    {
        Name = name;
        ExpiryDate = expiryDate;
    }
}