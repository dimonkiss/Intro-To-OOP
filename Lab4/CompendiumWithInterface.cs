namespace Lab4;

public class CompendiumWithInterface : BookWithInterface
{
    public string StudentName { get; set; }
    public string Language { get; set; }
    public bool FreeAccess { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Compendium: {Name}, Student: {StudentName}, Price: {Price}, Language: {Language}, Free Access: {FreeAccess}");
    }
}