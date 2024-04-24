using FigureGeometriche;
using System.Text;

namespace ObjectsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //comunichiamo con gli oggetti di tipo Cat
            //creazione di un oggetto --> si fa con l'operatore new seguito dal costruttore
            Cat pallina = new Cat("pallina", "bianco");
            
            Console.WriteLine($"Numero gatti creati: {Cat.NumeroGattiCreati}");
            pallina.SayMiau();
            Cat.NumeroFratelli();
            //uso la property Color in scrittura per cambiare lo stato
            //Console.WriteLine($"Il colore del mio gatto è {pallina.Color}");
            Cat nerone = new Cat("nerone", "nero");
            Console.WriteLine($"Numero gatti creati: {Cat.NumeroGattiCreati}");
            //posso assegnare un reference ad un altro reference: i due refernce puntano allo stesso oggetto in memoria
            Cat nerone2 = nerone;
            nerone2.Color = "marrone";
            Console.WriteLine($"Mi chiamo {nerone.Name} e sono di colore {nerone.Color}");
            //sia nerone che nerone2 puntano allo stesso oggetto in memoria
            //possso creare un array di Cat
            Cat[] gatti = new Cat[5];
            Console.WriteLine($"Numero gatti creati: {Cat.NumeroGattiCreati}");
            nerone = null;
            //esempio con l'uso della classe Sequence e i campi statici
            //i campi statici sono unici per tutta la classe
            // i metodi statici sono invocati sulla classe e non sull'Istanza
            //int numero = Sequence.NextValue();
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine(Sequence.NextValue());
            }
            Cat.NumeroFratelli();

            //test di RandomPasswordGenerator
            //metodo statico
            string password = RandomPasswordGenerator.GeneratePassword();
            
            Console.WriteLine(password);
            //creo un oggetto gatto appartenente al namespace ObjectsDemo2
            ObjectsDemo2.Cat cat = new ObjectsDemo2.Cat("pallina2", "bianco", 2);
            //test della classe triangolo
            Triangolo triangolo = new Triangolo(1, 2, 3);

            //Test di Dog
            Dog fido = new Dog("fido");
            Dog senzaNome = new Dog();
            Dog[] dogs = new Dog[5];//array di Dog
            dogs[0] = new Dog("Lampo");
            dogs[1] = fido;
            int[] numeri = { 1, 2, 3, 4, 5 };
            Dog[] dogs2 = { new Dog("Cane1"), new Dog("Cane2")};
            //ciclo su dogs
            //foreach (Dog dog in dogs)
            //{
            //    dog.Bark();
            //}
            for (int i = 0; i < dogs.Length; i++)
            {
                //if (dogs[i] != null)
                //{
                //    dogs[i].Bark();
                //}
                //l'operatore ?. serve per evitare l'eccezione NullReferenceException
                //l'accesso ai membri dell'oggetto è condizionato al fatto che l'oggetto non sia null
                dogs[i]?.Bark();
            }
                //test di ConstAndReadOnlyExample
                ConstAndReadOnlyExample example = new ConstAndReadOnlyExample(10);
                ConstAndReadOnlyExample example2 = new ConstAndReadOnlyExample(11);
                //stampa di PI e Size per example e example2
                Console.WriteLine(ConstAndReadOnlyExample.PI);
                Console.WriteLine(example.Size);
                Console.WriteLine(example2.Size);
            //example.Size = 20; //errore
            //nuovo esempio di uso del costruttore di Dog
            Dog myDog = new Dog();
            //alcuni esempi di costruttori con parametri diversi
            Dog myDog2 = new Dog("Fido");
            Dog myDog3 = new Dog("Fido", 3, 0.5);


        }
        }
    }

