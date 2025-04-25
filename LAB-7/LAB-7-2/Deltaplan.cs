namespace LAB_7_2;

public class Deltaplan:Device
{
    private double razmaxkrila;
    private int maxweight;

    public Deltaplan(string deviceType, string deviceName, double weight, string whereCreated, bool doesHaveEngine,
        bool isElectric, double razmaxkrila, int maxweight) : base(deviceType, deviceName, weight, whereCreated,
        doesHaveEngine, isElectric)
    {
        this.razmaxkrila = razmaxkrila;
        this.maxweight = maxweight;
    }

    public Deltaplan() : base()
    {
        doesHaveEngine = false;
        isElectric = true;
        razmaxkrila = 0.0;
        maxweight = 0;
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
}