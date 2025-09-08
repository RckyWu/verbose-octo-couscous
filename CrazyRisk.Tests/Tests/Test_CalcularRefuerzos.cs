using CrazyRisk.Core;
using Xunit;

namespace CrazyRisk.Tests;

public class RefuerzosTests
{
    [Fact]
    public void Refuerzos_MinimoTres_SinBonus()
    {
        var j = new Jugador("A", "Rojo");
        var m = new Mapa();
        // mapa sin territorios del jugador → base = max(3, 0/3) = 3
        Assert.Equal(3, TurnManager.CalcularRefuerzos(j, m, false));
    }
}
