using System.Collections.Immutable;

namespace CompableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //un array di temperature
            Temperatura[] temperature = new Temperatura[5];
            temperature[0] = new Temperatura(20, DateTime.Now + new TimeSpan(1, 1, 0), "Milano");
            temperature[1] = new Temperatura(21, DateTime.Now + new TimeSpan(3, 2, 0), "Torino");
            temperature[2] = new Temperatura(19, DateTime.Now + new TimeSpan(0, 1, 56), "Roma");
            temperature[3] = new Temperatura(24, DateTime.Now + new TimeSpan(-1, 3, 0), "Napoli");
            temperature[4] = new Temperatura(30, DateTime.Now + new TimeSpan(0, 0, 5), "Palemmo");
            //vogliamo stampare le temperature
            Console.WriteLine("Stampa temperature non ordinate");
            foreach (Temperatura t in temperature)
            {
                Console.WriteLine(t);
            }
            //vogliamo ordinare l'array in base alla temperatura?
            Array.Sort(temperature);//il criterio è quello del CompareTo di IComparable 
            //voglio stampare le temperature
            Console.WriteLine("Stampa temperature ordinate");
            foreach (Temperatura t in temperature)
            {
                Console.WriteLine(t);
            }
            //con gli operatori possono confrontare le temperature
            if (temperature[0] > temperature[1])
            {
                Console.WriteLine($"La temperatura di {temperature[0].Posizione}");
            }

            //vogliamo confrontare due temperature, basandoci non sul CompareTo ma su un altro
            //criterio che è definito nel comparatore che abbiamo dichiarato
            Console.WriteLine("Stampa temperature in base al criterio comparerbydate");
            Array.Sort(temperature, new ComparerByDate());
            foreach (Temperatura t in temperature)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine("Stampa temperature in base al criterio comparerbyposizione");
            Array.Sort(temperature, new ComparerByPosizione());
            foreach (Temperatura t in temperature)
            {
                Console.WriteLine(t);
            }

            //conceetto di uguaglianza tra oggetti
            var istante = DateTime.Now;
            Temperatura t1 = new Temperatura(20, istante, "Monticello Brianza");
            Temperatura t2 = new Temperatura(20, istante, "Monticello Brianza");
            Console.WriteLine("Test di equals");
            if (t1.Equals(t2))
            {
                Console.WriteLine("t1 e t2 sono uguali");
            }
            else
            {
                Console.WriteLine("t1 e t2 sono diversi");
            }
            Temperatura t3 = t2;//t3 e t1 puntano allo stesso oggetto in memoria 
            if (t3 == t2)
            {
                Console.WriteLine("t2 e t3 sono uguali");
            } else
            {
                Console.WriteLine("t2 e t3 sono diversi");
            }

            //concetto di lista
            List<Temperatura> listaT = new List<Temperatura>();//inizializza una lista vuota
            //per mettere elementi nella lista
            listaT.Add(t1);
            listaT.Add(t2);
            listaT.Add(t3);
            //ciclo sulla lista
            //il numero effettivo di oggetti nella lista si chiama Count
            Console.WriteLine("Stampa della lista");
            for (int i = 0; i < listaT.Count; i++)
            {
                Console.WriteLine(listaT[i]);
            }
            //accesso ai singoli elementi
            //Clear elimina tutti gli elementi della lista
            //listaT.Clear();
            listaT.Remove(t2);
            Console.WriteLine("Stampa della lista dopo aver rimosso t2");
            for (int i = 0; i < listaT.Count; i++)
            {
                Console.WriteLine(listaT[i]);
            }
            listaT.Remove(new Temperatura(20, istante, "Monticello Brianza"));
            Console.WriteLine("Stampa della lista dopo aver rimosso oggetto boh (t1 toericamente(");
            for (int i = 0; i < listaT.Count; i++)
            {
                Console.WriteLine(listaT[i]);
            }
        }
    }
}
