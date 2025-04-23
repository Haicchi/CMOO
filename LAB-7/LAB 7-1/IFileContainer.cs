using System.ComponentModel;

namespace LAB_7_1;

public interface IFileContainer<T> : IContainer<T>
{
    void Save(string fileName);
    void Load(string fileName);
    Boolean IsDataSaved { get; }
}