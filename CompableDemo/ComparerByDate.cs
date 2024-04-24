using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CompableDemo
{
    //IComparer<T> --> definisce gli ordinamenti aggiuntivi 
    public class ComparerByDate : IComparer<Temperatura>
    {
        //public int Compare(Temperatura? x, Temperatura? y)
        //{
        //    return x?.Date.CompareTo(y?.Date) ?? 0; 
        //}

        public int Compare(Temperatura? x, Temperatura? y)
        {
            //il contratto dice che
            //il metodo deve restituire -1 se x precede y nell'ordinamento
            //il metodo deve restituire 0se x e y sono nello stesso punto nell'ordinamento 
            //il metodo deve restituire 1 se x segue y nell'ordinamento
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
                return x.Date.CompareTo(y.Date);
            }
        }
    }
}
