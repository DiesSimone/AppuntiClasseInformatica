using System.Collections.Generic;

namespace QueueDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue1 = new Queue<string>();
            queue1.Enqueue("MCA");
            queue1.Enqueue("MBA");
            queue1.Enqueue("BCA");
            queue1.Enqueue("BBA");
            Console.WriteLine("The elements in the queue are:");
            foreach (string s in queue1)
            {
                Console.WriteLine(s);
            }
            var oggettoDaElaborare = queue1.Dequeue(); //Removes the first element that enter in the queue here the first element is MCA
            Console.WriteLine($"Oggetto prelevato: {oggettoDaElaborare}");
            oggettoDaElaborare = queue1.Dequeue(); //Removes MBA
            Console.WriteLine($"Oggetto prelevato: {oggettoDaElaborare}");
            var oggettoIntesta = queue1.Peek();
            Console.WriteLine("After removal the elements in the queue are:");
            foreach (string s in queue1)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("The element MCA is contain in the queue:" +
           queue1.Contains("MCA"));
            Console.WriteLine("The element BCA is contain in the queue:" +
           queue1.Contains("BCA"));
            Console.WriteLine("The element MTech is contain in the queue:" +
           queue1.Contains("MTech"));
        }

    }
}
