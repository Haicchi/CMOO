namespace LAB_7_2;

public class Baloon:Device
{
    private string color;
    private string size;
    public Baloon() : base()
    {
        doesHaveEngine = false;
        isElectric = false;
        color = ""; 
        size = "";
    }

    public Baloon(string deviceType, string deviceName, double weight, string whereCreated,bool doesHaveEngine,bool isElectric,string color,string size) : base(deviceType,
        deviceName, weight, whereCreated, doesHaveEngine, isElectric)
    {
        this.color = color;
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

    public override string ToString()
    {
        return base.ToString()+$" ,Color={Color} | Size={Size}";
    }

    public override string IsElectric()
    {
        return base.IsElectric().ToString();
    }

    public override string DoesHaveEngine()
    {
        return base.DoesHaveEngine().ToString();   
    }
}