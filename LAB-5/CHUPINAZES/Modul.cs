using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHUPINAZES
{

    internal class Modul
    {
        
        public Person ProjectKer { get; set; }
        public string modulName { get; set; }
        public double modulCap { get; set; }

        public Modul(Person PersonKer, string ModulName, double ModulCap)
        {
            ProjectKer = PersonKer;
            modulName = ModulName;
            modulCap = ModulCap;
        }

        public Modul()
        {
            ProjectKer = null;
            modulName = null;
            modulCap = 0.0;
        }

        

        override public string ToString()
        {
            return "Person: " + ProjectKer.Firstname + " " + ProjectKer.Lastname + " ModulName: " + modulName + " ModulCap: " + modulCap;
        }
    }
}
