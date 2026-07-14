namespace TP_Album_Aguilera_Perez_Tortosa.Models;

public static class Sobre
{
    private const int CANTIDAD_JUGADORES_SOBRE = 5;   

    public static List<Jugador> AbrirSobre(){
        Random random = new Random();
        List<Jugador> jugadores = BD.ObtenerJugadores();
        List<Jugador> jugadoresSobre = new List<Jugador>();

        while (jugadoresSobre.Count < CANTIDAD_JUGADORES_SOBRE)
        {
            int indiceAleatorio = random.Next(0, jugadores.Count);
            if (!jugadoresSobre.Contains(jugadores[indiceAleatorio]))
            {
                jugadoresSobre.Add(jugadores[indiceAleatorio]);
                BD.InsertarJugador(jugadores[indiceAleatorio].id);
            }
        }
        return jugadoresSobre;
    }
}
