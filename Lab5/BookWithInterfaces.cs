namespace Lab5;


using System;
using System.Collections;
using System.Collections.Generic;

public class BookWithInterfaces : IComparable<BookWithInterfaces>, IComparer<BookWithInterfaces>, IEnumerable<BookWithInterfaces>
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Pages { get; set; }

    public IEnumerator<BookWithInterfaces> GetEnumerator()
    {
        yield return this;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int CompareTo(BookWithInterfaces other)
    {
        return Price.CompareTo(other.Price);
    }

    public int Compare(BookWithInterfaces x, BookWithInterfaces y)
    {
        return x.Price.CompareTo(y.Price);
    }
}

