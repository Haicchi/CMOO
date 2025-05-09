using System.Text.Json;
using System.Xml.Serialization;

namespace _10_1;

class Program
{
    static async Task Main(string[] args)
    {
        Tovar tovar1 = Creator.RandomTovar();
        Tovar tovar2 = Creator.RandomTovar();
        Tovar tovar3 = Creator.RandomTovar();
        Tovar[] tovars = { tovar1, tovar2, tovar3 };
        Console.WriteLine("Enter max price for your budget");
        int max = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < tovars.Length; i++)
        {
            for (int j = 0; j < tovars[i].Shops.Length; j++)
            {
                if (tovars[i].Shops[j].Price <= max)
                {
                    Console.WriteLine($"You can by {tovars[i].TovarName} in {tovars[i].Shops[j].ShopName}, for {tovars[i].Shops[j].Price}.");
                }
            }
        }
        
        Console.WriteLine(tovar1.ToString());
        // Console.WriteLine("JSON SERIALIZATION:");
        // string json = JsonSerializer.Serialize(tovars);
        // Console.WriteLine(json);
        // Tovar[]? tovars2 = JsonSerializer.Deserialize<Tovar[]>(json);
        // Console.WriteLine("JSON DESERIALIZATION:");
        // for (int i = 0; i < tovars2.Length; i++)
        // {
        //     Console.WriteLine(tovars2[i].ToString());
        // }
        // using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
        // {
        //     await JsonSerializer.SerializeAsync<Tovar[]>(fs, tovars);
        //     Console.WriteLine("Data has been saved to file");
        // }
        // using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
        // {
        //     Tovar[]? tovars3 = await JsonSerializer.DeserializeAsync<Tovar[]>(fs);
        //     for (int i = 0; i < tovars3.Length; i++)
        //     {
        //         Console.WriteLine(tovars3[i].ToString());
        //     }
        //     
        // }
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Tovar[]));
        using (FileStream fs = new FileStream("tovars.xml", FileMode.OpenOrCreate))
        {
            xmlSerializer.Serialize(fs, tovars);
            Console.WriteLine("Tovars xml has been saved.");
        }

        using (FileStream fs = new FileStream("tovars.xml", FileMode.OpenOrCreate))
        {
            Tovar[] newTovars = xmlSerializer.Deserialize(fs) as Tovar[];
            if (newTovars != null)
            {
                foreach (Tovar tovar in newTovars)
                {
                    Console.WriteLine(tovar.ToString());
                }
            }
        }
        
    }
}