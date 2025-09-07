namespace CrazyRisk.DataStructures;

public interface IMyList<T>
{
    int Count { get; }
    void Add(T item);
    void Insert(int index, T item);
    void RemoveAt(int index);
    T Get(int index);
    void Set(int index, T value);
    int IndexOf(T item);
}
