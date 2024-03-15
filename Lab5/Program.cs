using System;
using System.Net.Mime;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBook[] array = new TextBook[3];

            // Ініціалізація об'єктів за допомогою індексатора
            array[0] = new TextBook("Book1", 20.0, "Author1", 200, 4.5);
            array[1] = new TextBook("Book2", 25.0, "Author2", 250, 4.8);
            array[2] = new TextBook("Book3", 30.0, "Author3", 300, 4.9);

            // Виведення значень полів об'єктів на консоль
            foreach (var book in array)
            {
                book.DisplayInfo();
            }
        }
    }
}