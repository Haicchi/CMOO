namespace LB_6._1;

class Program
{
    static void Main(string[] args)
    {
        //9 ZADANIE
        PredatoryAnimals p = CreatePredator.RandPredator();
        Console.WriteLine(p.ToString());
        p.IsFine();

        WildAnimals[] zoopark = {CreatePredator.RandPredator(), CreatePredator.RandPredator(),CreatePredator.RandWildAnimal()};

        for (int i = 0; i < zoopark.Length; i++)
        {
            Console.WriteLine(zoopark[i].ToString());
        }
        Array.Resize(ref zoopark, zoopark.Length + 1);
        zoopark[zoopark.Length - 1] = CreatePredator.RandPredator();
        Console.WriteLine("Changed");
        for (int i = 0; i < zoopark.Length; i++)
        {
            Console.WriteLine(zoopark[i].ToString());
        }
    }
    
}