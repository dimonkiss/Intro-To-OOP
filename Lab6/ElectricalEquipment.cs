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
    
    public ElectricMotor Motor
    {
        get { return motor; }
        set { motor = value; }
    }

    public Compressor Compressor
    {
        get { return compressor; }
        set { compressor = value; }
    }

    public Evaporator Evaporator
    {
        get { return evaporator; }
        set { evaporator = value; }
    }

    public Condenser Condenser
    {
        get { return condenser; }
        set { condenser = value; }
    }

    public Thermostat Thermostat
    {
        get { return thermostat; }
        set { thermostat = value; }
    }

    public Refrigerant Refrigerant
    {
        get { return refrigerant; }
        set { refrigerant = value; }
    }

    public AutomationDevices AutomationDevices
    {
        get { return automationDevices; }
        set { automationDevices = value; }
    }
}