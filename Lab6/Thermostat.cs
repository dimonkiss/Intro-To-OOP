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
}