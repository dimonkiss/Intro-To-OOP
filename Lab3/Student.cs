namespace Lab3
{
    public class Student
    {
        private string surname;
        private string name;
        private int course;
        private string speciality;
        private string university;
        private double rating;
        private string[] science_achievements;

        public Student()
        {
            surname = "";
            name = "";
            course = 0;
            speciality = "";
            university = "";
            rating = 0.0;
            science_achievements = new string[0];
        }

        public Student(string surname, string name, int course, string speciality, string university, double rating, string[] scienceAchievements)
        {
            this.surname = surname;
            this.name = name;
            this.course = course;
            this.speciality = speciality;
            this.university = university;
            this.science_achievements = scienceAchievements;
            this.rating = rating;
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Course
        {
            get { return course; }
            set { course = value; }
        }

        public string Speciality
        {
            get { return speciality; }
            set { speciality = value; }
        }

        public string University
        {
            get { return university; }
            set { university = value; }
        }

        public double Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public string[] ScienceAchievements
        {
            get { return science_achievements; }
            set { science_achievements = value; }
        }
        public void InputFromConsole()
        {
            Console.WriteLine("Enter Student details:");
            Console.Write("Surname: ");
            surname = Console.ReadLine();

            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Course: ");
            course = int.Parse(Console.ReadLine());

            Console.Write("Speciality: ");
            speciality = Console.ReadLine();

            Console.Write("University: ");
            university = Console.ReadLine();



            Console.Write("Number of science achievements: ");
            int count = int.Parse(Console.ReadLine());
            science_achievements = new string[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter achievement {i + 1}: ");
                science_achievements[i] = Console.ReadLine();
            }
            

            rating = CalculationRating();
        }

        public void OutputToConsole()
        {
            Console.WriteLine($"Student Details:");
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Course: {course}");
            Console.WriteLine($"Speciality: {speciality}");
            Console.WriteLine($"University: {university}");
            Console.WriteLine($"Rating: {rating}");
            Console.WriteLine("Science Achievements:");
            foreach (var achievement in science_achievements)
            {
                Console.WriteLine(achievement);
            }
        }

        public void WriteToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"Surname: {surname}");
                writer.WriteLine($"Name: {name}");
                writer.WriteLine($"Course: {course}");
                writer.WriteLine($"Speciality: {speciality}");
                writer.WriteLine($"University: {university}");
                writer.WriteLine($"Rating: {rating}");
                writer.WriteLine("Science Achievements:");
                foreach (var achievement in science_achievements)
                {
                    writer.WriteLine(achievement);
                }
            }

            Console.WriteLine($"Student was added to a file {filePath}");
        }

        public double CalculationRating()
        {
            double rating = 0;
            Random random = new Random();
            double sum = 0;
            for (int i = 0; i < 10; ++i)
            {
                sum += random.Next(40, 101);
            }

            rating += sum / 10;

            for (int i = 0; i < science_achievements.Length; ++i)
            {
                if (science_achievements[i].Contains("Article"))
                {
                    rating += 5;
                }
                if (science_achievements[i].Contains("Conference"))
                {
                    rating += 4;
                }
                if (science_achievements[i].Contains("Participation"))
                {
                    rating += 4;
                }
            }

            bool english = Convert.ToBoolean(random.Next(0, 2));
            if (english)
            {
                rating += 2;
            }

            return rating;
        }

        public void IQCalculation()
        {
            Random random = new Random();
            int IQ = random.Next(80, 161);
            
            WriteToFile("students_iq.txt");
            using (StreamWriter writer = new StreamWriter("students_iq.txt"))
            {
                writer.WriteLine($"IQ of this student is: {IQ}");
            }
        }
    }
}