    namespace Lab5;

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
    }