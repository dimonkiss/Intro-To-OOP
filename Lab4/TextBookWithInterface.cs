﻿namespace Lab4;

public class TextBookWithInterface : BookWithInterface
{
    public string Author { get; set; }
    public int QuantityOfPages { get; set; }
    public double Rating { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"TextBook: {Name}, Author: {Author}, Price: {Price}, Pages: {QuantityOfPages}, Rating: {Rating}");
    }
}