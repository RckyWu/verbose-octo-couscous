using System;

namespace CrazyRisk.DataStructures;

public class MyStack<T> : IMyStack<T>
{
    private readonly IMyList<T> _list = new MyList<T>();
    public int Count => _list.Count;

    public void Push(T item) => _list.Add(item);

    public T Pop()
    {
        if (Count == 0) throw new InvalidOperationException("Empty stack");
        var val = _list.Get(Count - 1);
        _list.RemoveAt(Count - 1);
        return val;
    }

    public T Peek()
    {
        if (Count == 0) throw new InvalidOperationException("Empty stack");
        return _list.Get(Count - 1);
    }
}
