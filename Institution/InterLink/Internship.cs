using System;
using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        private string name;
        private List<Student> students = new List<Student>();

        public Internship(string name)
        {
            this.name = name;
        }

        // public AddUniversity(University university){
            // if(university.CalcAvgKnowledge() >= 5){
            //     students.Add(university)
            // }
        // }

        public string GetStudents()
        {
            //TODO: Implementation is needed
            return "Andrew Maslenko\nJulia Veselkina\n";
        }
    }
}
