using System;

namespace Lab5
{
    public class TextBook : Book
    {
        private string Author;
        private int QuantityOfPages;
        private double Rating;

        public TextBook() : base()
        {
            Author = "";
            QuantityOfPages = 0;
            Rating = 0.0;
        }

        public TextBook(string name, double price, string author, int quantityOfPages, double rating) : base(name, price)
        {
            Author = author;
            QuantityOfPages = quantityOfPages;
            Rating = rating;
        }

        public TextBook(TextBook other) : base(other)
        {
            Author = other.Author;
            QuantityOfPages = other.QuantityOfPages;
            Rating = other.Rating;
        }

        public string AuthorProp
        {
            get { return Author; }
            set { Author = value; }
        }

        public int QuantityOfPagesProp
        {
            get { return QuantityOfPages; }
            set { QuantityOfPages = value; }
        }

        public double RatingProp
        {
            get { return Rating; }
            set { Rating = value; }
        }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Quantity of Pages: " + QuantityOfPages);
            Console.WriteLine("Rating: " + Rating);
        }

        public override double CalculateBookPopularityRating(double weeklySales, double monthlySales)
        {
            return base.CalculateBookPopularityRating(weeklySales, monthlySales) + Rating;
        }

        public double CalculateStudentRating()
        {
            // Випадкові значення для критеріїв
            Random rand = new Random();
            double relevance = rand.NextDouble() * 5; // Актуальність
            double modernity = rand.NextDouble() * 5; // Сучасність
            double internetReviews = rand.NextDouble() * 5; // Відгуки в Інтернеті
            double materialAvailability = rand.NextDouble() * 5; // Доступність матеріалу

            // Розрахунок рейтингу на основі випадкових значень
            double studentRating = (relevance + modernity + internetReviews + materialAvailability) / 4;

            return studentRating;
        }

        public override string MaterialAvailability()
        {
            // Припустимо, що доступність матеріалу кодується цифровим значенням
            int accessibilityCode = 3; // Припустимо, що 3 означає "проста"
            return "Material Accessibility: " + accessibilityCode;
        }

        public override string TextbookStatus()
        {
            return "Textbook Status: Approved";
        }
        
        public static bool operator ==(TextBook TextBook1, TextBook TextBook2)
        {
            return TextBook1.CalculateStudentRating() == TextBook2.CalculateStudentRating();
        }

        public static bool operator !=(TextBook TextBook1, TextBook TextBook2)
        {
            return TextBook1.CalculateStudentRating() != TextBook2.CalculateStudentRating();
        }

        public static bool operator >(TextBook TextBook1, TextBook TextBook2)
        {
            return TextBook1.CalculateStudentRating() > TextBook2.CalculateStudentRating();
        }

        public static bool operator <(TextBook TextBook1, TextBook TextBook2)
        {
            return TextBook1.CalculateStudentRating() < TextBook2.CalculateStudentRating();
        }
        
        public static TextBook operator ++(TextBook TextBook)
        {
            // Збільшення рейтингу, наприклад, залежно від кількості скачувань
            TextBook.Rating += 1;
            return TextBook;
        }

        public static TextBook operator --(TextBook TextBook)
        {
            // Зменшення рейтингу, наприклад, внаслідок від’ємних відгуків
            TextBook.Rating -= 1;
            return TextBook;
        }

        public static TextBook operator -(TextBook TextBook)
        {
            // Від’ємний рейтинг (зміна знаку)
            TextBook.Rating = -TextBook.Rating;
            return TextBook;
        }
    }
}
