using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompableDemo
{
    public class ComparerByPosizione : Comparer<Temperatura>
    {
        public override int Compare(Temperatura? x, Temperatura? y)
        {
            if (x == null && y == null)
            {
                return 0;
            }
            else if (y == null) //se sono qui x non è nullo
            {
                return 1;
            }
            else if (x == null)
            {
                return -1;
            }
            else //qui x e y sono entrambi non nulli
            {
                return x.Posizione.CompareTo(y.Posizione);
            }
        }
    }
}
