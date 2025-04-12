namespace _6_2;

internal class Cheese:Product
{
    public string cheeseType;
    
    public string CheeseType
    {
        get { return cheeseType;} set{if(string.IsNullOrEmpty(value)) cheeseType = value;}
        
    }

    public Cheese():base()
    {
        cheeseType = String.Empty;
    }
    public Cheese(string productName,int productCost,int productId,string productType,string razdelMagazin,string cheeseType) : base(productName, productCost, productId, productType,razdelMagazin)
    {
        this.cheeseType = cheeseType;
    }

    public override string RazdelMagazin()
    {
        return $"razdelMagazin {razdelMagazin} - There can be different type of cheese";
    }
    public override string ToString() {
        return base.ToString() + $"  Cheese Type : {cheeseType}";
    }

    public override bool Equals(object obj){
        if(obj is Cheese){ return ToString().Equals(((Cheese)obj).ToString()); }
        return false;
    }

    public override int GetHashCode()
    {
        return ToString().GetHashCode();
    }
}