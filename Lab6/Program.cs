
namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створення екземплярів необхідних компонентів для розумного кондиціонера
            EmbeddedMicroprocessor microprocessor = new EmbeddedMicroprocessor();
            ElectricalEquipment electricalEquipment = new ElectricalEquipment(new ElectricMotor(), new Compressor(), new Evaporator(), new Condenser(), new Thermostat(), new Refrigerant(), new AutomationDevices());
            RefrigeratorCabinet refrigeratorCabinet = new RefrigeratorCabinet(new Housing(), new Door(), new ThermalInsulation());


            // Створення розумного кондиціонера
            SmartAirConditioner smartAC = new SmartAirConditioner(microprocessor, electricalEquipment, refrigeratorCabinet);

            // Увімкнення розумного кондиціонера
            smartAC.TurnOn();

            // Встановлення температури
            smartAC.SetTemperature(22.5);

            // Вимкнення розумного кондиціонера
            smartAC.TurnOff();

            Console.ReadLine();
        }
    }
}