using System;
using System.Collections.Generic;

namespace CrazyRisk.DataStructures;

/// <summary>
/// Implementación de <see cref="IMyList{T}"/> mediante una lista simplemente enlazada.
/// </summary>
public class MyList<T> : IMyList<T>
{
    /// <summary>
    /// Representa un nodo de la lista simplemente enlazada.
    /// </summary>
    private class Node
    {
        public T Value;
        public Node? Next;
        public Node(T v) { Value = v; }
    }

    private Node? _head;
    private int _count;

    /// <summary>
    /// Obtiene el número de elementos almacenados actualmente en la lista.
    /// </summary>
    public int Count => _count;

    /// <summary>
    /// Agrega un elemento al final de la lista.
    /// </summary>
    /// <param name="item">Elemento que se va a agregar.</param>
    public void Add(T item)
    {
        // Create a new node that will hold the item being appended.
        Node newNode = new Node(item);

        // If the list is currently empty, make the new node the head and update the count.
        if (_head is null)
        {
            _head = newNode;
            _count++;
            return;
        }

        // Otherwise, traverse to the last node in the list.
        Node currentNode = _head;
        while (currentNode.Next is not null)
        {
            currentNode = currentNode.Next;
        }

        // Link the last node to the new node and adjust the count.
        currentNode.Next = newNode;
        _count++;
    }

    /// <summary>
    /// Inserta un elemento en la posición especificada.
    /// </summary>
    /// <param name="index">Índice en el que se insertará el elemento.</param>
    /// <param name="item">Elemento que se va a insertar.</param>
    /// <exception cref="System.ArgumentOutOfRangeException">
    /// Se produce cuando <paramref name="index"/> es menor que cero o mayor que <see cref="Count"/>.
    /// </exception>
    
    public void Insert(int index, T item)
    {
        if (index < 0 || index > _count) throw new ArgumentOutOfRangeException(nameof(index));

        // Prepare the node that will be inserted at the given index.
        Node newNode = new Node(item);

        // Inserting at the head requires updating the head pointer directly.
        if (index == 0)
        {
            newNode.Next = _head;
            _head = newNode;
            _count++;
            return;
        }

        // Otherwise find the node currently before the target index.
        Node previousNode = GetNode(index - 1);

        // Insert the new node by re-linking the surrounding nodes.
        newNode.Next = previousNode.Next;
        previousNode.Next = newNode;
        _count++;
    }

    /// <summary>
    /// Elimina el elemento ubicado en el índice especificado.
    /// </summary>
    /// <param name="index">Índice del elemento que se desea eliminar.</param>
    /// <exception cref="System.ArgumentOutOfRangeException">
    /// Se produce cuando <paramref name="index"/> está fuera del rango válido de la lista.
    /// </exception>
    public void RemoveAt(int index)
    {
        if (index < 0 || index >= _count) throw new ArgumentOutOfRangeException(nameof(index));

        // Removing the head requires shifting the head pointer forward.
        if (index == 0)
        {
            _head = _head!.Next;
            _count--;
            return;
        }

        // Otherwise find the node prior to the one being removed.
        Node previousNode = GetNode(index - 1);

        // Skip over the node at the specified index and update the count.
        previousNode.Next = previousNode.Next!.Next;
        _count--;
    }

    /// <summary>
    /// Obtiene el elemento que se encuentra en el índice indicado.
    /// </summary>
    /// <param name="index">Índice del elemento que se desea recuperar.</param>
    /// <returns>El elemento almacenado en la posición indicada.</returns>
    /// <exception cref="System.ArgumentOutOfRangeException">
    /// Se produce cuando <paramref name="index"/> está fuera del rango válido de la lista.
    /// </exception>
    public T Get(int index)
    {
        // Retrieve the node at the desired index before reading its value.
        Node nodeAtIndex = GetNode(index);
        return nodeAtIndex.Value;
    }

    /// <summary>
    /// Reemplaza el valor del elemento en el índice indicado.
    /// </summary>
    /// <param name="index">Índice del elemento que se desea modificar.</param>
    /// <param name="value">Valor que se asignará al elemento en la posición indicada.</param>
    /// <exception cref="System.ArgumentOutOfRangeException">
    /// Se produce cuando <paramref name="index"/> está fuera del rango válido de la lista.
    /// </exception>
    public void Set(int index, T value)
    {
        // Retrieve the node at the desired index before updating its value.
        Node nodeAtIndex = GetNode(index);
        nodeAtIndex.Value = value;
    }

    /// <summary>
    /// Busca la primera aparición del elemento especificado en la lista.
    /// </summary>
    /// <param name="item">Elemento que se desea buscar.</param>
    /// <returns>El índice de la primera coincidencia o -1 si el elemento no se encuentra.</returns>
    public int IndexOf(T item)
    {
        var cur = _head;
        int i = 0;
        var cmp = EqualityComparer<T>.Default;
        while (cur != null)
        {
            if (cmp.Equals(cur.Value, item)) return i;
            // Move to the next node in the sequence and advance the index counter.
            cur = cur.Next;
            i++;
        }
        return -1;
    }

    /// <summary>
    /// Recupera el nodo interno ubicado en el índice indicado.
    /// </summary>
    /// <param name="index">Índice del nodo que se desea obtener.</param>
    /// <returns>El nodo correspondiente a la posición indicada.</returns>
    /// <exception cref="System.ArgumentOutOfRangeException">
    /// Se produce cuando <paramref name="index"/> está fuera del rango válido de la lista.
    /// </exception>
    private Node GetNode(int index)
    {
        if (index < 0 || index >= _count) throw new ArgumentOutOfRangeException(nameof(index));

        // Ensure the requested index is within bounds before walking the list.

        // Start from the head and walk forward until reaching the desired index.
        var cur = _head!;
        for (int i = 0; i < index; i++)
        {
            // Advance to the next node for each step closer to the target index.
            cur = cur.Next!;
        }
        return cur;
    }
}
