using System;

namespace CrazyRisk.DataStructures;

/// <summary>
/// Define las operaciones básicas de una pila genérica con comportamiento LIFO.
/// </summary>
public interface IMyStack<T>
{
    /// <summary>
    /// Obtiene el número de elementos apilados actualmente.
    /// </summary>
    int Count { get; }

    /// <summary>
    /// Coloca un elemento en la parte superior de la pila.
    /// </summary>
    void Push(T item);

    /// <summary>
    /// Extrae y devuelve el elemento ubicado en la cima de la pila.
    /// </summary>
    /// <exception cref="InvalidOperationException">Se lanza si la pila está vacía.</exception>
    T Pop();

    /// <summary>
    /// Permite inspeccionar el elemento superior sin retirarlo.
    /// </summary>
    /// <exception cref="InvalidOperationException">Se lanza si la pila está vacía.</exception>
    T Peek();
}