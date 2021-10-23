using System;
namespace InternshipTest.Person
{
    public class Student
    {
        private string name;
        private Knowledge knowledge;
        public Student(string name, int knowledgeLevel)
        {
            this.name = name;
            this.knowledge = new Knowledge(knowledgeLevel);
        }

        public void SetKnowledge(Knowledge knowledge)
        {
            this.knowledge = knowledge;
        }

        public string GetName() { return name;}
        public Knowledge GetKnowledge()
        {
            return knowledge;
        }
    }
}