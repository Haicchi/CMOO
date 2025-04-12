namespace LB_6._1;

class Program
{
    static void Main(string[] args)
    {
        //9 ZADANIE
        // PredatoryAnimals p = CreatePredator.RandPredator();
        // Console.WriteLine(p.ToString());
        // p.IsFine();

        WildAnimals[] zoopark = {CreatePredator.RandPredator(), CreatePredator.RandPredator(),CreatePredator.RandWildAnimal()};

        Factory.ShowZooPark(zoopark);
        Array.Resize(ref zoopark, zoopark.Length + 1);
        zoopark[zoopark.Length - 1] = CreatePredator.RandPredator();
        Console.WriteLine("Changed");
        Factory.ShowZooPark(zoopark);
    }
    
}