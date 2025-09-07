namespace CrazyRisk.DataStructures;

public interface IMyStack<T>
{
    int Count { get; }
    void Push(T item);
    T Pop();   // lanza InvalidOperationException si está vacío
    T Peek();  // lanza InvalidOperationException si está vacío
}
