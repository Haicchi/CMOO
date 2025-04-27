namespace LAB_7_2;

public class Deltaplan:Device,IDevice<Deltaplan>,IPart<Deltaplan>,IComparable<Deltaplan>
{
    private double razmaxkrila;
    private int maxweight;
    public string partName { get; set; }
    public double partWeight { get; set; }
    public string DeviceInfo()
    {
        return $"the activity of flying through the air by hanging from a very small aircraft without an engine";
    }
    public int CompareTo(Deltaplan other)
    {
        Deltaplan temp = other as Deltaplan;
        if (this.maxweight < temp.maxweight) return -1;
        if (this.maxweight > temp.maxweight) return 1;
        return 0;
    }
    public string PartInfo()
    {
        return $"Part Name: {partName} | Part Weight = {partWeight}";
    }

    public Deltaplan(string deviceType, string deviceName, double weight, string whereCreated, bool doesHaveEngine,
        bool isElectric, double razmaxkrila, int maxweight,string partName,double partWeight) : base(deviceType, deviceName, weight, whereCreated,
        doesHaveEngine, isElectric)
    {
        this.razmaxkrila = razmaxkrila;
        this.maxweight = maxweight;
        this.partName = partName;
        this.partWeight = partWeight;
    }

    public Deltaplan() : base()
    {
        doesHaveEngine = false;
        isElectric = true;
        razmaxkrila = 0.0;
        maxweight = 0;
        partName = "";
        partWeight = 0.0;
    }

    public double Razmaxkrila
    {
        get { return razmaxkrila; }
        set
        {
            if (!double.TryParse(value.ToString(), out double parsed))
            {
                throw new ArgumentException("Razmaxkrila must be a number");
            }
            razmaxkrila = parsed;
        }
    }

    public int MaxWeight
    {
        get { return maxweight; }
        set
        {
            if (!int.TryParse(value.ToString(), out int parsed))
            {
                throw new ArgumentException("MaxWeight must be a number");
            }
            maxweight = parsed;
            
        }
    }

    public override string ToString()
    {
        return base.ToString()+$" Razmaxkrila = {razmaxkrila} | MaxWeight = {maxweight}";
    }

    public override string DoesHaveEngine()
    {
        return base.DoesHaveEngine().ToString();
    }

    public override string IsElectric()
    {
        return base.IsElectric().ToString();
    }

    public object Clone()
    {
        return new Deltaplan(this.DeviceType,this.DeviceName,this.Weight,this.WhereCreated,this.HasEngine,this.FIsElectric,this.razmaxkrila,this.maxweight,this.partName,this.partWeight);
    }
}