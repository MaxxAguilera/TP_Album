namespace TP_Album_Aguilera_Perez_Tortosa.Models;

public class Jugador
{
    public int id {get; set;} 
    public string nombre{get;set;} 
    public string apellido{get;set;} 
    public string posicion{get;set;} 
    public int numCamiseta{get;set;} 
    public int idSeleccion{get;set;} 


    public Jugador(int id, int idSeleccion, int numCamiseta, string nombre, string apellido, string posicion)
    {
        this.id = id;
        this.nombre = nombre;
        this.apellido = apellido;
        this.posicion = posicion;
        this.numCamiseta = numCamiseta;
        this.idSeleccion = idSeleccion;
    }

}
