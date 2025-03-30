using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CHUPINAZES
{

    internal class Project
    {
        private string projectName;
        private ProjectType projectType;
        private DateTime endDate;
        private double valueofProject;
        private Modul[] modul;

        public Project(string ProjectName, ProjectType ProjectType, DateTime EndDate, double ValueofProject, Modul[] Modul)
        {
            projectName = ProjectName;
            projectType = ProjectType;
            endDate = EndDate;
            valueofProject = ValueofProject;
            modul = Modul;
        }

        public Project()
        {
            projectName = null;
            projectType = ProjectType.Commercial;
            endDate = DateTime.Now;
            valueofProject = 0;
            modul = new Modul[0]; // Инициализация пустого массива
        }

        public override string ToString()
        {
            return "ProjectName: " + projectName + " ProjectType: " + projectType + " EndDate: " + endDate + " ValueofProject: " + valueofProject + " Modul: " + (modul != null ? modul.Length : 0);
        }

        public string ToShortString()
        {
            return "ProjectName: " + projectName + " ProjectType: " + projectType + " Avg: " + AverageModuleSize;
        }

        public double ValueofProject
        {
            get { return valueofProject; }
            set
            {
                if (!double.TryParse(value.ToString(), out double parsed))
                {
                    throw new ArgumentException("Value must be a number");
                }
                valueofProject = parsed;
            }
        }

        public string ProjectName
        {
            get { return projectName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Project name must not be empty");
                }
                projectName = value;
            }
        }

        public ProjectType ProjectType
        {
            get { return projectType; }
            set
            {
                if (!Enum.TryParse(value.ToString(), out ProjectType smth))
                {
                    throw new ArgumentException("Project type must be a valid type");
                }
                projectType = smth;
            }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set
            {
                if (!DateTime.TryParse(value.ToString(), out DateTime parsed))
                {
                    throw new ArgumentException("End date must be a valid date");
                }
                endDate = parsed;
            }
        }

        public Modul[] Modul
        {
            get { return modul; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Modul must not be empty");
                }
                modul = value;
            }
        }

        public void AddModules(params Modul[] modules)
        {
            if (modules == null) { throw new ArgumentNullException(); }
            modul = modul.Concat(modules).ToArray();
        }

        public bool this[ProjectType Type]
        {
            get { return projectType == Type; }
        }

        public double AverageModuleSize
        {
            get
            {
                if (modul.Length == 0) { return 0; }
                double sum = 0;
                foreach (var m in modul)
                {
                    sum += m.modulCap;
                }
                return sum / modul.Length;
            }
        }
    }
}