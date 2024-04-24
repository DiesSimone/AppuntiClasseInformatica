using LabClassi.FaunaGreppi;
using System.Buffers.Text;
using System.Drawing;
using System.Linq.Expressions;
using System.Numerics;

namespace LabClassi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog berto = new Dog("Berto", 3);
            //invocazione dei metodi di istanza
            berto.Bark();
            berto.PrintInfo();
            Dog.PrintName();
            //Test di AnimalShelter
            //creazione di uno shelter - per cani
            AnimalShelter<Dog> dogShelter = new AnimalShelter<Dog>();
            //arrivano i cani al ricovero
            Dog lampo = new Dog("Lampo", 10);
            Dog scheggia = new Dog("Scheggia", 2);
            //aggiungo un cane al canile
            dogShelter.Shelter(berto);//berto ha indice 0
            dogShelter.Shelter(lampo);//lampo ha indice 1
            dogShelter.Shelter(scheggia);//scheggia ha indice 2
            //spampa dei cani nel canile
            Console.WriteLine("Stampa dei cani");
            dogShelter.PrintAnimals();
            //proviamo atogliere lampo
            //il metodo Release prende in input un indice e 
            //restituisce l'oggetto in memoria che corrisponde
            //all'indice selezionato
            Dog caneLiberato = dogShelter.Release(1);
            //stampa del cane liberato
            Console.WriteLine($"Sono un cane fortunato e mi chiamo {caneLiberato.Name}");
            //test di Release che accetta un reference di tipo Cane
            Dog? caneLiberato2 = dogShelter.Release(scheggia);
            if (caneLiberato2 != null)
            {
                Console.WriteLine($"Sono un cane fortunato e mi chiamo {caneLiberato2.Name}");
            }
            //facciamo un ricovero per gatti
            AnimalShelter<Cat> catShelter = new AnimalShelter<Cat>();
            //aggiungiamo dei gatti al catShelter -- uso di oggetti anonimi
            catShelter.Shelter(new Cat("Pallina", 2));
            catShelter.Shelter(new Cat("Zeus", 2));
            catShelter.Shelter(new Cat("Gigia", 2));

            //creo un altro gatto, tramite il reference (indirizzo di memoria)
            Cat nerone = new Cat("Nerone", 7);
            Cat stellina = new Cat("Stellina", 1);
            catShelter.Shelter(nerone);
            //stampiamo i gatti
            Console.WriteLine("Stampa dei gatti");
            catShelter.PrintAnimals();
            //Un esmpio di utilizzo della classe parametrica Utility
            Utility<Cat> utility = new Utility<Cat>();
            Utility<int> utility1 = new Utility<int>();

            //scambia gli oggetti
            utility.Swap(ref nerone, ref stellina);
            int numero1 = 5;
            int numero2 = 10;
            //scambia gli interi
            utility1.Swap(ref numero1, ref numero2);

            //test classe Animale
            Animale animale1 = new Animale(40, new DateTime(2023, 03, 1),
                Color.AliceBlue, TipoPelle.PeloCorto, true,
                5000, new Animale.Cervello(3, 2000000000));
            Animale animale2 = new Animale(10, DateTime.Now);
            //interazione con gli animali
            //stampiamo le calorie prima del movimento
            string vivoMorto = animale1.Vivo ? "vivo" : "morto"; //operatore ternario
            Console.WriteLine($"Sono Animale1 e ho {animale1.KCalAccumulate} e sono {vivoMorto}");
            animale1.Muoviti(10, 5);
            Console.WriteLine("Mi moso mosso e ...");
            vivoMorto = animale1.Vivo ? "vivo" : "morto";
            Console.WriteLine($"Sono Animale1 e ho {animale1.KCalAccumulate} e sono {vivoMorto}");
            animale1.Mangia(new Cibo("carne", 2, 3000));
            vivoMorto = animale1.Vivo ? "vivo" : "morto";
            Console.WriteLine($"Ho mangiato e ora  ho {animale1.KCalAccumulate} calorie e sono {vivoMorto} ");
            //facciamolo muovere ancora
            animale1.Muoviti(20, 5);
            Console.WriteLine("Mi moso mosso e ...");

            vivoMorto = animale1.Vivo ? "vivo" : "morto"; //operatore ternario
            Console.WriteLine($"Sono Animale1 e ho {animale1.KCalAccumulate} e sono {vivoMorto}");

            //test sul polimorfismo con Umano, Mamifero e Animale
            Console.WriteLine("\n\nTest sul polimorfismo con Umano, Mamifero e Animale");

            //un Animale
            Animale animale = new Animale(40, new DateTime(2023, 03, 1), Color.AliceBlue,
                TipoPelle.PeloCorto, true, 5000, new Animale.Cervello(3, 2000000000));
            Console.WriteLine("Stampa Animale");
            Console.WriteLine(animale);
            animale.Mangia(new Cibo("carne", 2, 3000));
            animale.Muoviti(10, 5);
            Console.WriteLine(animale.Comunica());

            //un Mammifero
            Mammifero mammifero = new Mammifero(30, DateTime.Now, Color.AliceBlue,
                TipoPelle.PeloCorto, true, 30000,
                new Animale.Cervello(2, 20000000000), 4);
            Console.WriteLine("Stampa Mammifero");
            Console.WriteLine(mammifero);
            mammifero.Mangia(new Cibo("carne", 0.5, 6000));
            mammifero.Muoviti(10, 4);
            Console.WriteLine(mammifero.Comunica());

            //un Umano
            Umano umano = new Umano(70, new DateTime(1980, 1, 1), Color.Brown,
                TipoPelle.PeloCorto, true, 30000,
                new Animale.Cervello(2, 20000000000), 2, 100);
            Console.WriteLine("Stampa Umano");
            Console.WriteLine(umano);
            umano.Mangia();
            umano.Muoviti(10, 2);
            Console.WriteLine(umano.Comunica());
            umano.Parla("Ciao a tutti");
            umano.Saluta();
            umano.Sorride();
            umano.Dorme();

            //Creiamo un array di animali per evidenziare il comportamento polimorfico degli oggetti
            Animale[] animali = new Animale[3];
            animali[0] = animale;
            animali[1] = mammifero;
            animali[2] = umano;
            Console.WriteLine("\n\nStampa array di animali");
            foreach (Animale a in animali)
            {
                //quale versione di Comunica viene invocata?
                //la versione di Comunica dipende dal tipo dell'oggetto al tempo dell'invocazione
                Console.WriteLine(a.Comunica());
            }

            //facciamo un metodo che accetta in input un oggetto di tipo Animale o che discende da Animale
            //e che invoca il metodo Comunica
            Console.WriteLine("\n\nStampa array di animali con metodo ParlamiAnimale");
            foreach (Animale a in animali)
            {
                ParlamiAnimale(a);
                MostraTipo(a);
                TrattamiComeUmano(a);
            }

            //navigazione nell'ereditarietà delle classi
            //un oggetto di una classe derivata può essere trattato come un oggetto della classe base
            //cosa succede se facciamo un cast di un oggetto di tipo Umano a un oggetto di tipo Mammifero
            //e poi proviamo ad accedere al metodo Comunica?
            Console.WriteLine("Metodi ridefiniti con override - tentativo di accesso al metodo della base class");
            Console.WriteLine(((Mammifero)umano).Comunica());
            //oppure
            Console.WriteLine((umano as Mammifero).Comunica());
            Console.WriteLine("Come si vede, viene comunque utilizzata la versione del metodo Comunica che è nalla classe Umano, " +
                "ossia quella del tipo effettivo dell'oggetto puntato dal reference");
            //quando si effettua l'override di un metodo, non è più possibile accedere dall'esterno della classe al metodo della classe base
            //all'interno della classe derivata, si può accedere al metodo della classe base tramite la keyword base

            //se si volesse accedere al metodo della classe base, si dovrebbe utilizare il modificatore new al posto di override
            //facciamo un esempio con il metodo Allatta
            Console.WriteLine("Metodi ridefiniti con new - tentativo di accesso al metodo della base class");
            ((Mammifero)umano).Allatta();
            (umano as Mammifero).Allatta();
            //in questo caso viene utilizzato il metodo della classe base, contrariamente a quanto accade con l'override

            //test con classi astratte
            //non è possibile creare un'istanza di una classe astratta
            //EssereVivente essereVivente = new EssereVivente(); //errore, nonostante sia possibile avere dei costruttori in una classe astratta
            //le classi astratte vengono utilizzate per definire delle classi base da cui derivano altre classi
            //nonostante sia sia possibile dichiarare un reference di tipo della classe astratta
            //e assegnargli un oggetto di una classe derivata
            //l'istruzione seguente genera un errore
            //EssereVivente essereVivente = new EssereVivente();
            //l'istruzione seguente è corretta

            //test con classi astratte
            Console.WriteLine("\n\nTest con classi astratte");
            EssereVivente essereVivente = new Umano(70, new DateTime(1980, 1, 1), Color.Brown,
                               TipoPelle.PeloCorto, true, 30000,
                                              new Animale.Cervello(2, 20000000000), 2, 100);
            //il metodo Riposa è stato ereditato dalla classe base e ridefinito nella classe derivata
            essereVivente.Riposa();

            //il metodo Respira è stato dichiarato come astratto nella classe base e ridefinito nella classe derivata
            essereVivente.Respira();

            EssereVivente essereSuperUmano = new SuperUmano(70, new DateTime(1980, 1, 1), Color.Brown,
                                              TipoPelle.PeloCorto, true, 30000,
                                              new Animale.Cervello(2, 20000000000), 2, 100);
            //il metodo Respira è stato dichiarato come astratto nella classe base e ridefinito nella classe derivata
            essereSuperUmano.Respira();


            //classificazione degli oggetti in base ai comportamenti
            //un oggetto può essere classificato in base ai comportamenti che può eseguire
            //un oggetto può essere classificato all'interfaccia che implementa
            //definiamo l'interfaccia IRiproducibile per gli animali

            //creiamo un array di IRiproducibile
            Console.WriteLine("\n\nTest con interfaccia IRiproducibile");
            IRiproducibile<Mammifero>[] riproducibili = new IRiproducibile<Mammifero>[4];

            riproducibili[0] = new Mammifero(30, DateTime.Now, Color.AliceBlue,
                               TipoPelle.PeloCorto, true, 30000,
                               new Animale.Cervello(2, 20000000000), 4, Genere.Maschio);
            riproducibili[1] = new Umano(70, new DateTime(1980, 1, 1), Color.Brown, TipoPelle.PeloCorto, true, 30000,
                               new Animale.Cervello(2, 20000000000), 2, 100, Genere.Maschio);
            riproducibili[2] = new SuperUmano(70, new DateTime(1980, 1, 1), Color.Brown, TipoPelle.PeloCorto, true, 30000,
                               new Animale.Cervello(2, 20000000000), 2, 100);
            riproducibili[3] = new Umano(70, new DateTime(1980, 1, 1), Color.Brown, TipoPelle.PeloCorto, true, 30000,
                new Animale.Cervello(2, 20000000000), 2, 100, Genere.Femmina);

            //nel caso dell'array 
            //facciamo riprodurre gli animali IRiproducibile<Mammifero>[] riproducibili l'unica cosa che interessa è che tutti gli oggetti
            //nell'array implementino l'interfaccia IRiproducibile<Mammifero>
            //non importa se l'oggetto è di tipo Mammifero, Umano o SuperUmano
            //il fatto che gli oggetti implementino una gerachia non ha rilevanza
            for (int i = 0; i < riproducibili.Length; i++)
            {
                for (int j = i + 1; j < riproducibili.Length; j++)
                {
                    Console.WriteLine($"Si riproducono {riproducibili[i]} con {riproducibili[j]}");
                    Mammifero[]? cuccioli = riproducibili[i].Riproduci((Mammifero)riproducibili[j]);
                    if (cuccioli != null)
                    {
                        Console.WriteLine($"Sono nati {cuccioli.Length} cuccioli");
                        Console.WriteLine("Sono nati:");
                        foreach (Mammifero cucciolo in cuccioli)
                        {
                            Console.WriteLine(cucciolo);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Non sono nati cuccioli");
                    }


                }

            }

        }

        private static void TrattamiComeUmano(Animale a)
        {
            //operatore as
            //l'operatore as è un operatore di cast che restituisce null se il cast non è possibile
            //altrimenti restituisce l'oggetto castato
            //l'operatore as può essere utilizzato solo con riferimenti a oggetti
            //l'operatore as non genera un'eccezione se il cast non è possibile
            //l'operatore as è più efficiente di un cast esplicito
            //qualche esempio
            Umano? essere = a as Umano;
            //cast esplicito - nel caso non si possa fare il cast si genera un'eccezione
            //Umano? essere2 =(Umano) a;
            if (essere != null)
            {
                Console.WriteLine("Sono un essere umano");
                //posso usare tutte le caratteristiche di un umano
                Console.WriteLine($"Il mio Qi è {essere.Qi}");
            }
            else
            {
                Console.WriteLine("L'oggetto passato come parametro non è di tipo Umano");
            }
        }

        //differenza tra typeof e GetType
        //GetType restituisce il tipo dell'oggetto al tempo dell'esecuzione
        //typeof restituisce il tipo dell'oggetto al tempo della compilazione
        //scriviamo un metodo che accetta in input un oggetto di tipo Animale o che discende da Animale
        //e utilizza typeof e GetType

        private static void MostraTipo(Animale a)
        {
            //modi di ottenere il tipo dell'oggetto passato come parametro - uso di GetType
            Console.WriteLine("\n\nmodi di ottenere il tipo dell'oggetto passato come parametro - uso di GetType");
            Console.WriteLine("Tipo dell'oggetto passato come parametro: " + a.GetType());
            Console.WriteLine("Tipo dell'oggetto passato come parametro - Name: " + a.GetType().Name);
            Console.WriteLine("Tipo dell'oggetto passato come parametro - Full Name: " + a.GetType().FullName);
            Console.WriteLine("Tipo dell'oggetto passato come parametro - Base Type: " + a.GetType().BaseType);
            Console.WriteLine("Tipo dell'oggetto passato come parametro - Is Abstract: " + a.GetType().IsAbstract);

            //uso dell'operatore is - restituisce true se l'oggetto passato come parametro è del tipo specificato o discende da tale tipo
            Console.WriteLine("\n\nUso dell'operatore is - restituisce true se l'oggetto passato come parametro è del tipo specificato o discende da tale tipo");
            //a is Umano retituisce true se a è di tipo Umano o discende da Umano

            //cosa succederebbe se facessi prima il test con Animale e poi con Mammifero e Umano? --> provare 
            Console.WriteLine("Uso dell'operatore is");
            if (a is Umano)
            {
                Console.WriteLine("L'oggetto passato come parametro è di tipo Umano");
            }
            //a is Mammifero retituisce true se a è di tipo Mammifero o discende da Mammifero
            else if (a is Mammifero)
            {
                Console.WriteLine("L'oggetto passato come parametro è di tipo Mammifero");
            }
            //a is Animale retituisce true se a è di tipo Animale o discende da Animale
            else if (a is Animale)
            {
                Console.WriteLine("L'oggetto passato come parametro è di tipo Animale");
            }
            else
            {
                Console.WriteLine("L'oggetto passato come parametro è di tipo sconosciuto");
            }
            Console.WriteLine("Uso dell'operatore typeof");
            //uso di typeof 
            //The typeof operator in C# can only be used with types, not with variables.
            //It is used to obtain the System.Type object that represents a specific type at compile-time.
            //In summary, typeof is used with types at compile - time, while GetType() is used with variables at runtime to get their actual type.
            //a.GetType() == typeof(Umano) retituisce true se a è di tipo Umano
            if (a.GetType() == typeof(Umano))
            {
                Console.WriteLine("L'oggetto passato come parametro è di tipo Umano");
            }
            //a.GetType() == typeof(Mammifero) retituisce true se a è di tipo Mammifero
            else if (a.GetType() == typeof(Mammifero))
            {
                Console.WriteLine("L'oggetto passato come parametro è di tipo Mammifero");
            }
            //a.GetType() == typeof(Animale) retituisce true se a è di tipo Animale
            else if (a.GetType() == typeof(Animale))
            {
                Console.WriteLine("L'oggetto passato come parametro è di tipo Animale");
            }
            else
            {
                Console.WriteLine("L'oggetto passato come parametro è di tipo sconosciuto");
            }
        }

        private static void ParlamiAnimale(Animale a)
        {
            Console.WriteLine(a.Comunica());
        }
    }
}
