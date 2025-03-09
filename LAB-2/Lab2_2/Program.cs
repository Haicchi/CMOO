using System.Numerics;

namespace Lab2_2
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            string povtor = "";
            int i = 0;
            double[] xs = { 2, 20, -15 };
            Console.WriteLine("Do you want to use base array of nums or type yours?(1-BASE 2-YOUR CHOICE)");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter the number of elements");
                int n = Convert.ToInt32(Console.ReadLine());
                xs = new double[n];
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Enter the {j + 1} element");
                    xs[j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            double yotx = 0;
            do
            {
                
                foreach (double x in xs)
                {
                    double sum = 1.0;
                    double factorial = 1.0; 
                    double powerOfTwo = 1.0; 
                    double u;
                    int n = 1;
                    int iter = 0;
                    do
                    {
                        factorial *= n;  
                        powerOfTwo *= 2; 

                        u = ((n * n + 1) * Math.Pow(x, n)) / (factorial * powerOfTwo);
                        sum += u;
                        n++;
                        iter++;

                    } while (Math.Abs(u) >= 1e-6);
                    Console.WriteLine($"Сума ряду за умови x = {x:F6},iteration {iter} ,nomer {u:F6} / {sum:F6}");
                
                    Console.WriteLine("For y(x)");
                
                    double z = x / 2;
                    yotx = (Math.Pow(z, 2) + z + 1) * Math.Exp(x);
                    Console.WriteLine($"z = {z:F6} x = {x:F6} yotx = {yotx:F6}");
               
                
                    Console.WriteLine($"x = {x}\tsum = {sum:F6}\tyotx = {yotx:F6}\traznica = {Math.Abs(sum - yotx):F6}");
                    Console.WriteLine("/////////////////////////////////////////////");
                }




                Console.WriteLine("To restart type anything to stop press enter");
                povtor = Console.ReadLine();
            } while (povtor != "");
            
        }
    }
}
