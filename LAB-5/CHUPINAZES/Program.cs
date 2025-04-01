using System;
using System.Reflection;
using CHUPINAZES;

    // Modul modul1 = ModuleCreate.GetRandomModule();
    //         Modul modul2 = ModuleCreate.GetRandomModule();
            Project project1 = ProjectCreate.GetRandomProject();
          
                Console.WriteLine(project1.ToShortString());
                Console.WriteLine("Indexator");
                Console.WriteLine($"Commercial : {project1[ProjectType.Commercial]}");
                Console.WriteLine($"Training : {project1[ProjectType.Training]}");
                Console.WriteLine($"PersonalUse : {project1[ProjectType.PersonalUse]}");
            try
            {
                project1.ProjectName = "";
                project1.ProjectType = ProjectType.Training;
                project1.EndDate = DateTime.Now.AddMonths(2);

                project1.ValueofProject = 1500;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Bad");
            }
                Console.WriteLine("Full info redo");
                Console.WriteLine(project1.ToString());
               
                project1.AddModules(ModuleCreate.GetRandomModule(), ModuleCreate.GetRandomModule());
                Console.WriteLine(project1.ToString());
                Project project2 = ProjectCreate.GetRandomProject();
                Project project3 = ProjectCreate.GetRandomProject();
                    
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
                        Console.WriteLine($"- {projects[i].ProjectName} (End date: {projects[i].EndDate.ToShortDateString()})");
                        foundCurrentMonthProjects = true;
                    }
                }
           
        
    
    enum ProjectType
    {
        Commercial,
        Training,
        PersonalUse
    }
