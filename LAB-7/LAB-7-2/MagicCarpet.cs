namespace LAB_7_2;

public class MagicCarpet:Device
{
    private string vizerunok;
    private int howmanykebab;

    public MagicCarpet(string deviceType, string deviceName, double weight, string whereCreated, bool doesHaveEngine,
        bool isElectric, string vizerunok, int howmanykebab) : base(deviceType, deviceName, weight, whereCreated,
        doesHaveEngine, isElectric)
    {
        doesHaveEngine = true;
        isElectric = false;//Power of kebab only no electric
        this.vizerunok = vizerunok;
        this.howmanykebab = howmanykebab;

    }

    public MagicCarpet() : base()
    {
        vizerunok = "";
        howmanykebab = 0;
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
}