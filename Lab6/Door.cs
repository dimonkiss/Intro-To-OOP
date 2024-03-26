namespace Lab6;

public class Door
{
    // Унікальний ідентифікатор дверей
    private int id;
    
    // Матеріал, з якого виготовлені двері
    private string material;
    
    // Розміри дверей (ширина, висота) в метрах (м)
    private double width;
    private double height;
    
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
}