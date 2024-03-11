using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface
            IBook book = new BookWithInterface
            {
                Name = "The Great Gatsby",
                Price = 15.99
            };
            
            
            IBook textbook = new TextBookWithInterface()
            {
                Name = "Introduction to Algorithms",
                Price = 49.99,
                Author = "Thomas H. Cormen",
                QuantityOfPages = 1312,
                Rating = 4.5
            };
            
            IBook summary = new CompendiumWithInterface()
            {
                Name = "English Grammar",
                Price = 29.99,
                StudentName = "John Doe",
                Language = "English",
                FreeAccess = true
            };
            
            book.DisplayInfo();
            textbook.DisplayInfo();
            summary.DisplayInfo();
            
            //abstract
            TextBookWithAbstract textbook1 = new TextBookWithAbstract()
            {
                Name = "Introduction to Algorithms",
                Price = 49.99,
                Author = "Thomas H. Cormen",
                QuantityOfPages = 1312,
                Rating = 4.5
            };

            CompendiumWithAbstract summary1 = new CompendiumWithAbstract()
            {
                Name = "English Grammar",
                Price = 29.99,
                StudentName = "John Doe",
                Language = "English",
                FreeAccess = true
            };

            // Виклик методів через посилання на базовий абстрактний клас
            textbook1.DisplayInfo();
            summary1.DisplayInfo();
        }
    }
}