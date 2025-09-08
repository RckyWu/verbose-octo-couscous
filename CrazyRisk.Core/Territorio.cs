namespace CrazyRisk.Core;

public class Territorio
{
    public string Id { get; set; }
    public string Nombre { get; set; }
    public Jugador? Dueno { get; set; }
    public int Tropas { get; set; } = 1;

    // Lista de IDs de territorios adyacentes
    public List<string> Adyacentes { get; } = new();

    public Territorio(string id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }
}
