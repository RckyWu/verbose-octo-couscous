using System;

namespace CrazyRisk.DataStructures;

public class MyStack<T> : IMyStack<T>
{
    // Lista que respalda la pila almacenando los elementos apilados.
    private readonly IMyList<T> _list = new MyList<T>();
    // Cantidad total de elementos disponibles en la pila.
    public int Count
    {
        get
        {
            return _list.Count;
        }
    }

    // Agrega un elemento en la parte superior de la pila para que sea el próximo en salir.
    public void Push(T item)
    {
        _list.Add(item);
    }

    // Quita y devuelve el elemento más reciente agregado a la pila.
    public T Pop()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("Empty stack");
        }

        // El índice Count - 1 representa la cima actual de la pila.
        var val = _list.Get(Count - 1);

        // Eliminamos el elemento para ajustar la pila después de devolverlo.
        _list.RemoveAt(Count - 1);

        return val;
    }
    // Devuelve el elemento del tope sin retirarlo, para solo inspeccionarlo.
    public T Peek()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("Empty stack");
        }

        return _list.Get(Count - 1);
    }
}
