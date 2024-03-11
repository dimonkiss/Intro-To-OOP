using System.Net;

namespace Lab3;

public class Compendium : Book
{
    private string StudentName;
    private string Language;
    private bool FreeAccess;
    
    
    public Compendium(string name, double price, string studentName, string language, bool freeAccess) : base(name, price)
    {
        StudentName = studentName;
        Language = language;
        FreeAccess = freeAccess;
    }
    
    public string StudentNameProp
    {
        get { return StudentName; }
        set { StudentName = value; }
    }

    public string LanguageProp
    {
        get { return Language; }
        set { Language = value; }
    }

    public bool FreeAccessProp
    {
        get { return FreeAccess; }
        set { FreeAccess = value; }
    }
    
    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Student Name: " + StudentName);
        Console.WriteLine("Language: " + Language);
        Console.WriteLine("Free Access: " + FreeAccess);
    }
}