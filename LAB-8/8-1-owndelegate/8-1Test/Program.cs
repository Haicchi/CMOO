namespace _8_1Test
{
    internal class Program
    {
        public delegate void Show();
        public delegate bool OperwithNum(int x);
        public delegate double OperWithNum2(double x, double y);
       
        static void Main(string[] args)
        {
            
            Show del1 = new Show( Methods.ShowTime);
            del1 += Methods.ShowDate;
            del1 += Methods.ShowDay;
            foreach (Delegate a in del1.GetInvocationList())
            {

                Console.WriteLine(a.DynamicInvoke());

            }
            OperwithNum del2 = new OperwithNum(Methods.ProstoeLiChislo);
            del2 += Methods.IsFiba;
            foreach (Delegate a in del2.GetInvocationList())
            {
                Console.WriteLine(a.DynamicInvoke(5));
            }
            OperWithNum2 del3 = new OperWithNum2(Methods.Pryamougolnik);
            del3 += Methods.Pramokytni;
            foreach (Delegate a in del3.GetInvocationList())
            {
                Console.WriteLine(a.DynamicInvoke(6,5));
            }
            //showTime += Methods.ShowDay;
            //showTime += Methods.ShowDate;
            //showTime.Invoke();
            //Func<int,int> func = x => x;
            //func += x => x + 2;
            //func += x => x + 4;
            //Console.WriteLine(func(2));
            //foreach (Delegate a in func.GetInvocationList())
            //{
               
            //    Console.WriteLine(a.DynamicInvoke(2));
                
            //}
            //Prostoi += new Predicate<int>(Methods.ProstoeLiChislo);
            //Prostoi += new Predicate<int>(Methods.IsFiba);
            Console.ReadLine();

        }
    }
}
