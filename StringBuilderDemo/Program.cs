using System.Diagnostics;
using System.Text;

namespace StringBuilderDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string collector = "Numbers: ";
            for (int index = 1; index <= 20000; index++)
            {
                collector += index;
            }
            sw.Stop();
            Console.WriteLine(collector);
            Console.WriteLine($"Ho impiegato {sw.ElapsedMilliseconds}ms");
            //versione corretta con la classe StringBuilder
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Uso di StringBuilder");
            sw.Restart();
            sb.Append("Numbers: ");
            for (int index = 1; index <= 20000; index++)
            {
                sb.Append(""+index);
            }
            sw.Stop();
            Console.WriteLine(sb.ToString());
            Console.WriteLine($"Ho impiegato {sw.ElapsedMilliseconds}ms");
        }
    }
}
