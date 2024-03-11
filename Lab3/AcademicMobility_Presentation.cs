using System;

namespace Lab3
{
    public partial class AcademicMobility
    {
        public void PresentInternationalPrograms(InterProgram program)
        {
            Console.WriteLine($"Program: {program.ProgramName}, Students: {program.NumberOfStudents}");
        }
    }
}