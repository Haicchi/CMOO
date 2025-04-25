namespace LAB_7_2;

public class Helicopter : Device
{
  private int maxspeed;
  private int maxHeight;

  public Helicopter() : base()
  {
    doesHaveEngine = true;
    isElectric = true;
    maxspeed = 0;
    maxHeight = 0;
  }

  public Helicopter(string deviceType, string deviceName, double weight, string whereCreated, bool doesHaveEngine,
    bool isElectric, int maxspeed, int maxHeight) : base(deviceType,deviceName, weight, whereCreated, doesHaveEngine, isElectric)
  {
    this.maxspeed = maxspeed;
    this.maxHeight = maxHeight;
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
}