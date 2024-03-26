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
    
    public Housing Housing
    {
        get { return housing; }
        set { housing = value; }
    }

    public Door Door
    {
        get { return door; }
        set { door = value; }
    }

    public ThermalInsulation Insulation
    {
        get { return insulation; }
        set { insulation = value; }
    }
}