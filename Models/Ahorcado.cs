namespace TP04_Patejim_Feldman.Models;

static public class Ahorcado{
    static public char[] palabra  {get; private set;} = new char[12];
    static public int cantIntentos {get; private set;}
    static public List<char> letrasUsadas {get; private set;} = new List<char>();
}