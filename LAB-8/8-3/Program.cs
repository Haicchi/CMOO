namespace _8_3;

class Program
{
    public delegate int MyDelegate(int[] a);
    public delegate bool MyDelegate2(DateTime date);
    
    public delegate bool MyDelegate3(string[] words , string text);
    static void Main(string[] args)
    {
        string[] words = {"wolf","fox"};
        string text = "wolf lives in forest";
        string tex2 = "wolf and fox lives in forest";
        MyDelegate pozitive = (int[] a) => a.Count(num=> num>0);
        MyDelegate pozitive2 = (int[] a) =>
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 7 == 0)
                {
                    count++;
                }
            }
            return count;
        };
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9,14,21,28 };
        MyDelegate kratne7 = (int[] a) => a.Count(num => num % 7 == 0);
        kratne7+=pozitive;
        kratne7+=pozitive2;
        foreach (Delegate b in kratne7.GetInvocationList())
        {
        
            Console.WriteLine(b.DynamicInvoke(a));
        
        }
        MyDelegate2 DayOfProgramer = (DateTime date) => date.DayOfYear == 256;
        Console.WriteLine(DayOfProgramer(DateTime.Today));
        MyDelegate3 Checker = (string[] words, string text) => words.All(word => text.Contains(word));
        MyDelegate3 Checker2 = (string[] words, string text) =>
        {
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                
                if (text.Contains(words[i]))
                {
                    count++;
                }
            }

            if (count == words.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        };
        Console.WriteLine(Checker(words,text));
        Console.WriteLine(Checker(words,tex2));
        Console.WriteLine(Checker2(words,text));
        Console.WriteLine(Checker2(words,tex2));
    }
}