namespace Lab5;

public class eBook : Book
{
        private string Format; // Формат електронної книги
        private int SizeInMB; // Розмір в мегабайтах

        public eBook() : base()
        {
            Format = "";
            SizeInMB = 0;
        }

        public eBook(string name, double price, string format, int sizeInMB) : base(name, price)
        {
            Format = format;
            SizeInMB = sizeInMB;
        }

        public eBook(eBook other) : base(other)
        {
            Format = other.Format;
            SizeInMB = other.SizeInMB;
        }

        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Формат: {Format}, Розмір: {SizeInMB} MB");
        }
}