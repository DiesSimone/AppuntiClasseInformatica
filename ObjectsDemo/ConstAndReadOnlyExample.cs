using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsDemo
{
    public class ConstAndReadOnlyExample
    {
        // Constants are implicitly static
        //const definisce il valore del simbolo al tempo di compilazione
        public const double PI = 3.1415926535897932385;
        //readonly definisce il valore del simbolo al tempo di esecuzione
        //readonly permette di assegnare il valore una sola volta, tipicamente nel costruttore

        public readonly double Size;
        public ConstAndReadOnlyExample(int size)
        {
            this.Size = size; // Cannot be further modified!
        }
    }
}
