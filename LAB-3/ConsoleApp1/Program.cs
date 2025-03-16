namespace ConsoleApp1
{
    internal class Program
    {
        static int ParniNomera(int[]arr)
        {
            int sumnum = 0;
            for (int i = 0; i < arr.Length; i += 2)
            {
                sumnum += arr[i];
            }


            return sumnum;
        }
        static int ParniZnachenya(int[] arr)
        {
            int sumznak = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sumznak += arr[i];
                }
            }


            return sumznak;
        }
        static void DobavTri(int[] arr,int sumnum,int sumznak)
        {
           
            int sum = Math.Abs(sumnum - sumznak);
            while (sum >= 100)
            {
                sum /= 10;
            }
            for(int i=2; i < arr.Length; i += 3)
            {
                arr[i] += sum;
            }
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }




        }
        static void Main(string[] args)
        {
            
            int z = 0;
            const int razmer = 10;
            int[] arr = new int[razmer];
            Console.WriteLine("How you want to fill array(1-handly.2-Random from 1 to 10.3-Preset from file)");
            z = Convert.ToInt32(Console.ReadLine());
            switch (z)
            {
                case 1:
                    
                       
                        for (int i = 0; i < arr.Length; i++)
                        {
                            Console.WriteLine($"Type in element number {i + 1}");
                            arr[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        break;
                    
                case 2:
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = new Random().Next(1, 10);
                    }

                    break;
                    
                case 3:
                    using (StreamReader sr = new StreamReader("Preset.TXT"))
                    {
                        for (int i = 0; i < arr.Length; i++)
                        {
                            arr[i] = int.Parse(sr.ReadLine());
                        }
                        
                    };
                    break;
                default: Console.WriteLine("Wrong operation");break;
            
            }
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            int sumnum = ParniNomera(arr);
            int sumznak = ParniZnachenya(arr);
            Console.WriteLine();
            Console.WriteLine(sumnum); 
            Console.WriteLine(sumznak);
            Console.WriteLine();
            DobavTri(arr, sumnum, sumznak);
        }
    }
}
