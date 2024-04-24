using System.Collections;

namespace EnumeratorDemo
{
    public class DaysOfTheWeek : IEnumerable
    {
        private string[] days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < days.Length; index++)
            {
                // Yield each day of the week.
                //yield return days[index];
                ////Yeld only days starting with S
                if (days[index].ToUpper().StartsWith("S"))
                    yield return days[index];
                //l'ultimo esempio sopra ritorna solo i giorni che iniziano con la S
            }
        }
    }

    public class MyStack<T> : IEnumerable<T>
    {
        private T[] values = new T[100];
        private int top = 0;
        public void Push(T t)
        {
            values[top] = t;
            top++;
        }
        public T Pop()
        {
            top--;
            return values[top];
        }
        // This method implements the GetEnumerator method. It allows
        // an instance of the class to be used in a foreach statement.
        public IEnumerator<T> GetEnumerator()
        {
            for (int index = top - 1; index >= 0; index--)
            {
                yield return values[index];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerable<T> TopToBottom
        {
            get { return this; }
        }
        public IEnumerable<T> BottomToTop
        {
            get
            {
                for (int index = 0; index <= top - 1; index++)
                {
                    yield return values[index];
                }
            }
        }
        public IEnumerable<T> TopN(int itemsFromTop)
        {
            // Return less than itemsFromTop if necessary.
            int startIndex = itemsFromTop >= top ? 0 : top - itemsFromTop;
            for (int index = top - 1; index >= startIndex; index--)
            {
                yield return values[index];
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Come si usa un enumeratore? boh
            DaysOfTheWeek days = new DaysOfTheWeek();
            foreach (string day in days)
            {
                Console.Write(day + " ");
            }
            // Output: Sun Mon Tue Wed Thu Fri Sat
            Console.ReadKey();


            MyStack<int> theStack = new MyStack<int>();
            // Add items to the stack.
            for (int number = 0; number <= 9; number++)
            {
                theStack.Push(number);
            }
            // Retrieve items from the stack.
            // foreach is allowed because theStack implements IEnumerable<int>.
            Console.WriteLine("Stampa mediante foreach, nell'ordine predefinito dal GetEnumerator");
            foreach (int number in theStack)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
            // Output: 9 8 7 6 5 4 3 2 1 0
            // foreach is allowed, because theStack.TopToBottom returns IEnumerable(Of Integer).
            Console.WriteLine("Stampa mediante foreach, nell'ordine predefinito daIEnumerable < T > TopToBottom");
            foreach (int number in theStack.TopToBottom)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
            // Output: 9 8 7 6 5 4 3 2 1 0
            Console.WriteLine("Stampa mediante foreach, nell'ordine predefinito da IEnumerable < T > BottomToTop");
            foreach (int number in theStack.BottomToTop)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
            // Output: 0 1 2 3 4 5 6 7 8 9
            Console.WriteLine("Stampa mediante foreach, nell'ordine predefinito da IEnumerable < T > TopN");
            foreach (int number in theStack.TopN(7))
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
            // Output: 9 8 7 6 5 4 3
            Console.ReadKey();
        }
    }
}
