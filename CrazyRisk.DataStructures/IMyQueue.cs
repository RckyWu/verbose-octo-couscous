namespace CrazyRisk.DataStructures;

public interface IMyQueue<T>
{
    int Count { get; }
    void Enqueue(T item);
    T Dequeue(); // lanza InvalidOperationException si está vacío
    T Peek();    // lanza InvalidOperationException si está vacío
}
