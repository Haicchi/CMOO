namespace _8_3;

class Program
{
    public static bool seven(int a)
    {
      return (a % 7) == 0;    
    }
    public delegate int MyDelegate(int[] a);

    public delegate int MyDelegate4(int[] a,Predicate<int> predicate);
    public delegate bool MyDelegate2(DateTime date);
    
    public delegate bool MyDelegate3(string[] words , string text);
    static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9,14,21,28 };
        Predicate <int> Kratne = seven;
        
        MyDelegate4 dabe = (int[] a, Predicate<int> b) =>
        {
            int count = 0;
            foreach (var variable in a)
            {
                if (b(variable))
                {
                    count++;
                }
            }
            return count;
        };
        Console.WriteLine(dabe(a,seven));
        // string[] words = {"wolf","fox"};
        // string text = "wolf lives in forest";
        // string tex2 = "wolf and fox lives in forest";
        // MyDelegate pozitive = (int[] a) => a.Count(num=> num>0);
        // MyDelegate pozitive2 = (int[] a) =>
        // {
        //     int count = 0;
        //     for (int i = 0; i < a.Length; i++)
        //     {
        //         if (a[i] % 7 == 0)
        //         {
        //             count++;
        //         }
        //     }
        //     return count;
        // };
        //
        // MyDelegate kratne7 = (int[] a) => a.Count(num => num % 7 == 0);
        // kratne7+=pozitive;
        // kratne7+=pozitive2;
        // foreach (Delegate b in kratne7.GetInvocationList())
        // {
        //
        //     Console.WriteLine(b.DynamicInvoke(a));
        //
        // }
        // MyDelegate2 DayOfProgramer = (DateTime date) => date.DayOfYear == 256;
        // Console.WriteLine(DayOfProgramer(DateTime.Today));
        // MyDelegate3 Checker = (string[] words, string text) => words.All(word => text.ToLower().Contains(word.ToLower()));
        // MyDelegate3 Checker2 = (string[] words, string text) =>
        // {
        //     int count = 0;
        //     for (int i = 0; i < words.Length; i++)
        //     {
        //         
        //         if (text.ToLower().Contains(words[i].ToLower()))
        //         {
        //             count++;
        //         }
        //     }
        //
        //     if (count == words.Length)
        //     {
        //         return true;
        //     }
        //     else
        //     {
        //         return false;
        //     }
        // };
        // Console.WriteLine(Checker(words,text));
        // Console.WriteLine(Checker(words,tex2));
        // Console.WriteLine(Checker2(words,text));
        // Console.WriteLine(Checker2(words,tex2));
    }
}