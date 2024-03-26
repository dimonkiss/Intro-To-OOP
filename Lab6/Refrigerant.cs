namespace Lab6;

public class Refrigerant
{
    // Унікальний ідентифікатор холодоагента
    private int id;
    
    // Назва холодоагента
    private string name;
    
    // Температура кипіння холодоагента в градусах Цельсія (°C)
    private double boilingTemperature;
    
    // Температура кристалізації холодоагента в градусах Цельсія (°C)
    private double freezingTemperature;
    
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double BoilingTemperature
    {
        get { return boilingTemperature; }
        set { boilingTemperature = value; }
    }

    public double FreezingTemperature
    {
        get { return freezingTemperature; }
        set { freezingTemperature = value; }
    }
}