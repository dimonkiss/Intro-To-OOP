namespace Lab6;

public class Evaporator
{
    // Унікальний ідентифікатор випарника
    private int id;
    
    // Об'єм випарника в кубічних метрах (м³)
    private double volume;
    
    // Матеріал, з якого виготовлений випарник
    private string material;
    
    // Тип випарника (наприклад, змійовиковий, пластинчатий, тощо)
    private string type;

// Властивість для доступу до поля id
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    // Властивість для доступу до поля volume
    public double Volume
    {
        get { return volume; }
        set { volume = value; }
    }

    // Властивість для доступу до поля material
    public string Material
    {
        get { return material; }
        set { material = value; }
    }

    // Властивість для доступу до поля type
    public string Type
    {
        get { return type; }
        set { type = value; }
    }

}