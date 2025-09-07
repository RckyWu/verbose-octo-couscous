using System;

namespace CrazyRisk.DataStructures;

public class MyQueue<T> : IMyQueue<T>
{
    private readonly IMyList<T> _list = new MyList<T>();
    public int Count => _list.Count;

    public void Enqueue(T item) => _list.Add(item);

    public T Dequeue()
    {
        if (Count == 0) throw new InvalidOperationException("Empty queue");
        var v = _list.Get(0);
        _list.RemoveAt(0);
        return v;
    }

    public T Peek()
    {
        if (Count == 0) throw new InvalidOperationException("Empty queue");
        return _list.Get(0);
    }
}
