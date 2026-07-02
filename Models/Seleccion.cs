namespace TP_Album_Aguilera_Perez_Tortosa.Models;

public class Seleccion
{
    public int id {get; set;} 
    public string nombre{get;set;} 
    public char grupo{get;set;} 

    public Seleccion(int id, string nombre, char grupo)
    {
        this.id = id;
        this.nombre = nombre;
        this.grupo = grupo;
    }

}
