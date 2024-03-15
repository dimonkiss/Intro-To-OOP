using System;

namespace Lab5
{
    public class Compendium : Book
    {
        private string StudentName;
        private string Language;
        private bool FreeAccess;

        public Compendium() : base()
        {
            StudentName = "";
            Language = "";
            FreeAccess = false;
        }

        public Compendium(string name, double price, string studentName, string language, bool freeAccess) : base(name, price)
        {
            StudentName = studentName;
            Language = language;
            FreeAccess = freeAccess;
        }

        public Compendium(Compendium other) : base(other)
        {
            StudentName = other.StudentName;
            Language = other.Language;
            FreeAccess = other.FreeAccess;
        }

        public string StudentNameProp
        {
            get { return StudentName; }
            set { StudentName = value; }
        }

        public string LanguageProp
        {
            get { return Language; }
            set { Language = value; }
        }

        public bool FreeAccessProp
        {
            get { return FreeAccess; }
            set { FreeAccess = value; }
        }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Student Name: " + StudentName);
            Console.WriteLine("Language: " + Language);
            Console.WriteLine("Free Access: " + FreeAccess);
        }

        public double CalculateDifficulty(int numberOfStudents)
        {
            // складність зростає зі збільшенням кількості студентів
            return numberOfStudents * 0.1;
        }

        public double CalculateNoteTakingEfficiency(int informationQuantity, int understandingLevel)
        {
            // Складність зростає  зі збільшенням кількості та складності інформації, яку потрібно запам'ятати
            return informationQuantity * 0.05 + understandingLevel * 0.1;
        }

        public override string MaterialAvailability()
        {
            // Припустимо, що доступність матеріалу кодується цифровим значенням
            int accessibilityCode = 2; // Припустимо, що 2 означає "важка для розуміння"
            return "Material Accessibility: " + accessibilityCode;
        }

        public override string TextbookStatus()
        {
            return "Textbook Status: Recommended";
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

        public static bool operator ==(Compendium compendium1, Compendium compendium2)
        {
            return compendium1.CalculateStudentRating() == compendium2.CalculateStudentRating();
        }

        public static bool operator !=(Compendium compendium1, Compendium compendium2)
        {
            return compendium1.CalculateStudentRating() != compendium2.CalculateStudentRating();
        }

        public static bool operator >(Compendium compendium1, Compendium compendium2)
        {
            return compendium1.CalculateStudentRating() > compendium2.CalculateStudentRating();
        }

        public static bool operator <(Compendium compendium1, Compendium compendium2)
        {
            return compendium1.CalculateStudentRating() < compendium2.CalculateStudentRating();
        }
    }
}
