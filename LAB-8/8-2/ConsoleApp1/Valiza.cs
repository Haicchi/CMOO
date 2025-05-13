namespace ConsoleApp1;

public class Valiza
{
    private string color;
    private string brand;
    private double weightValiza;
    private double volumeValiza;
    private Item[] items;
    private double maxVolume;
    private int itemcount;
    

    public Valiza()
    {
        color = "";
        brand = "";
        weightValiza = 0;
        volumeValiza = 0;
        items = new Item[0];
        maxVolume = 0;
        itemcount = 0;
    }

    public Valiza(string color, string brand, double weightValiza, double volumeValiza, Item[] items, double maxVolume,int itemcount)
    {
        this.color = color;
        this.brand = brand;
        this.weightValiza = weightValiza;
        this.volumeValiza = volumeValiza;
        this.items = items;
        this.maxVolume = maxVolume;
        this.itemcount = itemcount;
    }

    public Item[] GetItems
    {
        get 
        { 
            Item[] result = new Item[itemcount];
            Array.Copy(items, result, itemcount);
            return result; 
        }
    }

    public double VolumeValiza
    {
        get{ return volumeValiza; }
        set { volumeValiza = value; }
    }

    public double Volume
    {
        get { return volumeValiza; }
        set
        {
            if (!(value is double && value < 0))
            {
                throw new ArgumentException();
            }
            volumeValiza = value;
        }
    }
    public delegate void AddItemHandler(ref Item[] items,Item item);
    public event AddItemHandler WorkWithItems;
    public event AddItemHandler ItemDeleter;

    public delegate void NotifyHandler(string message);
    public event NotifyHandler Notify;
    

    public void ItemAdd(Item item)
    {
        if (volumeValiza + item.ItemMass < maxVolume)
        {
            volumeValiza += item.ItemMass;
            
            WorkWithItems.Invoke(ref items,item);
            itemcount++;
            Notify.Invoke("Item added");
        }
        else
        {
            Notify?.Invoke($"Volume exceeded maximum volume.Item isnt added");

            
        }
    }

    public void ItemDelete(Item item)
    {
        VolumeValiza -= item.ItemMass;
        ItemDeleter.Invoke(ref items,item);
        itemcount = items.Length;
        Notify.Invoke("Item deleted");
    }

    public override string ToString()
    {
        return $"Color : {color} | Brand : {brand} | Weight : {weightValiza} | Volume : {volumeValiza} | Items quantity : {itemcount} | Max Volume : {maxVolume}";
    }
    
}