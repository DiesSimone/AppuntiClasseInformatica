using Esercizi3IA.LibClassi;

namespace LibreriaClassi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animale animale = new Animale();
            Lion leone = new Lion(true, 200);
            AfricanLion leoneAfricano = new AfricanLion(true, 250);
            //assegnare un riferimento di tipo sottoclasse a un riferimento di tipo base class
            //corrisponde a un cast implicito
            object obj = leoneAfricano;
            Console.WriteLine(leoneAfricano.Ruggisci());
           
            //proviamo a fare l'opposto: 
            //fare una conversione da un tipo base classe e un tipo sotto-classe
            //si può fare con un cast esplicito

            AfricanLion leoneAfricano2 = (AfricanLion)obj;
            Console.WriteLine(leoneAfricano2.Ruggisci());
            Lion leone2 = new Lion(true, 100);
         
            //l'istruzione seguente fornisce una eccezione perché leone2 non è un LeoneAfricano
            //AfricanLion leoneAfricano3 = (AfricanLion)leone2;
            //Console.WriteLine(leoneAfricano3.Ruggisci());
            //esempi di oggetti anonimi
            Console.WriteLine(new object());
            Console.WriteLine(new Felidae(true));
            Console.WriteLine(new Lion(true, 80));
            Console.WriteLine(new AfricanLion(true, 80));

            //test dell'interfaccia IRiproducible
            //creo due leoni
            Lion leoneMaschio = new Lion(true, 200);
            Lion leonessa = new Lion(false, 150);
            Console.WriteLine("Facciamo camminare la leonessa");
            leonessa.Walk();
            
            //li faccio accoppiare
            Lion[] cuccioli = leoneMaschio.Reproduce(leonessa);
            //creo due leoni africani
            AfricanLion leoneAfricanoMaschio = new AfricanLion(true, 250);
            AfricanLion leonessaAfricana = new AfricanLion(false, 200);
            //li faccio accoppiare
            Lion[] cuccioliAfricani = leoneAfricanoMaschio.Reproduce(leonessaAfricana);

            //test sul polimorfismo
            //creo un array di leoni
            Lion[] leoni = new Lion[3];
            leoni[0] = leoneMaschio;
            leoni[1] = leonessa;
            leoni[2] = leoneAfricanoMaschio;//questo è possibile per l'ereditarietà
            //faccio camminare tutti i leoni
            Console.WriteLine("faccio camminare tutti i leoni");
            foreach (Lion leo in leoni)
            {
                //polimorfismo : il metodo walk viene invocato in base al tipo dell'oggetto
                //l'implementazione del metodo walk dipende dal tipo effettivo dell'oggetto
                leo.Walk();
            }


        }
    }
}
