namespace LAB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double x = -0.02235;
            //double y = 2.23;
            //double z = 15.221;
            //double result = 0;
            double x = 0;
            double y = 0;
            double z = 0;
            double result = 0;
            Console.WriteLine("Input number x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input number y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input number z");
            z = Convert.ToDouble(Console.ReadLine());
            result = ((Math.Exp(Math.Abs(x-y))*Math.Pow(Math.Abs(x-y),x+y))/(Math.Atan(x)+Math.Atan(z)))+(Math.Pow(Math.Pow(x,6)+Math.Pow(Math.Log(y),2),1/3));
            Console.WriteLine($"g({x,4},{y},{z})={result}");
            Console.ReadLine();

        }
    }
}
