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
}