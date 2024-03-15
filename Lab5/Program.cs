using System;

namespace Lab5
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
            
            
            //task 9
            BookWithInterfaces[] books = new BookWithInterfaces[]
            {
                new BookWithInterfaces { Name = "Book1", Price = 10.99, Pages = 100 },
                new BookWithInterfaces { Name = "Book2", Price = 15.99, Pages = 200 },
                new BookWithInterfaces { Name = "Book3", Price = 5.99, Pages = 150 }
            };


            Console.WriteLine("Books sorted by price and then by number of pages:");
            foreach (var i in books.OrderBy(b => b.Price).ThenBy(b => b.Pages))
            {
                Console.WriteLine($"{i.Name} - Price: {i.Price}, Pages: {i.Pages}");
            }
        }
    }
}