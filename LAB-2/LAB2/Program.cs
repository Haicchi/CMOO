namespace LAB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int astart = 10;
            int aend = 2;
            double xstart = 0;
            double xend = 2.01;
            double step = 0.050;
            int stepa = 2;
            double x = 0;
            int a = 0;
            double y = 0;
            y = Math.Pow(a, -x) - Math.Pow(a, -a * x);
            Console.WriteLine($"x = {x} a = {a} result = {y}");
            for (x = xstart; x <= xend; x += step)
            {
                for (a = astart; a >= aend; a -= stepa)
                {

                    y = Math.Pow(a, -x) - Math.Pow(a, -a * x);
                    Console.WriteLine($"x = {x} a = {a} result = {y}");
                }

            }
            

        }
    }
}
