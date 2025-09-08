namespace CrazyRisk.Core;

public class Continente
{
    public string Nombre { get; set; }
    public int Bonus { get; set; }

    public List<Territorio> Territorios { get; } = new();

    public Continente(string nombre, int bonus)
    {
        Nombre = nombre;
        Bonus = bonus;
    }
}
