using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Internship internship = new Internship("Interlink");
            
            University university = new University("CH.U.I.");
            university.AddStudent(new Student("Andrew Kostenko", 5));
            university.AddStudent(new Student("Julia Veselkina", 10));
            university.AddStudent(new Student("Maria Perechrest", 7));

            
            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents(university));
        }
    }
}
