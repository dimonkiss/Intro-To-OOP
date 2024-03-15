namespace Lab5;

public class eBook : Book
{
        private string Format; // Формат електронної книги
        private int SizeInMB; // Розмір в мегабайтах
        private double studentRating;
        public eBook() : base()
        {
            Format = "";
            SizeInMB = 0;
            studentRating = 0.0;
        }

        public eBook(string name, double price, string format, int sizeInMB) : base(name, price)
        {
            Format = format;
            SizeInMB = sizeInMB;
            studentRating = 0.0;
        }

        public eBook(eBook other) : base(other)
        {
            Format = other.Format;
            SizeInMB = other.SizeInMB;
            studentRating = other.studentRating;
        }

        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Формат: {Format}, Розмір: {SizeInMB} MB");
        }
        public override string MaterialAvailability()
        {
            // Припустимо, що доступність матеріалу кодується цифровим значенням
            int accessibilityCode = 1; // Припустимо, що 1 означає "легка для розуміння"
            return "Material Accessibility: " + accessibilityCode;
        }
        
        public override string TextbookStatus()
        {
            // Припустимо, що статус електронної книги зберігається в окремому полі
            string eBookStatus = "Published"; // Припустимо, що електронна книга опублікована
            return "eBook Status: " + eBookStatus;
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
        
        public static bool operator ==(eBook eBook1, eBook eBook2)
        {
            return eBook1.CalculateStudentRating() == eBook2.CalculateStudentRating();
        }

        public static bool operator !=(eBook eBook1, eBook eBook2)
        {
            return eBook1.CalculateStudentRating() != eBook2.CalculateStudentRating();
        }

        public static bool operator >(eBook eBook1, eBook eBook2)
        {
            return eBook1.CalculateStudentRating() > eBook2.CalculateStudentRating();
        }

        public static bool operator <(eBook eBook1, eBook eBook2)
        {
            return eBook1.CalculateStudentRating() < eBook2.CalculateStudentRating();
        }
        
        public static eBook operator ++(eBook eBook)
        {
            // Збільшення рейтингу, наприклад, залежно від кількості скачувань
            eBook.studentRating += 1;
            return eBook;
        }

        public static eBook operator --(eBook eBook)
        {
            // Зменшення рейтингу, наприклад, внаслідок від’ємних відгуків
            eBook.studentRating -= 1;
            return eBook;
        }

        public static eBook operator -(eBook eBook)
        {
            // Від’ємний рейтинг (зміна знаку)
            eBook.studentRating = -eBook.studentRating;
            return eBook;
        }
}