namespace Lab6;

public class SmartAirConditioner : Refrigerator
{
    
    public SmartAirConditioner(EmbeddedMicroprocessor microprocessor, ElectricalEquipment electricalEquipment, RefrigeratorCabinet refrigeratorCabinet)
        : base(microprocessor, electricalEquipment, refrigeratorCabinet, 10,10)
    {
        // Додаткові налаштування для кондиціонера
    }

    // Метод для ввімкнення кондиціонера
    public void TurnOn()
    {
        Console.WriteLine("Розумний кондиціонер увімкнено.");
        // Додаткові дії при ввімкненні
    }

    // Метод для вимкнення кондиціонера
    public void TurnOff()
    {
        Console.WriteLine("Розумний кондиціонер вимкнено.");
        // Додаткові дії при вимкненні
    }

    // Метод для регулювання температури кондиціонера
    public void SetTemperature(double temperature)
    {
        Console.WriteLine($"Температура кондиціонера встановлена на {temperature} градусів Цельсія.");
        // Додаткові дії при зміні температури
    }
}