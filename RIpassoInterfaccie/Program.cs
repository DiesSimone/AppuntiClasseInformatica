namespace RIpassoInterfaccie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dispositivo d1 = new Dispositivo("Galaxy S24", "Samsung", TipoDispositivo.Cellulare, 1499.99);
            Dispositivo d2 = new Dispositivo("A1", "Samsung", TipoDispositivo.Cellulare, 300.99);
            Dispositivo d3 = new Dispositivo("IPhone 15", "Apple", TipoDispositivo.Cellulare, 1200.99);

            //if (d1.Equals(d2))
            //{
            //    Console.WriteLine("OMG SONO UGUALI");
            //}
            //else
            //{
            //    Console.WriteLine("No i dispositivi sono diversi!");
            //} //letteralmente uguale al coso seguente con il == 

            if (d1 == d2)
            {
                Console.WriteLine("OMG SONO UGUALI");
            }
            else
            {
                Console.WriteLine("No i dispositivi sono diversi!");
            }
            //stampa GetHashCode
            int hash1 = d1.GetHashCode();
            int hash2 = d2.GetHashCode();
            Console.WriteLine($"Hash code di d1 = {hash1}");
            Console.WriteLine($"Hash code di d2 = {hash2}");

            Dispositivo[] dispositivi = new Dispositivo[3];
            dispositivi[0] = d1;
            dispositivi[1] = d2;
            dispositivi[2] = d3;
            Dispositivo[] dispositivi2 = {d1, d2, d3};

            //Lista di dispositivi
            List<Dispositivo> listaDispositivi = new List<Dispositivo>();
            listaDispositivi.Add(d1);
            listaDispositivi.Add(d2);
            listaDispositivi.Add(d3);
            Console.WriteLine("stampa lista dispositivi prima dell'ordinamento");
            foreach (Dispositivo dies in listaDispositivi)
            {
                Console.WriteLine(dies);
            }

            //come ordinare con il metodo Sort --> uso di CompareTo - ordinamento predefinito
            Array.Sort(dispositivi);
            listaDispositivi.Sort();
            Console.WriteLine("stampa lista dispositivi dopo dell'ordinamento predefinito");
            foreach (Dispositivo dies in listaDispositivi)
            {
                Console.WriteLine(dies);
            }

            //ordiniamo rispetto a un criterio diverso da quello predefinito
            Array.Sort(dispositivi, new OrderByNome());//ordinare rispetto al nome
            listaDispositivi.Sort(new OrderByNome());
            Console.WriteLine("stampa lista dspositivi dopo dell'ordinamento rispetto al nome");
            foreach (Dispositivo dies in listaDispositivi)
            {
                Console.WriteLine(dies);
            }
            //test di richiamo del metodo UtilizzaUSB
            UtilizzaUSB(d1); //funziona perchè d1 implementa l'interfaccia IUsb
        }
        static void UtilizzaUSB(IUsb usb)
        {
            usb.Trasmetti("OOOOOOOO OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO MA QUANTO CI METTI A CONQUISTARE IL MONDO??????????????????????????????????????????????????????????????????????'");
            Console.WriteLine(usb.Ricevi()); 
        }
    }
}
