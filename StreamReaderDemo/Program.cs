namespace StreamReaderDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "../../../Esempio.txt";
            try
            {
                //dato un file di testo leggere una riga alla volta 
                //serve sapere dove è situato il file ---> file path
                
                using StreamReader reader = new StreamReader(filePath);
                //string contenuto = reader.ReadToEnd();
                //Console.WriteLine(contenuto);
                //string riga = reader.ReadLine();
                //Console.WriteLine(riga);
                ////stampa seconda riga
                //riga = reader.ReadLine();
                //Console.WriteLine(riga);
                string? riga;
                int numeroRiga = 1;
                while ((riga = reader.ReadLine()) != null)
                {
                    //processing della riga
                    Console.WriteLine($"numero: {numeroRiga++} --> {riga}");
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
