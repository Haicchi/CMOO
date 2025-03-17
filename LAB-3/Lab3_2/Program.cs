namespace Lab3_2
{
    internal class Program
    {
        static void MultiArr(int[][] arr)
        {
            foreach (var i in arr)
            {
                foreach (var j in i)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int z = 0;
            Random rand = new Random();
            int n = 0;
            int m = 0;
            Console.WriteLine("Put in size of arrray A(Max=20)");
            m = Convert.ToInt32(Console.ReadLine());
            if (m > 20)
            {
                Console.WriteLine("Wrong size");
                return;
            }
            Console.WriteLine("Put in size of array X(Max=20)");
            if (n > 20)
            {
                Console.WriteLine("Wrong size");
                return;
            }
            n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[m];
            double[] X = new double[n];
            for (int i = 0; i < A.Length; i++)
            {

                A[i] = rand.Next(0, 2);
            }
            Console.WriteLine("How you want to fill A array(1-manually 2-Random 3 - from file");
            z = Convert.ToInt32(Console.ReadLine());
            switch (z)
            {
                case 1:


                    for (int i = 0; i < X.Length; i++)
                    {
                        Console.WriteLine($"Type in element number {i + 1}");
                        X[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    break;

                case 2:
                    for (int i = 0; i < X.Length; i++)
                    {
                        X[i] = new Random().Next(1, 51);
                    }

                    break;

                case 3:
                    using (StreamReader sr = new StreamReader("Preset.TXT"))
                    {
                        string[] lines = sr.ReadToEnd().Split();
                        X = new double[lines.Length];
                        for (int i = 0; i < X.Length; i++)
                        {
                            X[i] = double.Parse(lines[i]);
                        }
                    }
                    break;
                default: Console.WriteLine("Wrong operation"); break;
            }
            for (int i = 0; i < Math.Min(m, n); i++)
            {
                if (A[i] == 1)
                {
                    X[i] *= (7.0 / 10.0);
                }
                else
                {
                    X[i] /= (-10.0 / 7.0);
                }
            }
            for (int i = 0; i < X.Length; i++)
            {
                Console.Write($"{X[i]} ");
            }
            double min = X.Min();
            double max = X.Max();
            X = X.Append(min).ToArray();
            X = X.Append(max).ToArray();
            Console.WriteLine();
            for (int i = 0; i < X.Length; i++)
            {
                Console.Write($"{X[i]} ");
            }
            int rows = rand.Next(3, 8);
           
            int[][] megaarray = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                int cols = rand.Next(5, 11);
                megaarray[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    megaarray[i][j] = rand.Next(-50, 51);
                    
                }
                

            }
            Console.WriteLine();
            Console.WriteLine("MEGAARRAY");
            MultiArr(megaarray);
            for (int i = 0; i < rows; i += 2)
            {
                Array.Sort(megaarray[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Sorted");
            MultiArr(megaarray);

        }
    }
}