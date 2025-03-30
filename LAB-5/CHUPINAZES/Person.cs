using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHUPINAZES
{
    internal class Person
    {
        string FirstName;
        string LastName;

        public Person(string firstname,string lastname) 
        {
            FirstName = firstname;
            LastName = lastname;
        }
        public string Firstname { get { return FirstName; } set { FirstName = value; } }
        public string Lastname { get { return LastName; } set { LastName = value; } }
    }
}
