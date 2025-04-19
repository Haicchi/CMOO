namespace LAB_7_1;

public class ModulCreate
{
    static private Random random = new Random();
    private static string[] modulname = {"dev","mod","save","lvl"};
    private static double[] modulcaps = {7.3,7.1,9.2,1.5,5.4,6.7};
    public static string GetRandomModulName()
    {
        return modulname[random.Next(4)];
    }
    public static double GetRandomModulCap()
    {
        return modulcaps[random.Next(6)];
    }
    public static Modul GetRandomModule()
    {
        return new Modul(PersonCreate.GetRandomPerson(),GetRandomModulName(),GetRandomModulCap());
    }
}