using System.Threading.Channels;

namespace _9_2;

class Program
{
    static void Main(string[] args)
    {
        //BAZA TEXT = D:\\C#\\LABS\\Text.txt BAZA WORDS = D:\\C#\\LABS\\Words.txt
        Console.WriteLine("Put a path");
        string path = Console.ReadLine();
        FileInfo file = new FileInfo(path);
        if (!file.Exists)
        {
            Console.WriteLine("File not found");
            return ;
        }

        Console.WriteLine("Put a path to blocked words");
        string path2 = Console.ReadLine();
        FileInfo file2 = new FileInfo(path2);
        if (!file2.Exists)
        {
            Console.WriteLine("File not found");
            return ;
        }

        string textlines = File.ReadAllText(path);
        string Words = File.ReadAllText(path2);
        string[] TextPo = textlines.Split(' ', ',', '.');
        string[] WordsPo = Words.Split(' ', ',', '.');
        for (int i = 0; i < TextPo.Length; i++)
        {
            if (Words.Contains(TextPo[i]))
            {
                char[] chars = TextPo[i].ToCharArray();
                for (int j = 0; j < chars.Length; j++)
                {
                    chars[j] = '*';
                }
                TextPo[i] = new string(chars);
            } 
        }
        Console.WriteLine("где сохранить" );
        string path3 = Console.ReadLine();

        string vivodtext =string.Join(" ", TextPo);
        File.WriteAllText(path3, vivodtext);
    }
}