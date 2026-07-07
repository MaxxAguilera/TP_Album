namespace TP_Album_Aguilera_Perez_Tortosa.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using TP_Album_Aguilera_Perez_Tortosa.Models;


public static class BD
{
    private static string _connectionString = @"Server=localhost; DataBase=Album;Integrated Security=True;TrustServerCertificate=True;";

    public static List<Jugador> ObtenerJugadores()
    {
        List<Jugador> jugadores = new List<Jugador>();
        using(SqlConnection conn = new SqlConnection(_connectionString))
        {
            string query = "SELECT nombre, color, numCamiseta, idSeleccion, cantObtenida, Jugadores.id FROM Jugadores inner join Figuritas idJugador = Jugadores.id";
            jugadores = conn.Query<Jugador>(query).ToList();
        }
        return jugadores;

    }

    public static List<Figurita> ObtenerFiguritas()
    {
        List<Figurita> figuritas = new List<Figurita>();
        using(SqlConnection conn = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Figuritas";
            figuritas = conn.Query<Figurita>(query).ToList();
        }
        return figuritas;

    }

    public static List<Seleccion> ObtenerSelecciones()
    {
        List<Seleccion> selecciones = new List<Seleccion>();
        using(SqlConnection conn = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Selecciones";
            selecciones = conn.Query<Seleccion>(query).ToList();
        }
        return selecciones;

    }
}