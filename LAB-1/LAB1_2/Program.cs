namespace LAB1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kilkop = 8;
            double x = 0;
            double y = 0;
            double result = 0;
            int interval_xmax = 0;
            int interval_xmin = 0;

            using (StreamReader vvod = new StreamReader("LAB2.txt"))
            {
                x = double.Parse(vvod.ReadLine());
                y = double.Parse(vvod.ReadLine());
                interval_xmax = int.Parse(vvod.ReadLine());
                interval_xmin = int.Parse(vvod.ReadLine());
            }
            double tinterval = interval_xmax - interval_xmin;
            double change = tinterval / kilkop;
            result = (Math.Sin(x)) / (Math.Pow(x, 2) + 1);
            Console.WriteLine($"Result(With start data) = {result}");

            StreamWriter vivod = new StreamWriter("VIVOD.txt");
            vivod.WriteLine("Отримано");
            for (x = interval_xmin; x <= interval_xmax; x += change)
            {


                result = (Math.Sin(x)) / (Math.Pow(x, 2) + 1);
                vivod.WriteLine($"Для заданої функції Y({x}) = {result}");
                x += change;


            }
            vivod.WriteLine("Розрахував студент Клінген Кирило Вікторович");
            vivod.Close();

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(interval_xmin);
            //Console.WriteLine(interval_xmax); 

        }
    }
}
