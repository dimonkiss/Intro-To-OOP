namespace Lab6;

public class EmbeddedMicroprocessor
{
    // Ідентифікатор мікропроцесора
    private int id;
    
    // Модель мікропроцесора
    private string model;
    
    // Тип мікропроцесора (наприклад, ARM, Intel, і т.д.)
    private string type;
    
    // Частота роботи мікропроцесора
    private double frequency;
    
    // Кількість ядер мікропроцесора
    private int cores;
    
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public double Frequency
    {
        get { return frequency; }
        set { frequency = value; }
    }

    public int Cores
    {
        get { return cores; }
        set { cores = value; }
    }
}