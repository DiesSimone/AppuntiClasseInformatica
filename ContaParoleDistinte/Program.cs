using System.Security.Cryptography;
using System.Security.Principal;

namespace ContaParoleDistinte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testo = "Oggi è una bella giornata e penso di andare in montagna. La montagna è bella";
            //step 1: suddividiamo il testo in parole
            string[] parole = testo.Split(new char[] {' ', ',', '.', ';', '?', '!', ':'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var parola in parole)
            {
                Console.WriteLine(parola);
            }
            Console.WriteLine($"le parole n testo sono {parole.Length}");
            //step n.2 contare le parole distinte
            //creo un HashSet di string
            HashSet<string> paroleDistinte = new HashSet<string>(parole);
            foreach(var parola in paroleDistinte)
            {
                Console.WriteLine(parola);
            }
            Console.WriteLine($"Le parole distinte nel testo sono {paroleDistinte.Count}");

        }
    }
}
