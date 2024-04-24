namespace LetturaFileTesto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of StreamReader to read from a file
            //percorso assoluto:
            //StreamReader reader = new StreamReader(@"C:\test121029\Sample.txt");
            //------------------------------------------------------------------------------------------------------------------------
            //percorso relativo:
            StreamReader reader = new StreamReader("../../../dati/Sample.txt");

            using (reader)
            {
                int lineNumber = 0;
                // Read first line from the text file
                string line = reader.ReadLine();
                // Read the other lines from the text file
                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                }
            }
        }
    }
}
