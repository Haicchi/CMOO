namespace ConsoleApp1;

public static class Creator
{
    private static Random random = new Random();
    private static string[] itemName = {"Kirpich","laptop","tetradka","telefon","odyag"};
    private static double[] volumeItem = {12.5, 24.5, 5.1, 3.5, 4.7,11,7,5,3};
    private static string[] color = {"red","blue","cyan","pink"};
    private static string[] brands = {"dougres","hielque","swerden","kdokaok"};
    private static double[] weightofValiza = {10,8,12,14};
    private static double startvolume = 0;
    private static double[] maxvolume = {50,100,75,26,28.4};

    public static string RandomItemName()
    {
        return itemName[random.Next(itemName.Length)];
    }

    public static double RandomVolumeItem()
    {
        return volumeItem[random.Next(volumeItem.Length)];
    }

    public static string RandomColor()
    {
        return color[random.Next(color.Length)];
    }

    public static string RandomBrand()
    {
        return brands[random.Next(brands.Length)];
    }

    public static double RandomWeightofValiza()
    {
        return weightofValiza[random.Next(weightofValiza.Length)];
    }

    public static double RandomMaxVolume()
    {
        return maxvolume[random.Next(maxvolume.Length)];
    }

    public static Item RandomItem()
    {
        return new Item(RandomItemName(), RandomVolumeItem());
    }

    public static Valiza RandomValiza()
    {
        return new Valiza(RandomColor(), RandomBrand(), RandomWeightofValiza(),startvolume,new Item[0]{},RandomMaxVolume(),0);
    }
}