namespace ConsoleApp1;

public class Handler1
{
    public void ItemProcedure(ref Item[] items,Item item)
    {
        
        Array.Resize(ref items, items.Length + 1);
        items[items.Length - 1] = item;
    }


}