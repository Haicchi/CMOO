using System.Transactions;

namespace LB_6._1;

static class CreatePredator
{
    private static Random random = new Random();
    private static string[] animalnames = { "Wolf", "Fox", "Bunny", "Boar", "Bear" };
    private static int[] animalage = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    private static double[] weightAnimal = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    private static string[] wherecanlive = { "Forest", "Tundra", "Steppe" };
    private static double[] countofann = { 10, 22, 34, 11, 48, 21, 35, 40, 45, 50 };
    private static double[] rateOfChange = { 0.9, 0.8, 1.3, 2.4, 1.5, 0.5 };

    public static string RandName()
    {
        return animalnames[random.Next(animalnames.Length)];
    }

    public static int RandAge()
    {
        return animalage[random.Next(animalage.Length)];
    }

    public static double RandWeight()
    {
        return weightAnimal[random.Next(weightAnimal.Length)];
    }

    public static double RandCountOfAnimal()
    {
        return countofann[random.Next(countofann.Length)];
    }

    public static double RandRateOfChange()
    {
        return rateOfChange[random.Next(rateOfChange.Length)];
    }

    public static string RandWhere()
    {
        return wherecanlive[random.Next(wherecanlive.Length)];
    }

    public static PredatoryAnimals RandPredator()
    {
        return new PredatoryAnimals(RandName(), RandAge(), RandWeight(),RandWhere(), RandCountOfAnimal(), RandRateOfChange());
    }

}