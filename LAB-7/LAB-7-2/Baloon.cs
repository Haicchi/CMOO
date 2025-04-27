namespace LAB_7_2;

public class Baloon:Device,IDevice<Baloon>,IComparable<Baloon>
{
    private string color;
    private double volume;
    private string size;
    public Baloon() : base()
    {
        doesHaveEngine = false;
        isElectric = false;
        color = ""; 
        volume = 0;
        size = "";
    }
    public int CompareTo(Baloon other)
    {
        Baloon temp = other as Baloon;
        if (this.volume < temp.volume) return -1;
        if (this.volume > temp.volume) return 1;
        return 0;
    }

    public string DeviceInfo()
    {
        return $"A balloon is a flexible membrane bag that can be inflated with a gas";
    }

    public Baloon(string deviceType, string deviceName, double weight, string whereCreated,bool doesHaveEngine,bool isElectric,string color,double volume,string size) : base(deviceType,
        deviceName, weight, whereCreated, doesHaveEngine, isElectric)
    {
        this.color = color;
        this.volume = volume;
        this.size = size;
    }

    public string Color
    {
        get{return color;}
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Color cannot be null or empty");
            }
            color = value;
        }
    }
    public string Size
    {
        get{return size;}
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Color cannot be null or empty");
            }
            size = value;
        }
    }

    public double Volume
    {
        get{return volume;}
        set{
            if (!double.TryParse(value.ToString(), out double parsed))
            {
                throw new Exception("Volume must be a number");
            }
            volume = parsed
                ;}
    }

    public override string ToString()
    {
        return base.ToString()+$" ,Color={Color} | Volume = {volume} | Size={Size}";
    }

    public override string IsElectric()
    {
        return base.IsElectric().ToString();
    }

    public override string DoesHaveEngine()
    {
        return base.DoesHaveEngine().ToString();   
    }

    public object Clone()
    {
        return new Baloon(this.DeviceType,this.DeviceName,this.Weight,this.WhereCreated,this.HasEngine,this.FIsElectric,this.color,this.volume,this.size);
    }
}