namespace ConsoleApp1;

public class Handler2
{
    public void ItemProcedure2(ref Item[] items, Item item)
    {
        Item[] temp = new Item[items.Length - 1];
        int index = Array.IndexOf(items, item);
        if (index == null)
        {
            Console.WriteLine("Cannot delete null element");

        }
       

        for (int i = 0; i < items.Length; i++)
        {
            if (i != index)
            {
                temp[i] = items[i];

            }
        }

        items = temp;
    }
}