using System.Text.RegularExpressions;

namespace _4_1_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int z = 0;
            Console.WriteLine("Which task you want to check (1-8 2-1)");
            z = Convert.ToInt32(Console.ReadLine());
            switch (z)
            {
                case 1:
                    string check = @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

                    string[] testik = { "127.0.0.1", "255.255.255.0", "1300.6.7.8", "abc.def.gha.bcd", "192.168.1.256" };

                    Regex test = new Regex(check);
                    foreach (string prove in testik)
                    {
                        Console.WriteLine($"{prove} = {test.IsMatch(prove)}");
                    }
                    break;
                case 2:
                    {
                        string check2 = "abcdefghijklmnopqrstuv18340";
                        string[]proverka = { "abcdefghijklmnoasdfasdpqrstuv18340","dadwdjawiojdoawjidawjio","dawiojdfguhfuhgioj","abcdefghijklmnopqrstuv18340"};
                        Regex test2 = new Regex(check2);
                        foreach (string line in proverka)
                        {
                            Console.WriteLine($"{line} = {test2.IsMatch(line)}");
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong number");
                        break;
                    }
            }
        }
    }
}
