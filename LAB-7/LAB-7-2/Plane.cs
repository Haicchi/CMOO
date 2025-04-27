namespace LAB_7_2;

public class Plane:Device,IDevice<Plane>,IEngine<Plane>,IPart<Plane>,IComparable<Plane>
{
    private int capacity;
    private int kilkrabochix;
   
    public int power { get; set; }
    public string engineType { get; set; }
    public string partName{get;set;}
    public double partWeight { get; set; }
    public Plane() : base()
    {
        doesHaveEngine = true;
        isElectric = true;
        capacity = 0;
        kilkrabochix = 0;
        power = 0;
        engineType = "";
        partName = "";
        partWeight = 0;
        
    }

    public Plane(string deviceType, string deviceName, double weight, string whereCreated,bool doesHaveEngine,bool isElectric,int capacity,int kilkrabochix,int power,string engineType,string partName,double partWeight) : base(deviceType,
        deviceName, weight, whereCreated, doesHaveEngine, isElectric)
    {
        this.capacity = capacity;
        this.kilkrabochix = kilkrabochix;
        this.power = power;
        this.engineType = engineType;
        this.partName = partName;
        this.partWeight = partWeight;
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

    public int CompareTo(Plane other)
    {
        Plane temp = other as Plane;
        if (this.capacity < temp.capacity) return -1;
        if (this.capacity > temp.capacity) return 1;
        return 0;
    }

    public override string ToString()
    {
        return base.ToString() + $" Capacity = {capacity} | Kilkrabochix = {kilkrabochix} |  Power = {power} | EngineType = {engineType}";
    }

    public override string DoesHaveEngine()
    {
        return doesHaveEngine.ToString();
    }

    public override string IsElectric()
    {
        return isElectric.ToString();
    }

    public string DeviceInfo()
    {
        return $"Самолёт — класс воздушных судов тяжелее воздуха, предназначенных для полётов в атмосфере с помощью силового агрегата, создающего тягу и неподвижного относительно других частей аппарата крыла, создающего подъёмную силу.";
    }

    public string EngineInfo()
    {
        return $"Engine Power = {power} | Engine Type = {engineType}";
    }

    public string PartInfo()
    {
        return $"Part Name: {partName} | Part Weight = {partWeight}";
    }

    public object Clone()
    {
        return new Plane(this.DeviceType,this.DeviceName,this.Weight,this.WhereCreated,this.HasEngine,this.FIsElectric,this.capacity,this.kilkrabochix,this.power,this.engineType,this.partName,this.partWeight);
    }
}