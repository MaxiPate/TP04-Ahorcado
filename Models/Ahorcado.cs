namespace TP04_Patejim_Feldman.Models;

static public class Ahorcado{
    static public string palabra  {get; private set;}
    static public int cantIntentos {get; private set;}
    static public string palabraParcial {get; private set;}

    static public void inicializarGrupo(){
        cantIntentos = 0;
        palabra = "PROVINCIANOS";
        palabraParcial = "------------";
    }

    static public void arriesgoLetra(char letra){

    }

    static public bool arriesgoPalabra(string palabra){

    }
}