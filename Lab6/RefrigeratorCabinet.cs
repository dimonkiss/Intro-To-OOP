namespace Lab6;

public class RefrigeratorCabinet
{
    private Housing housing;
    private Door door;
    private ThermalInsulation insulation;

    public RefrigeratorCabinet(Housing housing, Door door, ThermalInsulation insulation)
    {
        this.housing = housing;
        this.door = door;
        this.insulation = insulation;
    }
}