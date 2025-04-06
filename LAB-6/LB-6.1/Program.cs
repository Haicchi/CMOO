namespace LB_6._1;

class Program
{
    static void Main(string[] args)
    {
        //9 ZADANIE
        PredatoryAnimals p = CreatePredator.RandPredator();
        Console.WriteLine(p.ToString());
        p.IsFine();


    }
}