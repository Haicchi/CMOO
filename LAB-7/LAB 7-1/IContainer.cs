using System.Collections;

namespace LAB_7_1;

public interface IContainer
{
    int Count { get; }
    Object this[ int index ] { get;set;}

    void Add(Object element);
    void Delete(Object element);
    
}