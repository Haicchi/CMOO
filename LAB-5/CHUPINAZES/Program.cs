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
                Factory.GetKerivniki(projects);

                Factory.GetLargest(projects);
                Factory.EndthisMonth(projects);
           
        
    
    enum ProjectType
    {
        Commercial,
        Training,
        PersonalUse
    }
