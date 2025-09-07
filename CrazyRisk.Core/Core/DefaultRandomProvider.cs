using System;

namespace CrazyRisk.Core;

public class DefaultRandomProvider : IRandomProvider
{
    private readonly Random _rng = new();
    public int NextInclusive(int minInclusive, int maxInclusive) =>
        _rng.Next(minInclusive, maxInclusive + 1);
}
