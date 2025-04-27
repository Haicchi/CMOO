using System.Threading.Channels;

namespace LAB_7_2;

public static class Registr
{
    private static Device[] devices;

    public static void AddDevice(ref Device[]devices,Device device)
    {
        Array.Resize(ref devices, devices.Length + 1);
        devices[devices.Length - 1] = device;
    }
    public static void Delete(ref Device []devices,Device device)
    {
        Device[] temp = new Device[devices.Length - 1];
        int index = Array.IndexOf(devices, device);
        if (index == null)
        {
            Console.WriteLine("Cannot delete null element");
        
        }
        
        for (int i = 0; i < devices.Length; i++)
        {
            if (i != index)
            {
                temp[i] = devices[i];
                
            }
        }
        
        devices = temp;
        
        
    }

    public static void Sort(Device[] devices)
    {
        Array.Sort(devices);
    }

    public static void Print(Device[] devices)
    {
        for (int i = 0; i < devices.Length; i++)
        {
            Console.WriteLine(devices[i].ToString());
        }
    }

    public static void PrintElectical(Device[] devices)
    {
        for (int i = 0; i < devices.Length; i++)
        {
            if (devices[i].FIsElectric == true)
            {
                Console.WriteLine(devices[i].ToString());

            }
        }
    }
    public static int Compare(Device x, Device y){
        return x.DeviceName.Length.CompareTo(y.DeviceName.Length);
    }

    public static void SortByName(Device[] devices)
    {
        Array.Sort(devices, Compare);
    }

    public static void PrintWithoutEngine(Device[] devices)
    {
        for (int i = 0; i < devices.Length; i++)
        {

            if (devices[i].HasEngine == false)
            {
                Console.WriteLine(devices[i].ToString());
            }
        }
    }

    public static void PrintDeviceInfoFromWiki(Device[] devices)
    {
        for (int i = 0; i < devices.Length; i++)
        {
            Console.WriteLine(devices[i].DeviceInfo());
        }
    }

    public static void PrintDevicePart(Device[] devices)
    {
        for (int i = 0; i < devices.Length; i++)
        {
            if (devices[i] is Plane plane)
            {
                Console.WriteLine($"Part info {plane.PartInfo()}");
            }
            else if (devices[i] is Helicopter helicopter)
            {
                Console.WriteLine($"Part info {helicopter.PartInfo()}");
            }
            else if (devices[i] is Deltaplan deltaplan)
            {
                Console.WriteLine($"Part info {deltaplan.PartInfo()}");
            }
            else
            {
                Console.WriteLine($"This device has no part");
            }
            
        }
        
        
        
    }
    

}