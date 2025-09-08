namespace CrazyRisk.Core;

public class Mapa
{
    public List<Continente> Continentes { get; } = new();

    public Territorio? BuscarTerritorio(string id)
    {
        foreach (var continente in Continentes)
        {
            foreach (var territorio in continente.Territorios)
            {
                if (territorio.Id == id)
                    return territorio;
            }
        }
        return null;
    }
    public int ContarTerritorios(Jugador jugador)
    {
        int c = 0;
        foreach (var cont in Continentes)
            foreach (var t in cont.Territorios)
                if (t.Dueno == jugador) c++;
        return c;
    }

    public int CalcularBonusContinente(Jugador jugador)
    {
        int bonus = 0;
        foreach (var cont in Continentes)
        {
            bool completo = true;
            foreach (var t in cont.Territorios)
            {
                if (t.Dueno != jugador) { completo = false; break; }
            }
            if (completo) bonus += cont.Bonus;
        }
        return bonus;
    }


}
