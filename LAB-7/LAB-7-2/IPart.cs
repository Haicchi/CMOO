namespace LAB_7_2;

public interface IPart<T>
{
    string partName{get;set;}
    double partWeight { get; set; }
    string PartInfo();
}