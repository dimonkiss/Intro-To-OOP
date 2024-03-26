namespace Lab6;

public class AutomationDevices
{
    // Унікальний ідентифікатор пристроїв автоматики
    private int id;
    
    // Опис пристроїв автоматики
    private string description;
    
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }
}