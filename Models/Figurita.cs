namespace TP_Album_Aguilera_Perez_Tortosa.Models;

public class Figurita
{
    public int id {get; set;} 
    public int idJugador{get;set;} 
    public int cantObtenida{get;set;} 
    public bool pegada{get;set;} 


    public Figurita(int id, int idJugador, int cantObtenida, bool pegada)
    {
        this.id = id;
        this.idJugador = idJugador;
        this.cantObtenida = cantObtenida;
        this.pegada = pegada;
    }

}

