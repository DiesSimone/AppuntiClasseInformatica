namespace ObjectPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(3,5,4);
            Console.WriteLine(box);

            List<Box> scatole = new List<Box>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                scatole.Add(new Box(random.Next(1, 11), random.Next(1, 11), random.Next(1, 11)));
                Console.WriteLine($"{scatole[i]}");
            }
            //ciclo di stampa di una lista
            Console.WriteLine("Stampa delle scatole");
            for (int i = 0;i < scatole.Count; i++)
            {
                Console.WriteLine($"{scatole[i]}, Volume {scatole[i].Volume}, TotalArea {scatole[i].TotalArea}");
            }
            Console.WriteLine("Ordiniamo la lista con l'ordinamento predefinito - quello del CompareTo");
            scatole.Sort();
            Console.WriteLine("Stampa delle scatole -- dopo l'ordinamento");
            for (int i = 0; i < scatole.Count; i++)
            {
                Console.WriteLine($"{scatole[i]}, Volume {scatole[i].Volume}, TotalArea {scatole[i].TotalArea}");
            }
            //ordiniamo le scatole in base all'area totale
            Console.WriteLine("Stampa delle scatole -- ordinamento in base all'area totale");
            scatole.Sort(new OrderByArea());
            for (int i = 0; i < scatole.Count; i++)
            {
                Console.WriteLine($"{scatole[i]}, Volume {scatole[i].Volume}, TotalArea {scatole[i].TotalArea}");
            }
            //clonazione di oggetti - vari metodi e opzioni
            Box box1 = new Box(1, 2, 3);
            Console.WriteLine("Stampa di box1");
            Console.WriteLine(box1);
            //voglio creare una copia dell'oggetto box1
            Box? copiaBox = box1.ShallowCopy();
            //stampa di copiaBox
            Console.WriteLine("Stampa di copiaBox");
            Console.WriteLine(copiaBox);

            //creo dei punti e poi dei segmenti
            Punto p1 = new Punto(1, 2);
            Punto p2 = new Punto(3, 4);
            Segmento s1 = new Segmento(p1,p2);
            Segmento s1Copia = s1.ShallowCopy();
            Console.WriteLine("Stampa d s1 e s1copia");
            Console.WriteLine(s1);
            Console.WriteLine(s1Copia);
            Console.WriteLine("Modifica ddi s1Copia");
            //cosa succede che modifico il segmento s1Copia?
            s1Copia.P1.X = 10;
            Console.WriteLine("Stampa di s1 e s1Copia dopo la moifica di s1Copia");
            Console.WriteLine(s1);
            Console.WriteLine(s1Copia);

            //clonazione profonda
            Console.WriteLine("Clonazione profonda di s1");
            Segmento s1CopiaProfonda = s1.DeepCopy();
            Console.WriteLine("Stampa di s1 e s1CopiaProfonda");
            Console.WriteLine(s1);
            Console.WriteLine(s1CopiaProfonda);
            Console.WriteLine("Modifica di s1CopiaProfonda");
            //cosa succede se modifico il segment s1CopiaProfonda=
            s1CopiaProfonda.P1.X = 100;
            Console.WriteLine("Stampa di s1 e s1CopiaProfonda dopo la modifica di s1CopiaProfonda");
            Console.WriteLine(s1);
            Console.WriteLine(s1CopiaProfonda);
            //test di copy constructor
            Console.WriteLine("Stampa di box1 e box2");
            Box box2 = new Box(box1);
            Console.WriteLine(box1);
            Console.WriteLine(box2);
        }
    }
}
