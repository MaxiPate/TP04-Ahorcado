namespace TP04_Patejim_Feldman.Models;

static public class Ahorcado{
    static public string palabra  {get; private set;}
    static public int cantIntentos {get; private set;}
    static public string palabraParcial {get; private set;}

    static public List<char> letrasUsadas = new List<char>();

    static public void inicializarGrupo(){
        cantIntentos = 0;
        palabra = "PROVINCIANOS";
        palabraParcial = "------------";
    }

    static public bool arriesgoLetra(char letra){
        bool acierto = false;
        char[] parcial = palabraParcial.ToCharArray();
        
         
        for(int i = 0; i < palabra.Length; i++){
            if(letra == palabra.Length){
                acierto = true;
                parcial[i] = letra;
                cantIntentos++;
                letrasUsadas.Add(letra);
                Console.WriteLine("Correcto!");
            }else if(!acierto){
                cantIntentos++;
                letrasUsadas.Add(letra);
                Console.WriteLine("Incorrecto, mala suerte!");
            }
        }
        return acierto;



    }

    //static public bool arriesgoPalabra(string palabra){
        
    //}
}