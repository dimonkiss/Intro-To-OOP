﻿namespace Lab4;

public interface IBook
{
    string Name { get; set; }
    double Price { get; set; }
    void DisplayInfo();
}