namespace _6_2;

internal class DairyProducts : Product
{
    private string dairyProductType;
    
    public string DairyProductType
    {
        get { return dairyProductType;} set{if(string.IsNullOrEmpty(value)) dairyProductType = value;} 
    }
    public DairyProducts(string productName,int productCost,int productId,string productType,string razdelMagazin,string dairyProductType) : base(productName, productCost, productId, productType,razdelMagazin)
    {
        this.dairyProductType = dairyProductType;
    }

    public DairyProducts() : base()
    {
        dairyProductType = String.Empty;
    }

    public override string RazdelMagazin()
    {
        return $"razdelMagazin {razdelMagazin} - There can be different type of Dairy Products";
    }
    public override string ToString() {
        return base.ToString() + $" Dairy product Type : {dairyProductType}";
    }

    public override bool Equals(object obj){
        if(obj is DairyProducts){ return ToString().Equals(((DairyProducts)obj).ToString()); }
        return false;
    }

    public override int GetHashCode()
    {
        return ToString().GetHashCode();
    }
}