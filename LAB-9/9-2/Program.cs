using System.Threading.Channels;

namespace _9_2;

class Program
{
    static void Main(string[] args)
    {
        //BAZA TEXT = D:\\C#\\LABS\\Text.txt BAZA WORDS = D:\\C#\\LABS\\Words.txt
        string path = "D:\\\\C#\\\\LABS\\\\Text.txt";
        if (!File.Exists(path))
        {
            Console.WriteLine("File not found");
            return ;
        }
        string path2 = "D:\\\\C#\\\\LABS\\\\Words.txt";
        if (!File.Exists(path2))
        {
            Console.WriteLine("File not found");
            return ;
        }

        string textlines = File.ReadAllText(path);
        string Words = File.ReadAllText(path2);
        string[] TextPo = textlines.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string[] WordsPo = Words.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < TextPo.Length; i++)
        {
            if (Words.Contains(TextPo[i]))
            {
                char[] chars = TextPo[i].ToCharArray();
                
                
                    for (int j = 0; j < chars.Length; j++)
                    {
                        if (chars[j] != ',' && chars[j] != '.')
                        {
                            chars[j] = '*';
                        }
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