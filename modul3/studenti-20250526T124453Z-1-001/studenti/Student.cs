using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studenti
{
    internal class Student
    {
        private string name;
        private string surname;
        private int age;
        private int yearoflearning;
        private string specialization;
        private string[] courses;

        public Student()
        {
            name = " ";
            surname = " ";
            age = 0;
            yearoflearning = 0;
            specialization = " ";
            courses = new string[0];
        }
        public Student(string name, string surname, int age, int yearoflearning, string specialization, string[] courses)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.yearoflearning = yearoflearning;
            this.specialization = specialization;
            this.courses = courses;
        }

        public string[] Courses
        {
            get { return courses; }
            set {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                courses = value; }
        }
        public string Specialization
        {
            get { return specialization; }
            set { specialization = value; }
        }
        public override string ToString()
        {
            return $"Name = {name} / Surname = {surname} / Age = {age} / Year of Learning = {yearoflearning} / Specialization = {specialization} / Courses - {string.Join(',',courses)}";
        }
    }
}
