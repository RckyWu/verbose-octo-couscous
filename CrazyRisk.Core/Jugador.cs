namespace CrazyRisk.Core;

public class Jugador
{
    public string Alias { get; set; }
    public string Color { get; set; }   // luego lo puedes cambiar a un tipo Color
    public List<Tarjeta> Tarjetas { get; } = new();
    public List<Territorio> Territorios { get; } = new();

    public Jugador(string alias, string color)
    {
        Alias = alias;
        Color = color;
    }
}
