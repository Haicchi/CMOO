namespace LAB_7_2;

public class Device
{
    private string deviceType;
    private string deviceName;
    private double weight;
    private string whereCreated;
    protected bool doesHaveEngine;
    protected bool isElectric;
    public Device(string deviceType, string deviceName, double weight, string whereCreated, bool doesHaveEngine, bool isElectric)
    {
        this.deviceType = deviceType;
        this.deviceName = deviceName;
        this.weight = weight;
        this.whereCreated = whereCreated;
        this.doesHaveEngine = doesHaveEngine;
        this.isElectric = isElectric;
        
    }

    public Device()
    {
        deviceType = "";
        deviceName = "";
        weight = 0;
        whereCreated = "";
        doesHaveEngine = false;
        isElectric = false;
    }

    public string DeviceType
    {
        get { return deviceType; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Device type cannot be null or empty.");
            }
            deviceType = value;
        }
    }
    public string DeviceName
    {
        get { return deviceName; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Device type cannot be null or empty.");
            }
            deviceName = value;
        }
    }

    public double Weight
    {
        get { return weight; }
        set{
            if (!double.TryParse(value.ToString(), out double parsed))
            {
                throw new ArgumentException("Weight must be a number greater than zero.");
                
            }
            weight = parsed;
        }
    }
    public string WhereCreated
    {
        get { return whereCreated; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Device type cannot be null or empty.");
            }
            whereCreated = value;
        }
    }

    public bool HasEngine
    {
        get { return doesHaveEngine; }
        set
        {
            if (value != true | value != false)
            {
                throw new ArgumentException("Device type cannot be 1 or 0.");
            }
        doesHaveEngine = value;
        }
    }

    public bool FIsElectric
    {
        get { return isElectric; }
        set
        {
            if (value != true | value != false)
            {
                throw new ArgumentException("Device type cannot be 1 or 0.");
            }
            isElectric = value;
        }
    }

    public override string ToString()
    {
        return $"Device Type ={deviceType} | Device Name ={deviceName} | Weight ={weight}  | WhereCreated ={whereCreated} | DoesHaveEngine ={doesHaveEngine} | IsElectric ={isElectric}"; 
        
    }

    public virtual string DoesHaveEngine()
    {
        return "Smth";
    }

    public virtual string IsElectric()
    {
        return "Smth";
    }
    
}