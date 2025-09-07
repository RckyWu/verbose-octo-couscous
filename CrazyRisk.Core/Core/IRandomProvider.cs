namespace CrazyRisk.Core;

public interface IRandomProvider
{
    // Devuelve entero en [minInclusive, maxInclusive]
    int NextInclusive(int minInclusive, int maxInclusive);
}
