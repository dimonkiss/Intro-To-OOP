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
        }
    }
}