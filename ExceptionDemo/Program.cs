namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string fileName = "WrongTextFile2.txt";
                ReadFile(fileName);
            }
            catch (IOException ioe)
            {
                // Exception handler for other input/output exceptions
                // We just print the stack trace on the console
                Console.WriteLine(ioe.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void ReadFile(string fileName)
        {
            //TextReader reader = new StreamReader(fileName);
            //string line = reader.ReadLine();
            //Console.WriteLine(line);
            //reader.Close();
            TextReader reader = null;
            try
            {
                reader = new StreamReader(fileName);
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
            catch (FileNotFoundException fnfe)
            {
                // Exception handler for FileNotFoundException
                // We just inform the user that there is no such file
                Console.WriteLine(fnfe.Message);
            }
            finally
            {
                // Always close "reader" (if it was opened)
                Console.WriteLine("La casa brucia ma il codice nel blocco" +
                    " finally è stato eseguito");
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }
    }
}
