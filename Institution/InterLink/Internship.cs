using System;
using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        private string name;

        public Internship(string name)
        {
            this.name = name;
        }

        /* public AddToInterLink(University university)
        {
            foreach (Student student in university.GetAllStudentsInUniversity())
            {
                if (student.GetKnowledge().GetLevel() >= university.CalcAvgKnowledge())
                {
                    this.students.Add(student);
                }

            }
        } */

        public string GetStudents(University university)
        {
            string listOfInterns = "";
            foreach (Student student in university.GetAllStudentsInUniversity())
            {
                if (student.GetKnowledge().GetLevel() >= university.CalcAvgKnowledge())
                {
                    //this.students.Add(student);
                    listOfInterns += $"{student.GetName()}\n";
                }

            }
            return listOfInterns;
        }
    }
}
