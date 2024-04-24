
namespace StackDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack1 = new Stack<string>();
            string[] str = 
            {
                "MCA",
                "BCA",
                "BBA",
                "MBA",
                "MTech"
            };
            Stack<string> stack2 = new Stack<string>(str);
            Stack<string> stack3 = new Stack<string>(10);
            stack1.Push("************");
            stack1.Push("MCA");
            stack1.Push("MBA");
            stack1.Push("BCA");
            stack1.Push("BBA");
            stack1.Push("***********");
            stack1.Push("**Courses**");
            stack1.Push("***********");
            Console.WriteLine("The elements in the stack1 are as:");
            //se faccio un foreach su uno stack accedo ai elementi in ordine inverso
            foreach (string s in stack1)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("The elements in the stack2 are as:");
            foreach (string s in stack2)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Proviamo a prelevare oggetti dallo stack");
            //la pop restituisce l'ultimo elemento inserito e lo toglie dallo stack
            var oggettoInCima = stack1.Pop();
            Console.WriteLine(oggettoInCima);
            oggettoInCima = stack1.Pop();
            Console.WriteLine(oggettoInCima);
            //Peak restituisce l'ultimo elemento inserito nello stack senza toglierlo dallo stack
            stack1.Peek();
            //scrivere il metodo statico SvuotaStack
            SvuotaStack(stack1);

        }

        private static void SvuotaStack(Stack<string> stack1)
        {
            //scrivere un ciclo che effettua tante pop fino a svuotare lo staaaaaaack
            while (stack1.Count > 0)
            {
                var elemento = stack1.Pop();
                Console.WriteLine($"Elemento rimosso: {elemento}");
            }
            Console.WriteLine($"Ecco di cosa rimane di stack1: {stack1}");

        }
    }
}
