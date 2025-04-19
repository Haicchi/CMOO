using System.ComponentModel;

namespace LAB_7_1;

public interface IFileContainer:IContainer
{
    void  Save(string fileName);
    void  Load(string fileName);
    Boolean IsDataSaved { get; }
}