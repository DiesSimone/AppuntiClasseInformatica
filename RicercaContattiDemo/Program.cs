namespace RicercaContattiDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creiamo alcuni contatti
            List<Contatto> contatti = new List<Contatto>();
            contatti.Add(new Contatto() 
            { 
                Id = 1,
                Cognome ="Rossi",
                Nome="Mario",
                EMail="mario.rossi@gmail.com",
                Telefono="123456789"
            });
            contatti.Add(new Contatto()
            {
                Id = 2,
                Cognome = "Verdi",
                Nome = "Mario",
                EMail = "mario.verdi@gmail.com",
                Telefono = "987654321"
            });
            contatti.Add(new Contatto()
            {
                Id = 3,
                Cognome = "Neri",
                Nome = "Mario",
                EMail = "mario.neri@gmail.com",
                Telefono = "123456789"
            });
            contatti.Add(new Contatto()
            {
                Id = 3,
                Cognome = "Neri",
                Nome = "Mario",
                EMail = "mario.neri@gmail.com",
                Telefono = "123456789"
            });
            //stampa lista
            foreach(var contatto in contatti)
            {
                Console.WriteLine(contatto);
            }
            HashSet<Contatto> elencoContatti = new HashSet<Contatto>(contatti);
            //vogliamo stampare i contatti nell'hashSet
            Console.WriteLine("stamp dei contatti dall'hashset");
            foreach (var contatto in elencoContatti)
            {
                Console.WriteLine(contatto);
            }
            if(elencoContatti.Contains(new Contatto() { Id = 1 }))
            {
                Console.WriteLine("l'HashSet elencocontatti contiene un contatto con Id pari a 1");
            }
            //operazioni insiemistiche su HashSet

            HashSet<Contatto> elencoContatti2 = new HashSet<Contatto>();

            elencoContatti2.Add(new Contatto()
            {
                Id = 4,
                Cognome = "Cocco",
                Nome = "Andrea",
                EMail = "andrea.cocco@gmail.com",
                Telefono = "123456789"
            }); 

            Console.WriteLine("stamp dei contatti dall'hashset2");
            foreach (var contatto in elencoContatti2)
            {
                Console.WriteLine(contatto);
            }

            HashSet<Contatto> contatti3 = new HashSet<Contatto>();
            contatti3.Add(new Contatto()
            {
                Id = 2,
                Cognome = "Verdi",
                Nome = "Mario",
                EMail = "mario.verdi@gmail.com",
                Telefono = "987654321"
            });

            //intersezione
            elencoContatti.IntersectWith(contatti3);
            Console.WriteLine("stamp dei contatti dopo intersezione con contatti3");
            foreach (var contatto in elencoContatti)
            {
                Console.WriteLine(contatto);
            }

            //Esempio di utilizzo i un dizionario
            Dictionary<string, string> openWith = new Dictionary<string, string>();
            // Add some elements to the dictionary. There are no
            // duplicate keys, but some of the values are duplicates.
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");
            //se provo ad aggiungere una chiave già presente ottengo una eccezione
            if (!openWith.ContainsKey("txt"))
            {
                openWith.Add("txt", "notepad2.exe");
            }
            //esiste la notazione ad array per accedere alle coppie chiave - valore
            openWith["txt"] = "nuovoprogramma.exe";
            //proviamo ad accedere ad un valore del dizionario
            var oggetto = openWith["bmp"];
            Console.WriteLine(oggetto);
            Console.WriteLine(openWith["txt"]);            //questa non genera eccezione            openWith["pippo"] = "pippo.exe";            openWith["pippo"] = "pippo.exe";            Console.WriteLine(openWith["pippo"]);            Dictionary<string, Contatto> dizionarioContatti = new Dictionary<string, Contatto>();            //uso la notazione ad array            //dizionarioContatti[contatti[0].EMail] = contatti[0];            for (int i = 0; i < contatti.Count; i++)
            {
                dizionarioContatti[contatti[i].EMail] = contatti[i];
            }
            //come faccio a fare un ciclo su un dizionario?
            //questa istruzione permette di accedere al contatto con chiave mario.rossi@gmail.com
            Contatto ilContatto = dizionarioContatti["mario.rossi@gmail.com"];
            Console.WriteLine(ilContatto);
            foreach (var coppia  in dizionarioContatti)
            {
                Console.WriteLine($"Chaive = {coppia.Key} --> Valore = {coppia.Value}");
            }
            //cosa succede se provo ad accedere a una chiave che non esiste?
            if (dizionarioContatti.ContainsKey("mario.rossi@gmail.com"))
            {
                Contatto ilContatto2 = dizionarioContatti["mario.rossi@gmail.com"];
                Console.WriteLine(ilContatto2);
            }

        }
    }
}
