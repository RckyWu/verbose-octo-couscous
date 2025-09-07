using System;
using System.Collections.Generic;

namespace CrazyRisk.DataStructures;

public class MyList<T> : IMyList<T>
{
    private class Node
    {
        public T Value;
        public Node? Next;
        public Node(T v) { Value = v; }
    }

    private Node? _head;
    private int _count;
    public int Count => _count;

    public void Add(T item)
    {
        var n = new Node(item);
        if (_head is null) { _head = n; _count = 1; return; }
        var cur = _head;
        while (cur.Next != null) cur = cur.Next;
        cur.Next = n;
        _count++;
    }

    public void Insert(int index, T item)
    {
        if (index < 0 || index > _count) throw new ArgumentOutOfRangeException(nameof(index));
        var n = new Node(item);
        if (index == 0)
        {
            n.Next = _head;
            _head = n;
            _count++;
            return;
        }
        var prev = GetNode(index - 1);
        n.Next = prev.Next;
        prev.Next = n;
        _count++;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= _count) throw new ArgumentOutOfRangeException(nameof(index));
        if (index == 0)
        {
            _head = _head!.Next;
            _count--;
            return;
        }
        var prev = GetNode(index - 1);
        prev.Next = prev.Next!.Next;
        _count--;
    }

    public T Get(int index) => GetNode(index).Value;

    public void Set(int index, T value) => GetNode(index).Value = value;

    public int IndexOf(T item)
    {
        var cur = _head;
        int i = 0;
        var cmp = EqualityComparer<T>.Default;
        while (cur != null)
        {
            if (cmp.Equals(cur.Value, item)) return i;
            cur = cur.Next;
            i++;
        }
        return -1;
    }

    private Node GetNode(int index)
    {
        if (index < 0 || index >= _count) throw new ArgumentOutOfRangeException(nameof(index));
        var cur = _head!;
        for (int i = 0; i < index; i++) cur = cur.Next!;
        return cur;
    }
}
