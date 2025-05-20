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
        showTime += Methods.ShowTime;
        showTime();
        showDate += Methods.ShowDate;
        showDate();
        showDayOfWeek += Methods.ShowDay;
        showDayOfWeek();
        Prostoi += Methods.ProstoeLiChislo;
        Console.WriteLine(Prostoi(11));
        Console.WriteLine(Prostoi(12));
        Fibonacci += (Methods.IsFiba);
        Console.WriteLine(Fibonacci(5));
        triangle += Methods.Pramokytni;
        Console.WriteLine(triangle(5,7));
        Pramokytnik += Methods.Pryamougolnik;
        Console.WriteLine(Pramokytnik(5,7));
    }
}