using System.Text.RegularExpressions;

namespace _4_2
{
    internal class Program
    {
        static void Show(string[] words)
        {
            foreach (string word in words)
            {
                Console.Write($"{word} ");
            }
        }
        static void Main(string[] args)
        {
            Regex check = new Regex(@"^([A-Za-zА-Яа-яЁё]+(?:\s[A-Za-zА-Яа-яЁё]+)*)$");
            string vvod = String.Empty;
            int z = 0;
            Console.WriteLine("How do you want to fill words (1-from keyboard.2-From file)");
            z = Convert.ToInt32(Console.ReadLine());
            switch (z)
            {
                case 1:
                    Console.WriteLine("Type in words");
                    vvod = Console.ReadLine();
                    break;
                case 2:
                    using(StreamReader sr = new StreamReader("Test.TXT"))
                    {
                        vvod = sr.ReadToEnd();
                    }
                    break;
            }
            if (!check.IsMatch(vvod))
            {
                Console.WriteLine("Wrong input");
                return;
            }
            string[] words = vvod.Split(' ');
            Console.WriteLine("Рядок слів до сортування");
            Show(words);
            words = words.OrderBy(w=>w).ToArray();
            words[0] = char.ToUpper(words[0][0]) + words[0].Substring(1);
            words[1] = char.ToUpper(words[1][0]) + words[1].Substring(1);
            string twoofone = words[0] + words[1];
            words = new[] {twoofone}.Concat(words.Skip(2)).ToArray();
            Console.WriteLine();
            Console.WriteLine("Format");
            Show(words);
            
        }
    }
}
