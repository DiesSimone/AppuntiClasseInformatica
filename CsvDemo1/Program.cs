namespace CsvDemo1
{
    //serve il modello dei dati

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Studente> studenti = new List<Studente>();
            //leggere il file csv degli studenti
            string filePath = @"C:\fileacaso\YouDie.csv";
            try
            {
                using StreamReader reader = new StreamReader(filePath);
                string? riga;
                while ((riga = reader.ReadLine()) != null)
                {
                    string[] parole = riga.Split(new char[] { ',' });
                    //facciamo un test per vedere se un campo è nullo
                    foreach (string parola in parole)
                    {
                        if (parola is null)
                        {
                            throw new StudentReadExeption();
                        }
                    }
                    studenti.Add(new Studente() 
                    {
                        Nome = parole[0], 
                        Cognome = parole[1], 
                        Indirizzo = parole[2] 
                    });
                    
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File non trovato");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            //stampare a console gli studenti dopo aver fatto la deserializzazione

            foreach (var studente in studenti)
            {
                Console.WriteLine(studente); 
            }
        }
    }
}
