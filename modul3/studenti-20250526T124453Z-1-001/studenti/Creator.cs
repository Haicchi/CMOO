using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studenti
{
    internal class Creator
    {
        private static Random random = new Random();
        private static string[] names = { "Jeorge", "Symon", "Chilchak", "Gregor", "Faust" };
        private static string[] surnames = { "Bobux", "Klingne", "Kyliznik" };
        private static int[] ages = { 17, 18, 19, 20 };
        private static int[] yearsoflearning = { 1, 2, 3, 4 };
        private static string[] specialization = { "Computer science", "Computer engineerign", "Web developer" };
        private static string[] courses = { "software development", "data science", "cloud computing", "cybersecurity", "Web design", "3d modeling", "Algrotihms", "DevOps" };

        public static string RandomName()
        {
            return names[random.Next(names.Length)];
        }
        public static string RandomSurnames()
        {
            return surnames[random.Next(surnames.Length)];
        }
        public static int RandomAge()
        {
            return ages[random.Next(ages.Length)];
        }
        public static int RandomYear()
        {
            return yearsoflearning[random.Next(yearsoflearning.Length)];
        }
        public static string RandomSpec()
        {
            return specialization[random.Next(specialization.Length)];
        }
        public static string RandomCourse()
        {
            return courses[random.Next(courses.Length)];
        }

        public static Student RandomStudent()
        {
            return new Student(RandomName(), RandomSurnames(),RandomAge(),RandomYear(),RandomSpec(),new string[] {RandomCourse(), RandomCourse() , RandomCourse() , RandomCourse() , RandomCourse() });
        }
    }
}
