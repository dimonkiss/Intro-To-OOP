namespace Lab6;

public class Housing
{
    // Унікальний ідентифікатор корпусу
    private int id;
    
    // Матеріал, з якого виготовлений корпус
    private string material;
    
    // Розміри корпусу (ширина, висота, глибина) в метрах (м)
    private double width;
    private double height;
    private double depth;
    
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

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    public double Depth
    {
        get { return depth; }
        set { depth = value; }
    }
}