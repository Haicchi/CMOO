namespace _6_2;

static class Creator
{
    private static Random random = new Random();
    private static string[] productName = {"Dobrodar","Prostokvashino","Svoya Liniya"};
    private static int[] productCost ={50,120,304,589,238,120};
    private static int[] productId ={1,4,6,8,2,7,23};
    private static string[] productType = {"Bread","Cheese","Diary"};
    private static string[] razdelmagazina = {"Xlebniy","Sirnii","Molochka"};
    private static string[] breadType = {"White","Dark","Tost"};
    private static string[] cheeseType = {"Parmesan","Blue Cheese","Mozzarella"};
    private static string[] diaryType = {"Milk","Kefir","Airan","Yoghurt"};
    
    public static string RandomProductName(){
        return productName[random.Next(productName.Length)];
    }

    public static int RandomProductCost()
    {
        return productCost[random.Next(productCost.Length)];
    }

    public static int RandomProductId()
    {
        return productId[random.Next(productId.Length)];
    }

    public static string RandomBreadType()
    {
        return breadType[random.Next(breadType.Length)];
    }

    public static string RandomCheeseType()
    {
        return cheeseType[random.Next(cheeseType.Length)];
    }

    public static string RandomDiaryType()
    {
        return diaryType[random.Next(diaryType.Length)];
    }

    public static Bread RandomBread()
    {
        return new Bread(RandomProductName(), RandomProductCost(), RandomProductId(),"Bread",razdelmagazina[0],RandomBreadType());
    }
    public static Cheese RandomCheese()
    {
        return new Cheese(RandomProductName(), RandomProductCost(), RandomProductId(), productType[1],razdelmagazina[1],RandomCheeseType());
    }
    public static DairyProducts RandomDairyProducts()
    {
        return new DairyProducts(RandomProductName(), RandomProductCost(), RandomProductId(), productType[2],razdelmagazina[2],RandomDiaryType());
    }
    
}