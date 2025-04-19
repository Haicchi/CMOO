namespace LAB_7_1;
public class Modul:IComparable,ICloneable
     {
         public Person ProjectKer { get; set; }
         public string modulName { get; set; }
         public double modulCap { get; set; }

    public Modul(Person PersonKer, string ModulName, double ModulCap)
    {
        ProjectKer = PersonKer;
        modulName = ModulName;
        modulCap = ModulCap;
    }

    public Modul()
    {
        ProjectKer = null;
        modulName = null;
        modulCap = 0.0;
    }

        

    override public string ToString()
    {
        return "Person: " + ProjectKer.Firstname + " " + ProjectKer.Lastname + " ModulName: " + modulName + " ModulCap: " + modulCap;
    }

    public int CompareTo(object obj)
    {
        Modul temp = (Modul)obj;
        if (this.modulCap < temp.modulCap) return -1;
        if (this.modulCap > temp.modulCap) return 1;
        return 0;
    }

    public object Clone()
    {
        return new Modul
        {
            ProjectKer = this.ProjectKer,
            modulCap = this.modulCap,
            modulName = this.modulName

        };

    }
}