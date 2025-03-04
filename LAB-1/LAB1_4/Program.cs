namespace LAB1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vantaz = 0;
            int vidstanAB = 0;
            int vidstanBC = 0;
            int spozivana = 0;
            int kilkistpaliva = 0;
            int spozivanaAB = 0;
            int spozivanaBC = 0;
            int zalishok = 0;
            int mindoz = 0;

            using (StreamReader vvod = new StreamReader("LAB4.TXT"))
            {
                vantaz = int.Parse(vvod.ReadLine());    
                vidstanAB = int.Parse(vvod.ReadLine());
                vidstanBC = int.Parse(vvod.ReadLine());
                kilkistpaliva = int.Parse(vvod.ReadLine());
            };
            
            if (vantaz < 0)
            {
                Console.WriteLine("Isnt real");
            }
            else if (vantaz > 2000)
            {
                Console.WriteLine("NE POTYANEM");
            }
            else if (vantaz > 1500)
            {
                spozivana = 9;
            }
            else if (vantaz > 1000)
            {
                spozivana = 7;
            }
            else if (vantaz > 500)
            {
                spozivana = 4;
            }
            else { spozivana = 1; }

            spozivanaAB = spozivana * vidstanAB;
            spozivanaBC = spozivana * vidstanBC;

            //Console.WriteLine(spozivana);
            //Console.WriteLine(spozivanaBC);
            //Console.WriteLine(spozivanaAB);

            if (spozivanaAB + spozivanaBC < kilkistpaliva)
            {
                zalishok = kilkistpaliva - (spozivanaAB + spozivanaBC);
                Console.WriteLine($"Палива достатньо, залишок = {zalishok} litriv");

            }
            else if (spozivanaAB < kilkistpaliva)
            {
                zalishok = kilkistpaliva - spozivanaAB;
                Console.WriteLine($"До пункта B долетіли , залишок {zalishok} litriv");
                if (spozivanaBC<zalishok)
                {
                    zalishok -= spozivanaBC;
                    Console.WriteLine($"Долетіли без дозаправок {zalishok} litriv");
                }
                else {
                    mindoz = spozivanaBC - zalishok;
                    Console.WriteLine($"Потрібна дозаправка як мінімум {mindoz} litriv");

                }
            }
            else { Console.WriteLine("Розміру баку не достатньо"); }
          




            //Console.WriteLine(vantaz);
            //Console.WriteLine(vidstanAB);
            //Console.WriteLine(vidstanBC);
            //Console.WriteLine(kilkistpaliva);
        }
    }
}
