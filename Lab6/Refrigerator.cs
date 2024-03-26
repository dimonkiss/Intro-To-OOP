namespace Lab6;

public class Refrigerator
{
    private EmbeddedMicroprocessor microprocessor;
    private ElectricalEquipment electricalEquipment;
    private RefrigeratorCabinet refrigeratorCabinet;
    private List<Product> products = new List<Product>();

    public Refrigerator(EmbeddedMicroprocessor microprocessor, ElectricalEquipment electricalEquipment, 
        RefrigeratorCabinet refrigeratorCabinet)
    {
        this.microprocessor = microprocessor;
        this.electricalEquipment = electricalEquipment;
        this.refrigeratorCabinet = refrigeratorCabinet;
    }
    
    public List<Product> Products
    {
        get { return products; }
        set { products = value; }
    }
    
    public EmbeddedMicroprocessor Microprocessor
    {
        get { return microprocessor; }
        set { microprocessor = value; }
    }

    public ElectricalEquipment ElectricalEquipment
    {
        get { return electricalEquipment; }
        set { electricalEquipment = value; }
    }

    public RefrigeratorCabinet RefrigeratorCabinet
    {
        get { return refrigeratorCabinet; }
        set { refrigeratorCabinet = value; }
    }
    
    // Метод для додавання продукту в холодильник
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Метод для видалення продукту з холодильника
    public void RemoveProduct(Product product)
    {
        products.Remove(product);
    }
}