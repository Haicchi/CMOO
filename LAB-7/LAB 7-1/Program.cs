namespace LAB_7_1;
enum ProjectType
{
    Commercial,
    Training,
    PersonalUse
}


class Program
{
    static void PrintModules(Project container)
    {
        Console.WriteLine($"Container has {container.Count} modules:");
        int index = 1;
        foreach (Modul module in container)
        {
            Console.WriteLine($"{index++}: {module.ToString()}");
        }
    }

    static void SortModules(Project container)
    {
        for (int i = 0; i < container.Count - 1; i++)
        {
            for (int j = 0; j < container.Count - i - 1; j++)
            {
                Modul current = (Modul)container[j];
                Modul next = (Modul)container[j + 1];

                if (current.CompareTo(next) > 0)
                {
                    container[j] = next;
                    container[j + 1] = current;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        Person q = PersonCreate.GetRandomPerson();
        Person a = PersonCreate.GetRandomPerson();
        Console.WriteLine(q.ToString());
        Console.WriteLine(a.ToString());
        Console.WriteLine(q.CompareTo(a));

        Person b = (Person)q.Clone();
        Console.WriteLine(b.ToString());
        Console.WriteLine(q.ToString());
        Modul mod = ModulCreate.GetRandomModule();
        Modul mod2 = ModulCreate.GetRandomModule();
        Console.WriteLine(mod.ToString());
        Console.WriteLine(mod2.ToString());
        Console.WriteLine(mod.CompareTo(mod2));
        Modul mod3 = (Modul)mod.Clone();
        Console.WriteLine(mod3.ToString());
        
        Project pr1 = ProjectCreate.GetRandomProject();
        Project pr2 = ProjectCreate.GetRandomProject();
        Project pr3 = ProjectCreate.GetRandomProject();
        Project moduleContainer = new Project("Container Project", ProjectType.Training, DateTime.Now.AddMonths(6), 5000, new Modul[0]);
        Console.WriteLine(pr1.ToString());
        Console.WriteLine(pr2.ToString());
        Console.WriteLine(pr3.ToString());
        foreach (Modul module in pr1.Modul)
        {
            moduleContainer.Add(module);
        }
        foreach (Modul module in pr2.Modul)
        {
            moduleContainer.Add(module);
        }
        foreach (Modul module in pr3.Modul)
        {
            moduleContainer.Add(module);
        }

        Console.WriteLine(moduleContainer.ToString());
        PrintModules(moduleContainer);
        SortModules(moduleContainer);
        PrintModules(moduleContainer);
        Modul q2 = ModulCreate.GetRandomModule();
        moduleContainer.Add(q2);
        PrintModules(moduleContainer);
        string filename = "Test.txt";
        moduleContainer.Save(filename);
        Console.WriteLine(moduleContainer.IsDataSaved);
        Project container2 = new Project("Container Project", ProjectType.Training, DateTime.Now.AddMonths(3), 3000, new Modul[0]);
        for (int i = 0; i < 3; i++)
        {
            container2.Add(moduleContainer.Modul[i]);
        }
        PrintModules(container2);

        string seconfilename = "Test2.txt";
        container2.Save(seconfilename);
        Console.WriteLine(container2.IsDataSaved);
        
        Project testload = new Project("Container Project", ProjectType.Training, DateTime.Now.AddMonths(3), 3000, new Modul[0]);
        testload.Load(filename);
        PrintModules(testload);
        
    }
}