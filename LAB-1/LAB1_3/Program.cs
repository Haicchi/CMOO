namespace LAB1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int otvet = 0;
            Console.WriteLine("Привіт , пройди цей тест та взнаєш на що здатен");
            Console.WriteLine("1 Питання : Професор ліг спати о 8 годині, а встав о 9 годині. Скільки годин проспав професор?");
            otvet = Convert.ToInt32(Console.ReadLine());
            if (otvet == 1) {
                count++;
                }Console.WriteLine("2 Питання : На двох руках десять пальців. Скільки пальців на 10?");
            otvet = Convert.ToInt32(Console.ReadLine());
            if (otvet == 50) {
                count++;
                }Console.WriteLine("3 Питання : Скільки цифр у дюжині?");
            otvet = Convert.ToInt32(Console.ReadLine());
            if (otvet == 2) {
                count++;
                }Console.WriteLine("4 Питання : Скільки потрібно зробити розпилів, щоб розпиляти колоду на 12 частин?");
            otvet = Convert.ToInt32(Console.ReadLine());
            if (otvet == 11) {
                count++;
                }Console.WriteLine("5 Питання : Лікар зробив три уколи в інтервалі 30 хвилин. Скільки часу він витратив?");
            otvet = Convert.ToInt32(Console.ReadLine());
            if (otvet == 30) {
                count++;
                }Console.WriteLine("6 Питання : Скільки цифр 9 в інтервалі 1100?");
            otvet = Convert.ToInt32(Console.ReadLine());
            if (otvet == 1) {
                count++;
                }Console.WriteLine("7 Питання : Пастух мав 30 овець. Усі, окрім однієї, розбіглися. Скільки овець лишилося?");
            otvet = Convert.ToInt32(Console.ReadLine());
            if (otvet == 1) {
                count++;
                }
            switch (count)
            {
                case 0: Console.WriteLine("Вам треба відпочити!"); break;
                case 1: Console.WriteLine("Вам треба відпочити!"); break;
                case 2: Console.WriteLine("Вам треба відпочити!"); break;
                case 3: Console.WriteLine("Здібності нижче середнього");break;
                case 4: Console.WriteLine("Здібності середні");break;
                case 5: Console.WriteLine("Нормальний");break;
                case 6: Console.WriteLine("Ерудит");break;
                case 7: Console.WriteLine("Геній");break;


            }
            Console.ReadLine();

        }

    }
}
