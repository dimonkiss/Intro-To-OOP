
namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Створення екземплярів необхідних компонентів для розумного кондиціонера
            // EmbeddedMicroprocessor microprocessor = new EmbeddedMicroprocessor();
            // ElectricalEquipment electricalEquipment = new ElectricalEquipment(new ElectricMotor(), new Compressor(), new Evaporator(), new Condenser(), new Thermostat(), new Refrigerant(), new AutomationDevices());
            // RefrigeratorCabinet refrigeratorCabinet = new RefrigeratorCabinet(new Housing(), new Door(), new ThermalInsulation());
            //
            //
            // // Створення розумного кондиціонера
            // SmartAirConditioner smartAC = new SmartAirConditioner(microprocessor, electricalEquipment, refrigeratorCabinet);
            //
            // // Увімкнення розумного кондиціонера
            // smartAC.TurnOn();
            //
            // // Встановлення температури
            // smartAC.SetTemperature(22.5);
            //
            // // Вимкнення розумного кондиціонера
            // smartAC.TurnOff();
            //
            // Console.ReadLine();
            
            try
            {
                // Створення екземпляру холодильника
                Refrigerator myRefrigerator = new Refrigerator(new EmbeddedMicroprocessor(), 
                    new ElectricalEquipment(new ElectricMotor(), new Compressor(), new Evaporator(), new Condenser(), new Thermostat(), new Refrigerant(), new AutomationDevices()), 
                    new RefrigeratorCabinet(new Housing(), new Door(), new ThermalInsulation()),100,-100);

                // Використання холодильника (наприклад, включення)
                myRefrigerator.TurnOn();

                // Моделювання збою в роботі холодильника (наприклад, компресор вийшов з ладу)
                myRefrigerator.SimulateMalfunction();

                // Використання холодильника після збою (наприклад, спроба відкрити дверцята)
                myRefrigerator.OpenDoor(); // Викине виключення, бо холодильник вийшов з ладу
            }
            catch (RefrigeratorMalfunctionException ex)
            {
                // Обробка збоїв в роботі холодильника
                Console.WriteLine("Збій в роботі холодильника: " + ex.Message);
            }
            
            try
            {
                // Введення даних про холодильник
                Console.WriteLine("Введіть максимальну температуру:");
                int maxTemperature = int.Parse(Console.ReadLine());

                Console.WriteLine("Введіть мінімальну температуру:");
                int minTemperature = int.Parse(Console.ReadLine());

                // Створення екземпляра холодильника з введеними даними
                Refrigerator myRefrigerator = new Refrigerator(new EmbeddedMicroprocessor(), 
                    new ElectricalEquipment(new ElectricMotor(), new Compressor(), new Evaporator(), new Condenser(), new Thermostat(), new Refrigerant(), new AutomationDevices()), 
                    new RefrigeratorCabinet(new Housing(), new Door(), new ThermalInsulation()),maxTemperature, minTemperature);
            }
            catch (FormatException ex)
            {
                // Обробка помилки введення даних (некоректний формат числа)
                Console.WriteLine("Помилка введення даних: " + ex.Message);
            }
        }
    }
}