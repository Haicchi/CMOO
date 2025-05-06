namespace _9_1;

class Program
{
    public static void Main(String[] args)
       {
        //путь к файлу D:\\C#\\LABS\\Blah.txt
        Console.WriteLine("Put a path");
        string path = Console.ReadLine();
        FileInfo file = new FileInfo(path);
        Console.WriteLine(file.Exists);
        if (!file.Exists)
        {
            Console.WriteLine("File not found");
            return ;
        }
        Console.WriteLine("How you want to count lines (1-by '.' symbol)(2- by tabulation)");
        int b = Convert.ToInt32(Console.ReadLine());
        
        string linesss = File.ReadAllText(path);
        if (b == 1)
        {
            Console.WriteLine(linesss.Split('.').Count());
        }
        else if (b == 2)
        {
            Console.WriteLine(linesss.Split('\n').Count());
        }
        else{
            Console.WriteLine("wrong input");
        }
        char[] symbols = linesss.ToCharArray();
        Console.WriteLine("Up symbols are:");
        int count = 0;
        for (int i = 0; i < symbols.Length; i++)
        {
            if (char.IsLetter(symbols[i]) && char.IsUpper(symbols[i]))
            {
                count++;
            }
        }

        Console.WriteLine(count);
        count = 0;
        Console.WriteLine("Down symbols are:");
        for (int i = 0; i < symbols.Length; i++)
        {
            if (char.IsLetter(symbols[i]) && char.IsLower(symbols[i]))
            {
                count++;
            }
        }
        Console.WriteLine(count);
        char[] glasnieBykvi = { 'A', 'E', 'I', 'O', 'U', 'Y'};
        char [] soglasineBykvi = {'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z'};
        count = 0;
        Console.WriteLine("Kolishestvo golosnix");
        
        for (int i = 0; i < symbols.Length; i++)
        {
            
            if (char.IsLetter((symbols[i])) && glasnieBykvi.Contains(char.ToUpper(symbols[i])))
            {
                count++;
            }
        }
        Console.WriteLine(count);
        count = 0;
        Console.WriteLine("Kolishestvo prigolosnix");
        for (int i = 0; i < symbols.Length; i++)
        {
            if (char.IsLetter(symbols[i]) && soglasineBykvi.Contains(char.ToUpper(symbols[i])))
            {
                count++;
            }
        }
        Console.WriteLine(count);
        count = 0;
        Console.WriteLine("Kolichesto chisel");
        for (int i = 0; i < symbols.Length; i++)
        {
            if (char.IsDigit(symbols[i]))
            {
                count++;
            }
        }

        Console.WriteLine(count);
       }
}