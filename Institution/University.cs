using System;
using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution
{
    public class University
    {
        private string name;
        private List<Student> students = new List<Student>();
        public University(string name)
        {
            this.name = name;
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public int CalcAvgKnowledge(){
            int sum = 0;
            foreach(var student in students){
                sum += student.GetKnowledge().GetLevel();
            }
            sum /= students.Count;
            return sum;
        }
    }
}
