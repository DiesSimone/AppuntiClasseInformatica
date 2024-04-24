namespace StreamWriterDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //percorso al file dove scriveremo
            string filePath = "../../../Prova.txt";
            using StreamWriter streamWriter = new StreamWriter(filePath);
            string? riga;
            Console.WriteLine("Inserisci ctrl+z per uscire dal ciclo");
            do
            {
                Console.Write(">riga: ");
                riga = Console.ReadLine();
                if (riga != null)
                {
                    streamWriter.WriteLine(riga);
                }
            } while (riga != null);
            streamWriter.Close();
            //riapro il file in lettura
            StreamReader reader = new StreamReader(filePath);
            string contenuto = reader.ReadToEnd();
            Console.WriteLine("Hai scritto il seguente testo");
            Console.WriteLine(contenuto); 
        }
    }
}
