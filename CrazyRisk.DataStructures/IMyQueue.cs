using System;

namespace CrazyRisk.DataStructures;

/// <summary>
/// Representa el contrato mínimo de una cola genérica de primer en entrar, primero en salir (FIFO).
/// </summary>
public interface IMyQueue<T>
{
    /// <summary>
    /// Obtiene la cantidad de elementos almacenados actualmente en la cola.
    /// </summary>
    int Count { get; }

    /// <summary>
    /// Agrega un elemento al final de la cola.
    /// </summary>
    void Enqueue(T item);

    /// <summary>
    /// Quita y devuelve el elemento que se encuentra al frente de la cola.
    /// </summary>
    /// <exception cref="InvalidOperationException">Se lanza si la cola está vacía.</exception>
    T Dequeue();

    /// <summary>
    /// Devuelve el elemento que está al frente sin retirarlo de la cola.
    /// </summary>
    /// <exception cref="InvalidOperationException">Se lanza si la cola está vacía.</exception>
    T Peek();
}