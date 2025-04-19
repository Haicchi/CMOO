namespace LAB_7_1;

public class PersonCreate
{
    static private string[] names = { "Vasya", "Petya", "Pasha", "Dima", "Max", "Bogdan", "Vlad", "Alexandr" };
    static private Random random = new Random();
    static private string[] last = { "Kirilenko", "Klingen", "Bobuh", "Kulagin", "Dada", "Vava", "Lolo", "Koko" };
    static private DateTime[] dateofbirth = { DateTime.Now, DateTime.Now.AddDays(10), DateTime.Now.AddDays(48), DateTime.Now.AddDays(25) };
    static public DateTime getrandomdate()
    {
        return dateofbirth[random.Next(4)];
    }
    public static string GetRandomLast()
    {
        return last[random.Next(7)];
    }
    public static string GetRandomName()
    {
        return names[random.Next(7)];
    }
    public static Person GetRandomPerson()
    {
        return new Person(GetRandomName(),GetRandomLast(),getrandomdate());
    }
}