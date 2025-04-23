using System.Collections;



namespace LAB_7_1;

public interface IContainer<T>
{
    int Count { get; }
    T this[int index] { get; set; }

    void Add(T element);
    void Delete(T element);

}