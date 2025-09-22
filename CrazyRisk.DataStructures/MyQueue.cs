using System;

namespace CrazyRisk.DataStructures;

public class MyQueue<T> : IMyQueue<T>
{
    // Lista interna que almacena los elementos en el orden en que se agregan.
    private readonly IMyList<T> _list = new MyList<T>();
    // Expone cuántos elementos hay actualmente en la cola.
    public int Count
    {
        get
        {
            return _list.Count;
        }
    }
    // Inserta un nuevo elemento al final de la cola para respetar el orden FIFO.
    public void Enqueue(T item)
    {
        _list.Add(item);
    }
    // Quita y devuelve el elemento más antiguo de la cola.
    public T Dequeue()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("Empty queue");
        }
        // El primer elemento del respaldo interno es el siguiente en salir.

        var v = _list.Get(0);

        // Después de devolverlo se elimina para mantener la cola sincronizada.
        _list.RemoveAt(0);

        return v;
    }
    // Permite ver el elemento que sería devuelto por Dequeue sin retirarlo.
    public T Peek()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("Empty queue");
        }

        return _list.Get(0);
    }
}
