namespace TP_Album_Aguilera_Perez_Tortosa.Models;

public class Jugador
{
   
    public string nombre{get;set;}  
    public string color{get;set;} 
    public int numCamiseta{get;set;} 
    public int idSeleccion{get;set;}
    public int id {get; set;}
    public int cantObtenida {get; set;} 



    public Jugador(string nombre, string color, int numCamiseta, int idSeleccion, int id, int cantObtenida)
    {
        this.id = id;
        this.nombre = nombre;
        this.color = color;
        this.numCamiseta = numCamiseta;
        this.idSeleccion = idSeleccion;
        this.cantObtenida = cantObtenida;
    }

}
