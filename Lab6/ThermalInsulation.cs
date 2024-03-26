namespace Lab6;

public class ThermalInsulation
{
    // Унікальний ідентифікатор теплоізоляції
    private int id;
    
    // Матеріал, з якого виготовлена теплоізоляція
    private string material;
    
    // Товщина теплоізоляції в метрах (м)
    private double thickness;
    
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Material
    {
        get { return material; }
        set { material = value; }
    }

    public double Thickness
    {
        get { return thickness; }
        set { thickness = value; }
    }
}