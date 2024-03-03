namespace Lab3
{

    public class AcademicMobility
    {
        private string[] international_programs;
        private string[] university_partners;
        private string[] contacts;

        public AcademicMobility()
        {
            international_programs = new string[0];
            university_partners = new string[0];
            contacts = new string[0];
        }

        public AcademicMobility(string[] internationalPrograms, string[] universityPartners, string[] contacts)
        {
            this.international_programs = internationalPrograms;
            this.university_partners = universityPartners;
            this.contacts = contacts;
        }

        public string[] InternationalPrograms
        {
            get { return international_programs; }
            set { international_programs = value; }
        }

        public string[] UniversityPartners
        {
            get { return university_partners; }
            set { university_partners = value; }
        }

        public string[] Contacts
        {
            get { return contacts; }
            set { contacts = value; }
        }
        
         public void InputFromConsole()
        {
            Console.WriteLine("Enter Academic Mobility details:");
            Console.Write("Number of International Programs: ");
            int intProgramCount = int.Parse(Console.ReadLine());
            international_programs = new string[intProgramCount];
            for (int i = 0; i < intProgramCount; i++)
            {
                Console.Write($"Enter International Program {i + 1}: ");
                international_programs[i] = Console.ReadLine();
            }

            Console.Write("Number of University Partners: ");
            int uniPartnersCount = int.Parse(Console.ReadLine());
            university_partners = new string[uniPartnersCount];
            for (int i = 0; i < uniPartnersCount; i++)
            {
                Console.Write($"Enter University Partner {i + 1}: ");
                university_partners[i] = Console.ReadLine();
            }

            Console.Write("Number of Contacts: ");
            int contactsCount = int.Parse(Console.ReadLine());
            contacts = new string[contactsCount];
            for (int i = 0; i < contactsCount; i++)
            {
                Console.Write($"Enter Contact {i + 1}: ");
                contacts[i] = Console.ReadLine();
            }
        }

        public void OutputToConsole()
        {
            Console.WriteLine($"Academic Mobility Details:");
            Console.WriteLine("International Programs:");
            foreach (var program in international_programs)
            {
                Console.WriteLine(program);
            }
            Console.WriteLine("University Partners:");
            foreach (var partner in university_partners)
            {
                Console.WriteLine(partner);
            }
            Console.WriteLine("Contacts:");
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }

        public void WriteToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("International Programs:");
                foreach (var program in international_programs)
                {
                    writer.WriteLine(program);
                }
                writer.WriteLine("University Partners:");
                foreach (var partner in university_partners)
                {
                    writer.WriteLine(partner);
                }
                writer.WriteLine("Contacts:");
                foreach (var contact in contacts)
                {
                    writer.WriteLine(contact);
                }
            }
        }
        public void RegisterStudent(Student student){
            OutputToConsole();
            Console.WriteLine("On which inrantional program student want to register: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            student.WriteToFile($"{this.international_programs[choice]}.txt");

            Console.WriteLine($"Студент {student.Surname} {student.Name} зареєстрований на програму міжнародної мобільності {international_programs[choice]}.");
        }

        static int BinarySearch(string[] arr, string target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                int compareResult = string.Compare(arr[mid], target);

                if (compareResult == 0)
                    return mid;

                if (compareResult < 0)
                    left = mid + 1;

                else
                    right = mid - 1;
            }

            return -1;
        }
        public void SearchforUniversity()
        {
            Console.WriteLine("Which international program you want to search: ");
            string choice = Console.ReadLine();
            int index = BinarySearch(international_programs, choice);
            Console.WriteLine($"Best university for you would be {university_partners[index]}");
        }
    }
}