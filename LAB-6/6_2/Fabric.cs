namespace _6_2;

static class Fabric
{
    private static Product[] shop;
    private static string checker;
    private static int price;

    public static void ShowShop(Product[] shop)
    {
        for (int i = 0; i < shop.Length; i++)
        {
            Console.WriteLine(shop[i].ToString());
        }
    }

    

    public static void ShowRazdel(Product[] shop, string checker)
    {
        for (int i = 0; i < shop.Length; i++)
        {
            if (shop[i].KonRazdelMagazin == checker)
            {
                Console.WriteLine(shop[i].ToString());
            }
        }
    }

    public static void ShowUnderPrice(Product[] shop, int price)
    {
        for (int i = 0; i < shop.Length; i++)
        {
            if (shop[i].ProductCost <= price)
            {
                Console.WriteLine(shop[i].ToString());
            }
        }
    }

}