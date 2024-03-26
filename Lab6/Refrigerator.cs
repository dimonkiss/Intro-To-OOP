namespace Lab6;

public class Refrigerator
{
    private EmbeddedMicroprocessor microprocessor;
    private ElectricalEquipment electricalEquipment;
    private RefrigeratorCabinet refrigeratorCabinet;

    public Refrigerator(EmbeddedMicroprocessor microprocessor, ElectricalEquipment electricalEquipment, 
        RefrigeratorCabinet refrigeratorCabinet)
    {
        this.microprocessor = microprocessor;
        this.electricalEquipment = electricalEquipment;
        this.refrigeratorCabinet = refrigeratorCabinet;
    }
}