using System.Collections;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Reflection;

namespace LAB_7_1;

internal class Project : IFileContainer, IEnumerable, IEnumerator
{
    private string projectName;
    private ProjectType projectType;
    private DateTime endDate;
    private double valueofProject;
    private Modul[] modul;

    public int Count
    {
        get { return modul.Length; }
    }

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
        return "ProjectName: " + projectName + " ProjectType: " + projectType + " EndDate: " + endDate +
               " ValueofProject: " + valueofProject + " Modul: " + (modul != null ? modul.Length : 0);
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
            if (!double.TryParse(value.ToString(), out double parsed) && value < 0)
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
        if (modules == null)
        {
            throw new ArgumentNullException();
        }

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
            if (modul.Length == 0)
            {
                return 0;
            }

            double sum = 0;
            foreach (var m in modul)
            {
                sum += m.modulCap;
            }

            return sum / modul.Length;
        }
    }



    public void Add(object element)
    {
        Array.Resize(ref modul, modul.Length + 1);
        modul[modul.Length - 1] = element as Modul;
        IsDataSaved = false;
    }

    public void Delete(object element)
    {
        Modul[] temp = new Modul[modul.Length - 1];
        int index = Array.IndexOf(modul, element);
        if (index == null)
        {
            Console.WriteLine("Cannot delete null element");

        }

        for (int i = 0, j = 0; i < modul.Length; i++)
        {
            if (i != index)
            {
                temp[j] = modul[i];
                j++;
            }
        }

        modul = temp;
        IsDataSaved = false;
    }



    public Object this[int index]
    {
        set
        {
            if (index < 0 || index >= modul.Length)
            {
                throw new IndexOutOfRangeException();
            }

            modul[index] = (Modul)value;
        }
        get { return modul[index]; }
    }

    public void Save(string fileName)
    {
        if (!File.Exists(fileName))
        {
            throw new FileNotFoundException("Nema");
        }
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            for (int i = 0; i < modul.Length; i++)
            {
                Modul m = (Modul)(object)modul[i];
                string line = $"{m.ProjectKer.Firstname} {m.ProjectKer.Lastname};{m.modulName};{m.modulCap}";
                writer.WriteLine(line);
            }
        }

        IsDataSaved = true;
    }

    public void Load(string fileName)
    {
        if (!File.Exists(fileName))
            throw new FileNotFoundException("Nema");

        string[] lines = File.ReadAllLines(fileName);
        Modul[] temp = new Modul[lines.Length];

        for (int i = 0; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(';');
            string[] nameParts = parts[0].Trim().Split(' ');
            string first = nameParts[0];
            string last = nameParts.Length > 1 ? nameParts[1] : "";

            Person person = new Person { Firstname = first, Lastname = last };

            string name = parts[1].Trim();
            double cap = double.Parse(parts[2]);

            Modul m = new Modul(person, name, cap);
            temp[i] = (Modul)m;
        }

        modul = temp;
        IsDataSaved = true;
    }


    public bool IsDataSaved { get; private set; }

    

    IEnumerator IEnumerable.GetEnumerator()
    {
        return (IEnumerator<Modul>)GetEnumerator();
    }

    public void Sort(Modul[] comparer)
    {
        Array.Sort(comparer);
    }
   private int position = 0;
   private int count = 0;
   public IEnumerator GetEnumerator()
   {
       return this;
   }
   
   public bool MoveNext()
   {
       position++;
       return position < count;
   }
        
   public void Reset()
   {
       position = 0;
   }
        
   public object Current
   {
       get
       {
           if (position < 0 || position >= count)
           {
               throw new InvalidOperationException();
           }
           return modul[position];
       }
   }




}
