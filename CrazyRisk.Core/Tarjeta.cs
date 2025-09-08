namespace CrazyRisk.Core;

public class Tarjeta
{
    public enum Tipo
    {
        Infanteria,
        Caballeria,
        Artilleria
    }

    public Tipo TipoTarjeta { get; }

    public Tarjeta(Tipo tipo)
    {
        TipoTarjeta = tipo;
    }
}
