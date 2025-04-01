using System.Security.AccessControl;

namespace CHUPINAZES;

static class ProjectCreate
{
 static private string[] projectnames = { "GOTy", "DOTA2", "CHELVO", "DODOKO", "HSR", "Lobotomy Corporation", "Lor" };
 static private Random random = new Random();
 static private ProjectType[] projectypes = {ProjectType.Commercial, ProjectType.Training, ProjectType.PersonalUse};
 static private DateTime[] endofdate = {DateTime.Now, DateTime.Now.AddMonths(1),DateTime.Now.AddMonths(2),DateTime.Now.AddMonths(3)};
 static private double[] valuesofprojects = {500,200,300,700,900,1000,1500,2000,1700};

 public static string GetRandomProjectName()
 {
  return projectnames[random.Next(7)];
 }
 public static ProjectType GetProjectType()
 {
  return projectypes[random.Next(3)];
 }

 public static DateTime GetRandomDate()
 {
  return endofdate[random.Next(4)];
 }

 public static double GetRandomValueOfProject()
 {
  return valuesofprojects[random.Next(9)];
 }

 public static Project GetRandomProject()
 {
  return new Project(GetRandomProjectName(),GetProjectType(),GetRandomDate(),GetRandomValueOfProject(),new Modul[]{ModuleCreate.GetRandomModule(),ModuleCreate.GetRandomModule(),ModuleCreate.GetRandomModule()});
 }
 
}