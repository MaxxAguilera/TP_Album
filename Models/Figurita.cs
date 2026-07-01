namespace TP_Album_Aguilera_Perez_Tortosa.Models;

public class Figurita
{
    public int id {get; set;};
    public int idJugador{get;set;};
    public int cantObtenida{get;set;};
    public bool pegada{get;set;};


    public Figurita(int id, int idJug, int cantObtenida, bool peg)
    {
        this.id = id;
        this.idJugador = idJug;
        this.cantObtenida = cantObtenida;
        this.pegada = peg;
    }

}

