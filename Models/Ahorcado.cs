namespace TP04_Patejim_Feldman.Models;

static public class Ahorcado{
    static public char[] palabra  {get; private set;} = new char[12];
    static public int cantIntentos {get; private set;}
    static public List<char> letrasUsadas {get; private set;} = new List<char>();

    static public void inicializarGrupo(){
        palabra[0]= 'P';
        palabra[1]= 'R';
        palabra[2]= 'O';
        palabra[3]= 'V';
        palabra[4]= 'I';
        palabra[5]= 'N';
        palabra[6]= 'C';
        palabra[7]= 'I';
        palabra[8]= 'A';
        palabra[9]= 'N';
        palabra[10]= 'O';
        palabra[11]= 'S';

        cantIntentos = palabra.Length;
    }
}