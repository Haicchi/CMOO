namespace _8_1;

public static class Methods
{
   public static void ShowTime()
   {
      Console.WriteLine(DateTime.Now);
   }

   public static void ShowDate()
   {
      Console.WriteLine(DateTime.Now.Date);
   }

   public static void ShowDay()
   {
      Console.WriteLine(DateTime.Now.DayOfWeek);
   }

   public static bool ProstoeLiChislo(int n)
   {
      if(n<0){return false;}
      for (int i = 2; i < n; i++)
      {
         if (n % i == 0)
         {
            return false;
         }

         
      }
      return true;
   }

   public static int FindFibonacci(int n)
   {
      return FindFibonacci(n-1)+FindFibonacci(n-2);
   }

   public static bool IsFiba(int n)
   {
      if (n < 0)
      {
         return false;
      }

      // int fib = FindFibonacci(n);
      //
      // if (fib / n == 1.6)
      // {
      //    return true;
      // }
      // else
      // {
      //    return false;
      // }
      if (Math.Sqrt(5 * (n * n) - 4) % 1 == 0)
      {
         return true;
      }
      else return false;

   }

   public static double Pramokytni (double a, double b)
   {
      if (a <= 0 || b <= 0)
      {
         return 0;
      }
      double s = a * b * b;
      return s;
   }

   public static double Pryamougolnik (double x, double y)
   {
      if (x <= 0 || y <= 0)
      {
         return 0;
      }
      double f = x * y;
      return f;
   }
}

