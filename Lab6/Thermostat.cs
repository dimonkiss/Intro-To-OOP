namespace Lab6;

public class Thermostat
{
    // Унікальний ідентифікатор терморегулятора
    private int id;
    
    // Максимальна температура, яку може виміряти або регулювати терморегулятор, в градусах Цельсія (°C)
    private double maxTemperature;
    
    // Мінімальна температура, яку може виміряти або регулювати терморегулятор, в градусах Цельсія (°C)
    private double minTemperature;
    
    // Точність вимірювання температури терморегулятора, в градусах Цельсія (°C)
    private double temperatureAccuracy;
    
    // Тип терморегулятора (аналоговий, цифровий, програмований тощо)
    private string type;
    
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public double MaxTemperature
    {
        get { return maxTemperature; }
        set { maxTemperature = value; }
    }

    public double MinTemperature
    {
        get { return minTemperature; }
        set { minTemperature = value; }
    }

    public double TemperatureAccuracy
    {
        get { return temperatureAccuracy; }
        set { temperatureAccuracy = value; }
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }
}