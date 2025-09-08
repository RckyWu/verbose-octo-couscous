using System;

namespace CrazyRisk.Core;

public static class TurnManager
{
    // Contador global de intercambios (Fibonacci iniciando en 2,3,5,8,...)
    // Se mantiene "global" para toda la partida.
    private static int _fibA = 2; // término actual
    private static int _fibB = 3; // siguiente término

    /// <summary>
    /// Avanza el contador global Fibonacci y devuelve su valor actual.
    /// Llamar cada vez que CUALQUIER jugador canjea un trío de tarjetas.
    /// </summary>
    public static int ConsumirContadorGlobal()
    {
        // Devuelve el término actual y avanza la serie
        int actual = _fibA;
        // siguiente = a + b
        int siguiente = _fibA + _fibB;
        _fibA = _fibB;
        _fibB = siguiente;
        return actual;
    }

    /// <summary>
    /// Calcula refuerzos al inicio del turno.
    /// Fórmula base: floor(territorios/3) con mínimo 3 + bonusContinente.
    /// Si el jugador está obligado a canjear (tiene 6 tarjetas), se suma además el contador global.
    /// </summary>
    public static int CalcularRefuerzos(Jugador jugador, Mapa mapa, bool canjeObligatorioPorSeisTarjetas)
    {
        if (jugador is null) throw new ArgumentNullException(nameof(jugador));
        if (mapa is null) throw new ArgumentNullException(nameof(mapa));

        int territorios = mapa.ContarTerritorios(jugador);
        int baseRef = Math.Max(3, territorios / 3);
        int bonus = mapa.CalcularBonusContinente(jugador);

        int total = baseRef + bonus;

        if (canjeObligatorioPorSeisTarjetas)
        {
            // Cuando obtiene la 6ta tarjeta, debe canjear >= 1 trío y se suma el contador global
            total += ConsumirContadorGlobal();
        }

        return total;
    }

    /// <summary>
    /// Resuelve combate según los dados (1-3 atacante, 1-2 defensor).
    /// TODO: Implementar la lógica de tiradas y comparación. Por ahora se marca como no implementado.
    /// </summary>
    public static void ResolverCombate(Territorio origen, Territorio destino, int dadosAtacante, int dadosDefensor)
    {
        _ = origen; _ = destino; _ = dadosAtacante; _ = dadosDefensor;
        throw new NotImplementedException("ResolverCombate: implementar tiradas y comparación de dados.");
    }

    /// <summary>
    /// Verifica si se puede mover entre dos territorios propios por ruta de adyacencias.
    /// TODO: Implementar BFS usando tus estructuras (MyQueue/MyList) más adelante.
    /// </summary>
    public static bool PuedeMoverEntre(Territorio origen, Territorio destino)
    {
        _ = origen; _ = destino;
        throw new NotImplementedException("PuedeMoverEntre: implementar BFS de conectividad.");
    }
}
