using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Student student = new Student();
            // student.InputFromConsole();
            // student.OutputToConsole();
            // student.WriteToFile("student_details.txt");

            
            // AcademicMobility mobility = new AcademicMobility();
            // mobility.InputFromConsole();
            // mobility.OutputToConsole();
            // mobility.WriteToFile("academic_mobility_details.txt");

            Student student = new Student();
            student.IQCalculation();
            
            Console.WriteLine("Оберіть опцію:");
            Console.WriteLine("1. Робота з масивом");
            Console.WriteLine("2. Робота з матрицею");
            Console.WriteLine("3. Робота з рядком");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ResearchWork.IndexesInArray();
                    break;
                case 2:
                    ResearchWork.ActionsWithMatrix();
                    break;
                case 3:
                    ResearchWork.ActionsWithString();
                    break;
                default:
                    Console.WriteLine("Невірний вибір опції.");
                    break;
            }
        }
    }
}