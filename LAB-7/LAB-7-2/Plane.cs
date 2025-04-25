namespace LAB_7_2;

public class Plane:Device
{
    private int capacity;
    private int kilkrabochix;

    public Plane() : base()
    {
        doesHaveEngine = true;
        isElectric = true;
        capacity = 0;
        kilkrabochix = 0;
    }

    public Plane(string deviceType, string deviceName, double weight, string whereCreated,bool doesHaveEngine,bool isElectric,int capacity,int kilkrabochix) : base(deviceType,
        deviceName, weight, whereCreated, doesHaveEngine, isElectric)
    {
        this.capacity = capacity;
        this.kilkrabochix = kilkrabochix;
    }

    public int Capacity
    {
        get { return capacity; }
        set
        {
            if (!int.TryParse(value.ToString(), out int parsed))
            {
                throw new ArgumentException("Invalid capacity");
            }
            capacity = parsed;
        }
    }
    public int Kilkrabochix
    {
        get { return kilkrabochix; }
        set
        {
            if (!int.TryParse(value.ToString(), out int parsed))
            {
                throw new ArgumentException("Invalid capacity");
            }
            kilkrabochix = parsed;
        }
    }

    public override string ToString()
    {
        return base.ToString() + $" Capacity = {capacity} | Kilkrabochix = {kilkrabochix}";
    }

    public override string DoesHaveEngine()
    {
        return doesHaveEngine.ToString();
    }

    public override string IsElectric()
    {
        return isElectric.ToString();
    }
}