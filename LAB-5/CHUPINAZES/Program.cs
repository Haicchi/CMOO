using System;
using System.Reflection;
using CHUPINAZES;

    Person person1 = new Person("Kyrylo", "Klingen");
    Person person2 = new Person("Dima", "Bobuh");
    Modul modul1 = new Modul(person1, "Modul1", 7.3);
    Modul modul2 = new Modul(person2, "Modul2", 4);
    Project project1 = new Project("SIMO", ProjectType.Commercial, DateTime.Now, 1000,new Modul[] {modul1,modul2});
    Console.WriteLine(project1.ToShortString());
Console.WriteLine("Indexator");
Console.WriteLine($"Commercial : {project1[ProjectType.Commercial]}");
Console.WriteLine($"Training : {project1[ProjectType.Training]}");
Console.WriteLine($"PersonalUse : {project1[ProjectType.PersonalUse]}");
project1.ProjectName = "HAYUYA";
project1.ProjectType = ProjectType.Training;
project1.EndDate = DateTime.Now.AddMonths(2);
project1.ValueofProject = 1500;
Console.WriteLine("Full info redo");
Console.WriteLine(project1.ToString());
Modul modul3 = new Modul(person1, "Modul3", 5);
Modul modul4 = new Modul(person2, "Modul4", 6);
project1.AddModules(modul3, modul4);
Console.WriteLine(project1.ToString());
Project project2 = new Project("SIMO2", ProjectType.Commercial, DateTime.Now, 2000, new Modul[] { modul1, modul2 });
Project project3 = new Project("SIMO3", ProjectType.Commercial, DateTime.Now.AddMonths(2), 3000, new Modul[] { modul1, modul2 });
Project[] projects = new Project[] { project1, project2, project3 };
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
Console.WriteLine("will end in this month");
bool foundCurrentMonthProjects = false;

for (int i = 0; i < projects.Length; i++)
{
    if (projects[i].EndDate.Month == DateTime.Now.Month &&
        projects[i].EndDate.Year == DateTime.Now.Year)
    {
        Console.WriteLine($"- {projects[i].ProjectName} (дата завершення: {projects[i].EndDate.ToShortDateString()})");
        foundCurrentMonthProjects = true;
    }
}

enum ProjectType
{
    Commercial,
    Training,
    PersonalUse
}
