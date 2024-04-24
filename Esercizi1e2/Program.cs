using Esercizi1e2;

namespace ObjectsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Mario", "Rossi", "Ingegneria", "Informatica 1", "Polimi");
            Console.WriteLine($"Nome completo: {st.FullName}");
            st.FullName = "Bianchi Luca";
        }
    }
}
