namespace RipassoClassi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //test di utilizzo della classe Persona
            //con gli oggetti si hanno sempre due cose:
            //il riferimento all'oggetto 
            //l'oggetto vero e proprio
            Persona persona = new Persona("Jacopo Giordano", "Bianchi");//i campi sono inizializzati ai valori di default
            Persona personaCopia = persona;
            Console.WriteLine(persona.MiPresento());
            Console.WriteLine(persona);

            Persona persona1 = new Persona();
            Studente studente = new Studente("Simon", "DIEEEEEEEEEEEEEES", new DateTime(2006,2,12), "3IA", 7.1);
            Console.WriteLine(studente.MiPresento());

            //con le gerarchie di oggetti è possibile referenziare oggetti di tipo sottoclasse
            //con reference di tipo base class
            Persona p = new Studente("Nauf", "Yusuf", new DateTime(2005, 2, 12), "3IA", 7.1);
            //polimorfismo -
            Console.WriteLine(p.MiPresento()); //?
            p = persona;
            Console.WriteLine(p.MiPresento()); //?
            //concetto di interfaccia - servono a definire comportamenti
            //uno studente implemente l'interaccia IStudentable
            studente.Studio();
            studente.SvolgoVerifiche();
            studente.SeguoLezioni();
            Persona bulli = new Persona("Abdullah", "Muaaz");
            Persona ppise2 = new Persona("Andrea", "Acco");
            Persona[] elencoAmici = new Persona[] {bulli, ppise2 };
            Console.WriteLine(studente.EscoConBrothers(elencoAmici));
        }
    }
}
