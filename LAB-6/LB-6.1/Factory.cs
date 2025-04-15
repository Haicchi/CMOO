namespace LB_6._1;

public static class Factory
{
    private static WildAnimals[] zoopark = {};

    public static void ShowZooPark(WildAnimals [] zoopark)
    {
        for (int i = 0; i < zoopark.Length; i++)
        {
            if (zoopark[i] is PredatoryAnimals predator)
            {
                Console.WriteLine(predator.ToString());
                Console.WriteLine(predator.AnimalType());
                
                predator.IsFine();
                
            }
            else
            {
                Console.WriteLine(zoopark[i].ToString());
                Console.WriteLine(zoopark[i].AnimalType());
                
            }

        }
        
    }
}