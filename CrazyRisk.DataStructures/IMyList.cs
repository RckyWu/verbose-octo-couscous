namespace CrazyRisk.DataStructures;


/// <summary>
/// Define las operaciones básicas de una lista genérica.
/// </summary>
public interface IMyList<T>
{

    /// <summary>
    /// Obtiene el número de elementos almacenados en la lista.
    /// </summary>
    /// <value>La cantidad de elementos contenidos actualmente en la lista.</value>
    int Count { get; }

    /// <summary>
    /// Agrega un elemento al final de la lista.
    /// </summary>
    /// <param name="item">Elemento que se va a agregar a la lista.</param>
    void Add(T item);

    /// <summary>
    /// Inserta un elemento en la posición especificada de la lista.
    /// </summary>
    /// <param name="index">Índice en el que se insertará el elemento.</param>
    /// <param name="item">Elemento que se va a insertar.</param>
    /// <exception cref="System.ArgumentOutOfRangeException">
    /// Se produce cuando <paramref name="index"/> es menor que cero o mayor que <see cref="Count"/>.
    /// </exception> 
    void Insert(int index, T item);

    /// <summary>
    /// Elimina el elemento que se encuentra en el índice especificado.
    /// </summary>
    /// <param name="index">Índice del elemento que se desea eliminar.</param>
    /// <exception cref="System.ArgumentOutOfRangeException">
    /// Se produce cuando <paramref name="index"/> está fuera del rango válido de la lista.
    /// </exception>
    void RemoveAt(int index);

    /// <summary>
    /// Elimina el elemento que se encuentra en el índice especificado.
    /// </summary>
    /// <param name="index">Índice del elemento que se desea eliminar.</param>
    /// <exception cref="System.ArgumentOutOfRangeException">
    /// Se produce cuando <paramref name="index"/> está fuera del rango válido de la lista.
    /// </exception>
    /// 
    T Get(int index);

    /// <summary>
    /// Reemplaza el valor del elemento que se encuentra en el índice indicado.
    /// </summary>
    /// <param name="index">Índice del elemento que se desea modificar.</param>
    /// <param name="value">Valor que se asignará al elemento en la posición indicada.</param>
    /// <exception cref="System.ArgumentOutOfRangeException">
    /// Se produce cuando <paramref name="index"/> está fuera del rango válido de la lista.
    /// </exception>
    void Set(int index, T value);

    /// <summary>
    /// Busca la primera aparición del elemento especificado en la lista.
    /// </summary>
    /// <param name="item">Elemento que se desea buscar.</param>
    /// <returns>El índice de la primera coincidencia o -1 si el elemento no se encuentra.</returns>
    int IndexOf(T item);
}
