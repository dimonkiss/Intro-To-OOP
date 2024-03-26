namespace Lab6;

// Виняток, що відображає збій в роботі холодильника
public class RefrigeratorMalfunctionException : Exception
{
    public RefrigeratorMalfunctionException(string message) : base(message) { }
}