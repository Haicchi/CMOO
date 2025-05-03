namespace ConsoleApp1;

public class Item
{
    private string itemName;
    private double itemMass;

    public Item(string itemName, double itemMass)
    {
        this.itemName = itemName;
        this.itemMass = itemMass;
    }

    public Item()
    {
        itemName = "";
        itemMass = 0;
    }

    public double ItemMass
    {
        get { return itemMass; }
        set { itemMass = value; }
    }

    public override string ToString()
    {
        return $"Item name : {itemName} | Item Mass: {itemMass}";
    }
}