namespace Lab5;

public class CompendiumWithAbstract : AbstractBook
{
    public string StudentName { get; set; }
    public string Language { get; set; }
    public bool FreeAccess { get; set; }

    public override void DisplayInfo()
    {
            Console.WriteLine($"Summary: {Name}, Student: {StudentName}, Price: {Price}, Language: {Language}, Free Access: {FreeAccess}");
    }
}