namespace CHUPINAZES;

static class Factory
{
    static private Project[] projects;
    

    static public void GetKerivniki(Project[] projects)
    {
        Console.WriteLine("Kerivniki");
        foreach (var item in projects)
        {
            Console.WriteLine(item.ProjectName);
            foreach (var mod in item.Modul)
            {
                Console.WriteLine($"- {mod.ProjectKer.Firstname} {mod.ProjectKer.Lastname} (модуль: {mod.modulName})");
            }

            Console.WriteLine();
        }
    }

    static public void GetLargest(Project[] projects)
    {
      Project largestProject = null;
       int maxModules = 0;
    
        for (int i = 0; i < projects.Length; i++)
        {
            int moduleCount = projects[i].Modul.Length;


            if (moduleCount > maxModules)
            {
                maxModules = moduleCount;
                largestProject = projects[i];

            }
        }
        Console.WriteLine($"Largest: {largestProject.ProjectName} ({maxModules} модулів)");
        
    }

    static public void EndthisMonth(Project[] projects)
    {
        Console.WriteLine("will end in this month");
        bool foundCurrentMonthProjects = false;

        for (int i = 0; i < projects.Length; i++)
        {
            if (projects[i].EndDate.Month == DateTime.Now.Month &&
                projects[i].EndDate.Year == DateTime.Now.Year)
            {
                Console.WriteLine($"- {projects[i].ProjectName} (End date: {projects[i].EndDate.ToShortDateString()})");
                foundCurrentMonthProjects = true;
            }
        }
    }
    
}