using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studenti
{
    internal class Factory
    {
        private static Student[] students;
        static Factory()
        {
            students = new Student[0];
        }
        public static void Show()
        {
            if (students == null)
            {
                Console.WriteLine("Your array is null");
                return;
            }
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].ToString());
            }
        }

        public static bool CanHopOn(Student student)
        {
            int courseneeded = 3;
            if (students.Length == 0)
            {
                return true;
            }

            for (int i = 0; i < students.Length; i++)
            {
                int count = 0;
                if (student.Specialization == students[i].Specialization)
                {
                    return false;
                }
                for (int j = 0; j < student.Courses.Length; j++)
                {
                    for (int k = 0; k < students[i].Courses.Length; k++)
                    {
                        if (student.Courses[j] == students[i].Courses[k])
                        {
                            count++;
                            break;
                        }
                    }
                }

                if (count < courseneeded)
                {
                    return false;
                }
            }
            return true;
            
        }
        public static void GroupCreation(Student[] studentos)
        {
            
            if (studentos == null)
            {
                Console.WriteLine("There is no any student");
                return;
            }
            students = new Student[0];
            for (int i = 0; i < studentos.Length; i++)
            {
                if (CanHopOn(studentos[i]))
                {
                    Student[] newstudents = new Student[students.Length + 1];
                    for (int j = 0; j < students.Length; j++)
                    {
                        newstudents[j] = students[j];
                    }
                    newstudents[students.Length] = studentos[i];
                    students = newstudents;
                }
                else
                {
                    Console.WriteLine($"Cant add to group student number {i + 1}");
                    for (int j = 0; j < students.Length; j++)
                    {
                        if (studentos[i].Specialization == students[j].Specialization)
                        {
                            Console.WriteLine("Because of same spec");
                        }
                        else
                        {
                            Console.WriteLine("Because of too many different courses");
                        }
                    }
                }
            }
            
        }
    }
}


