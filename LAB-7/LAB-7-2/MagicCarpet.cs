namespace LAB_7_2;

public class MagicCarpet:Device,IDevice<MagicCarpet>,IEngine<MagicCarpet>,IComparable<MagicCarpet>
{
    private string vizerunok;
    private int howmanykebab;
    public int power { get; set; }
    public string engineType { get; set; }
    public int CompareTo(MagicCarpet other)
    {
        MagicCarpet temp = other as MagicCarpet;
        if (this.howmanykebab < temp.howmanykebab) return -1;
        if (this.howmanykebab > temp.howmanykebab) return 1;
        return 0;
    }
    public string DeviceInfo()
    {
        return $"Magic carpet is a flying mobile that works on power of balkanian kebab";
    }

    public string EngineInfo()
    {
        return $"Engine Power = {power} | Engine Type = {engineType}";
    }
    public MagicCarpet(string deviceType, string deviceName, double weight, string whereCreated, bool doesHaveEngine,
        bool isElectric, string vizerunok, int howmanykebab,int power,string engineType) : base(deviceType, deviceName, weight, whereCreated,
        doesHaveEngine, isElectric)
    {
        doesHaveEngine = true;
        isElectric = false;//Power of kebab only no electric
        this.vizerunok = vizerunok;
        this.howmanykebab = howmanykebab;
        this.power = power;
        this.engineType = engineType;

    }

    public MagicCarpet() : base()
    {
        vizerunok = "";
        howmanykebab = 0;
        power = 0;
        engineType = "";
    }

    public string VizerUnok
    {
        get { return vizerunok; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("vizerunok");
            }
            vizerunok = value;
        }
    }

    public int Howmanykebab
    {
        get { return howmanykebab; }
        set
        {
            if (!int.TryParse(value.ToString(), out int parsed))
            {
                throw new ArgumentException("howmanykebab");
            }
            howmanykebab = parsed;
        }
    }

    public override string ToString()
    {
        return base.ToString()+$" Vizerunok = {vizerunok} | Howmanykebab = {howmanykebab}";
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
        return new MagicCarpet(this.DeviceType,this.DeviceName,this.Weight,this.WhereCreated,this.HasEngine,this.FIsElectric,this.vizerunok,this.howmanykebab,this.power,this.engineType);
    }
}