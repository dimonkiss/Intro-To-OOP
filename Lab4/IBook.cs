namespace Lab3;

public interface IBook
{
    string Name { get; set; }
    double Price { get; set; }
    void DisplayInfo();
}