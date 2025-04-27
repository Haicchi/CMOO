namespace LAB_7_2;

public static class Creator
{
    private static Random random = new Random();
    private static string[] deviceType = {"Plane","Helicopter","Baloon","Magic Carpet","Deltaplan"};
    private static string[] deviceName ={"Bubun","Ezarel","Rizrak","Kezz","Landscape"};
    private static double[] deviceWeight ={500,400,320,589,232,654,2341,786};
    private static string[] whereCreated = {"Ukraine","Sweden","Germany","ChechRepublic"};
    private static int[] capacity = {150,100,200};
    private static int[] kilkrabochix = {30,40,20,50};
    private static int[] maxSpeed = {100,120,80,140};
    private static int[] maxHeight = {700,600,560,650};
    private static double[] razmaxKrila = { 12.5,17.4,10.5}; 
    private static int[] maxWeight = {100,150,200,250};
    private static string[] color = {"Red","Blue","Green","Yellow","Magenta"};
    private static string[] size ={"Big","Medium","Small"};
    private static string[] vizerunok ={"Krap","Romb","Goldie","ICS","TOM"};
    private static int[] howManyKebab = { 1, 2, 3, 5, 7, 8, 4 };
    private static int[] power = { 50, 70, 120, 30, 40, 80 };
    private static string[] engineType = { "Heat engine","Hybrid engine","Desel engine","Kebab engine" };
    private static string[] partName = { "Wing","Panel","Door","Kyrban" };
    private static double[] partWeight = { 500, 400, 320, 589 };
    private static double[] volume = { 15, 23, 14, 11 };
    public static int RandomPower()
    {
        return power[random.Next(0,power.Length)];
    }

    public static double RandomVolume()
    {
        return volume[random.Next(0,volume.Length)];
    }

    public static double RandomPartWeight()
    {
        return partWeight[random.Next(0,partWeight.Length)];
    }

    public static string RandomPartName()
    {
        return partName[random.Next(0,partName.Length)];
    }

    public static string RandomEngineType()
    {
        return engineType[random.Next(0,engineType.Length)];
    }
    public static string RandomDeviceType()
    {
        return deviceType[random.Next(0, deviceType.Length)];
    } 
    public static string RandomDeviceName(){
        return deviceName[random.Next(0, deviceName.Length)];
    }

    public static double RandomDeviceWeight()
    {
        return deviceWeight[random.Next(0, deviceWeight.Length)];
    }

    public static string RandomWhereCreated()
    {
        return whereCreated[random.Next(0, whereCreated.Length)];
    }

    public static int RandomCapacity()
    {
        return capacity[random.Next(0, capacity.Length)];
    }

    public static int RandomKilkrabochix()
    {
        return kilkrabochix[random.Next(0, kilkrabochix.Length)];
    }

    public static int RandomMaxSpeed()
    {
        return maxSpeed[random.Next(0, maxSpeed.Length)];
    }

    public static int RandomMaxHeight()
    {
        return maxHeight[random.Next(0, maxHeight.Length)];
    }

    public static double RandomRazMaxKrila()
    {
        return razmaxKrila[random.Next(0, razmaxKrila.Length)];
    }

    public static int RandomMaxWeight()
    {
        return maxWeight[random.Next(0, maxWeight.Length)];
    }

    public static string RandomColor()
    {
        return color[random.Next(0, color.Length)];
    }

    public static string RandomSize()
    {
        return size[random.Next(0, size.Length)];
    }

    public static string RandomVizerunok()
    {
        return vizerunok[random.Next(0, vizerunok.Length)];
    }

    public static int RandomHowManyKebab()
    {
        return howManyKebab[random.Next(0, howManyKebab.Length)];
    }

    public static Device RandomDevice()
    {
        return new Device(RandomDeviceType(), RandomDeviceName(), RandomDeviceWeight(), RandomWhereCreated(),false,false);
    }

    public static Plane RandomPlane()
    {
        return new Plane(deviceType[0],RandomDeviceName(),RandomDeviceWeight(),RandomWhereCreated(),true,true,RandomCapacity(),RandomKilkrabochix(),RandomPower(),RandomEngineType(),RandomPartName(),RandomPartWeight());
    }

    public static Helicopter RandomHelicopter()
    {
        return new Helicopter(deviceType[1],RandomDeviceName(),RandomDeviceWeight(),RandomWhereCreated(),true,true,RandomMaxSpeed(),RandomMaxHeight(),RandomPower(),RandomEngineType(),RandomPartName(),RandomPartWeight());
    }

    public static Deltaplan RandomDeltaplan()
    {
        return new Deltaplan(deviceType[4],RandomDeviceName(),RandomDeviceWeight(),RandomWhereCreated(),false,true,RandomRazMaxKrila(),RandomMaxWeight(),RandomPartName(),RandomPartWeight());
    }

    public static Baloon RandomBaloon()
    {
        return new Baloon(deviceType[2],RandomDeviceName(),RandomDeviceWeight(),RandomWhereCreated(),false,false,RandomColor(),RandomVolume(),RandomSize());
        
    }

    public static MagicCarpet RandomMagicCarpet()
    {
        return new MagicCarpet(deviceType[3],RandomDeviceName(),RandomDeviceWeight(),RandomWhereCreated(),true,false,RandomVizerunok(),RandomHowManyKebab(),RandomPower(),RandomEngineType());
    }
    
}