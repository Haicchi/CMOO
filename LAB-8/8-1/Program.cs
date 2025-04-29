namespace _8_1;

class Program
{
    public static Action showTime;
    public static Action showDate;
    public static Action showDayOfWeek;
    public static Predicate<int> Prostoi;
    public static Predicate<int> Fibonacci;
    public static Func<double, double,double> triangle;
    public static Func<double, double, double> Pramokytnik;

    static void Main(string[] args)
    {
        showTime += new Action(Methods.ShowTime);
        showTime();
        showDate += new Action(Methods.ShowDate);
        showDate();
        showDayOfWeek += new Action(Methods.ShowDay);
        showDayOfWeek();
        Prostoi += new Predicate<int>(Methods.ProstoeLiChislo);
        Console.WriteLine(Prostoi(11));
        Console.WriteLine(Prostoi(12));
        Fibonacci += new Predicate<int>(Methods.IsFiba);
        Console.WriteLine(Fibonacci(5));
        triangle += new Func<double, double, double>(Methods.Pramokytni);
        Console.WriteLine(triangle(5,7));
        Pramokytnik += new Func<double, double, double>(Methods.Pryamougolnik);
        Console.WriteLine(Pramokytnik(5,7));
    }
}