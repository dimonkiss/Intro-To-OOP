namespace Lab6;

public class ElectricalEquipment
{
    private ElectricMotor motor;
    private Compressor compressor;
    private Evaporator evaporator;
    private Condenser condenser;
    private Thermostat thermostat;
    private Refrigerant refrigerant;
    private AutomationDevices automationDevices;

    public ElectricalEquipment(ElectricMotor motor, Compressor compressor, Evaporator evaporator, 
        Condenser condenser, Thermostat thermostat, Refrigerant refrigerant, 
        AutomationDevices automationDevices)
    {
        this.motor = motor;
        this.compressor = compressor;
        this.evaporator = evaporator;
        this.condenser = condenser;
        this.thermostat = thermostat;
        this.refrigerant = refrigerant;
        this.automationDevices = automationDevices;
    }
}