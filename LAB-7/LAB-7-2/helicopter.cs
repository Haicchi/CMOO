namespace LAB_7_2;

public class Helicopter : Device,IDevice<Helicopter>,IEngine<Helicopter>,IPart<Helicopter>,IComparable<Helicopter>
{
  private int maxspeed;
  private int maxHeight;
  public int power { get; set; }
  public string engineType { get; set; }
  public string EngineInfo()
  {
    return $"Engine Power = {power} | Engine Type = {engineType}";
  }
  public int CompareTo(Helicopter other)
  {
    Helicopter temp = other as Helicopter;
    if (this.maxspeed < temp.maxspeed) return -1;
    if (this.maxspeed > temp.maxspeed) return 1;
    return 0;
  }

  public string partName { get; set; }
  public double partWeight { get; set; }
  public string PartInfo()
  {
    return $"Part Name: {partName} | Part Weight = {partWeight}";
  }


  public Helicopter() : base()
  {
    doesHaveEngine = true;
    isElectric = true;
    maxspeed = 0;
    maxHeight = 0;
    power = 0;
    engineType = "";
    partName = "";
    partWeight = 0;
  }

  public Helicopter(string deviceType, string deviceName, double weight, string whereCreated, bool doesHaveEngine,
    bool isElectric, int maxspeed, int maxHeight,int power,string engineType,string partName,double partWeight) : base(deviceType,deviceName, weight, whereCreated, doesHaveEngine, isElectric)
  {
    this.maxspeed = maxspeed;
    this.maxHeight = maxHeight;
    this.power = power;
    this.engineType = engineType;
    this.partName = partName;
    this.partWeight = partWeight;
  }

  public int MaxSpeed
  {
    get{return maxspeed;}
    set
    {
      if (!int.TryParse(value.ToString(), out int parsed))
      {
        throw new ArgumentException("Invalid capacity");
      }
      maxspeed = parsed;
    }
  }
  public int MaxHeight
  {
    get{return maxHeight;}
    set
    {
      if (!int.TryParse(value.ToString(), out int parsed))
      {
        throw new Exception("Max Height must be an integer");
      }
      maxHeight = parsed;
    }
  }

  public override string ToString()
  {
    return base.ToString() + $"  MaxSpeed={maxspeed} | MaxHeight={maxHeight}";
  }

  public override string IsElectric()
  {
    return isElectric.ToString();
  }

  public override string DoesHaveEngine()
  {
    return doesHaveEngine.ToString();
  }

  public string DeviceInfo()
  {
    return $"A helicopter is a type of rotorcraft in which lift and thrust are supplied by horizontally spinning rotors.";
  }

  public object Clone()
  {
    return new Helicopter(this.DeviceType,this.DeviceName,this.Weight,this.WhereCreated,this.HasEngine,this.FIsElectric,this.maxspeed,this.maxHeight,this.power,this.engineType,this.partName,this.partWeight);
  }
}