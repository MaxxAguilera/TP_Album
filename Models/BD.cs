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
            string query = "SELECT J.nombre, J.color, J.numCamiseta, J.idSeleccion, J.id, F.cantObtenida FROM Jugadores J LEFT JOIN Figuritas F ON F.idJugador = J.id";
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

    public static void InsertarJugador(Jugador j)
    {
        using (SqlConnection conn = new SqlConnection(_connectionString))
        {
            string query = "UPDATE Figuritas SET cantObtenida = cantObtenida + 1 WHERE idJugador = @idDelJugador";
            conn.Execute(query, new { idDelJugador = j.id });
        }
    }
}