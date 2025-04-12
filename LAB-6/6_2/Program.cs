namespace _6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string checker = "";
            Product[] Shop = {Creator.RandomBread(),Creator.RandomBread(),Creator.RandomCheese(),Creator.RandomCheese(),Creator.RandomDairyProducts(),Creator.RandomDairyProducts()};
            Fabric.ShowShop(Shop);

            Console.WriteLine("Which Shop viddil you want to check?(1-Bread.2-Cheese.3-DairyProducts)");
            int  choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                {
                    checker = "Xlebniy";
                    break;
                }
                case 2:
                {
                    checker = "Sirnii";
                    break;
                }
                case 3:
                {
                    checker = "Molochka";
                    break;
                }
            }
            Fabric.ShowRazdel(Shop, checker);

           

            Console.WriteLine();
            Console.ReadKey();
            
            Console.WriteLine("Which price is max for your budget?");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("With that much money you can buy that products?");
            Fabric.ShowUnderPrice(Shop, price);
        }
    }
}
