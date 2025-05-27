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
        private Courcess[] courses;

        public Student()
        {
            name = " ";
            surname = " ";
            age = 0;
            yearoflearning = 0;
            specialization = " ";
            courses = new Courcess[0];
        }
        public Student(string name, string surname, int age, int yearoflearning, string specialization, Courcess[] courses)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.yearoflearning = yearoflearning;
            this.specialization = specialization;
            this.courses = courses;
        }

        public Courcess[] Courses
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
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value");
                }
                specialization = value;
            }
        }
        public override string ToString()
        {
            string[] coucenames = new string[courses.Length];
            for (int i = 0; i < courses.Length; i++)
            {
                coucenames[i] = courses[i].CourseName;
            }
            return $"Name = {name} / Surname = {surname} / Age = {age} / Year of Learning = {yearoflearning} / Specialization = {specialization} / Courses - {string.Join(',',coucenames)}";
        }
    }
}
