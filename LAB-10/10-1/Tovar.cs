namespace _10_1;

public class Tovar
{
    private string tovarName;
    private Shop[] shops;

    public Tovar(string tovarName, Shop[] shops)
    {
        this.tovarName = tovarName;
        this.shops = shops;
    }

    public Tovar()
    {
        tovarName = "";
        shops = new Shop[0];
    }

    public Shop[] Shops
    {
        get { return shops; }
        set { shops = value; }
    }

    public string TovarName
    {
        get { return tovarName; }
        set { tovarName = value; }
    }

    public override string ToString()
    {
        string shoplist = "";
        foreach (Shop shop in shops)
        {
            shoplist += shop.ToString() + " |";
        }
        return $"Tovar: {tovarName} | Shops: {shoplist}";
    }

}