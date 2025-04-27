using System.Runtime.InteropServices;

namespace LAB_7_2;

class Program
{
    static void Main(string[] args)
    {
        Plane obj = Creator.RandomPlane();
        Plane ob2 = Creator.RandomPlane();
        Console.WriteLine(obj.ToString());
        Console.WriteLine(ob2.ToString());
        Plane ob3 = obj.Clone() as Plane;
        Console.WriteLine(ob3.ToString());
        Console.WriteLine(obj.CompareTo(ob2));
        Console.WriteLine("Normal task");
        Device[] devices = {Creator.RandomPlane(),Creator.RandomPlane(),Creator.RandomHelicopter(),Creator.RandomHelicopter(),Creator.RandomBaloon(),Creator.RandomBaloon(),Creator.RandomDeltaplan(),Creator.RandomDeltaplan(),Creator.RandomMagicCarpet(),Creator.RandomMagicCarpet()};
        
        Registr.Print(devices);
        Console.WriteLine("Sorted");
        Registr.Sort(devices);
        Registr.Print(devices);
        Registr.AddDevice(ref devices,Creator.RandomBaloon());
        Console.WriteLine("addded element");
        Registr.Print(devices); 
        Console.WriteLine("posledi udalil");
        Registr.Delete(ref devices,devices[devices.Length-1]);
        Registr.Print(devices);
        Console.WriteLine("Electical devices");
        Registr.PrintElectical(devices);
        Console.WriteLine("Devices that dont have engine");
        Registr.PrintWithoutEngine(devices);
        Console.WriteLine("Part Print");
        Registr.PrintDevicePart(devices);
        Console.WriteLine("Sorted by name");
        Registr.SortByName(devices);
        Registr.Print(devices);
    }   
}