namespace _7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Acipher obj = new Acipher();
           // Console.WriteLine("Enter your string");
           // string text  = Console.ReadLine();
           // Console.WriteLine(obj.encode(text));
           // Console.WriteLine(obj.decode(text));
           // Console.ReadLine();
           Bcipher obj2 = new Bcipher();
            Console.WriteLine("Enter your string");
            string text = Console.ReadLine();
            Console.WriteLine(obj2.encode(text));
            string smth = obj2.encode(text);
            Console.WriteLine(obj2.decode(smth));
            Console.ReadKey();
        }
    }
}
