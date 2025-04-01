using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHUPINAZES
{
    internal class Person
    {
        string firstName;
        string lastName;
        DateTime birth;

        public Person(string firstname, string lastname, DateTime birth)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.birth = birth;
        }
        public Person()
        {
            firstName = "";
            lastName = "";
            birth = DateTime.Now;
        }
        public string Firstname { get { return firstName; } set { firstName = value; } }
        public string Lastname { get { return lastName; } set { lastName = value; } }
        public DateTime Birth { get { return birth; } set { birth = value; } }
        public override string ToString()
        {
            return $"Firstname: {firstName}|Lastname: {lastName}| birth date: {birth}";
        }
        public string ToShortString()
        {
            return $"Firstname: {firstName}|Lastname: {lastName}";
        }
        
    }
}
