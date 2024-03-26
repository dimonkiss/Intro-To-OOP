namespace Lab6;

public class Condenser
{
    // Унікальний ідентифікатор конденсатора
    private int id;
    
    // Площа поверхні конденсатора в квадратних метрах (м²)
    private double surfaceArea;
    
    // Матеріал, з якого виготовлений конденсатор
    private string material;
    
    // Тип конденсатора (наприклад, повітряний, водяний, тощо)
    private string type;
    
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public double SurfaceArea
    {
        get { return surfaceArea; }
        set { surfaceArea = value; }
    }

    public string Material
    {
        get { return material; }
        set { material = value; }
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }
}