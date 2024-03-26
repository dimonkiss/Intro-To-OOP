namespace Lab6;

public class ElectricMotor
{
    // Унікальний ідентифікатор електродвигуна
    private int id;
    
    // Потужність електродвигуна в кіловатах (кВт)
    private double power;
    
    // Напруга живлення електродвигуна в вольтах (В)
    private double voltage;
    
    // Струм електродвигуна в амперах (А)
    private double current;
    
    // Кількість обертів на хвилину (об/хв)
    private int rpm;
    
    // Тип електродвигуна (постійного струму, змінного струму, синхронний, асинхронний тощо)
    private string type;
    
    
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public double Power
    {
        get { return power; }
        set { power = value; }
    }

    public double Voltage
    {
        get { return voltage; }
        set { voltage = value; }
    }

    public double Current
    {
        get { return current; }
        set { current = value; }
    }

    public int Rpm
    {
        get { return rpm; }
        set { rpm = value; }
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }
}