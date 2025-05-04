using System.Reflection.Metadata;

namespace ConsoleApp1;



class Program
{
    static void Display(string message)
    {
        Console.WriteLine(message);
    }
    static void Main(string[] args)
    {
      Handler1 handler1 = new Handler1();  
      Handler2 handler2 = new Handler2();
      Valiza valiza1 = Creator.RandomValiza();
      Item item1 = Creator.RandomItem();
      Item item2 = Creator.RandomItem();
      Item item3 = Creator.RandomItem();
      Item[] items = { item1, item2, item3 };
      valiza1.WorkWithItems += handler1.ItemProcedure;
      valiza1.WorkWithItems += handler2.ItemProcedure2;
      valiza1.Notify += Display;
      
      Console.WriteLine(valiza1.ToString());
      Console.WriteLine(item1.ToString());
      Console.WriteLine(item2.ToString());
      Console.WriteLine(item3.ToString());
      valiza1.ItemAdd(item1);
      Console.WriteLine(valiza1.ToString());
      valiza1.ItemDelete(item1);
      Console.WriteLine(valiza1.ToString());
      
      
    }
}