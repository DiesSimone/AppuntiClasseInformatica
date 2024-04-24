using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIpassoInterfaccie
{
    public class OrderByNome : Comparer<Dispositivo> 
    {
        public override int Compare(Dispositivo? x, Dispositivo? y)
        {
            if (x is null && y is null)
            {
                return 0;
            }
            if (ReferenceEquals(x, null))
            {
                return -1;
            }
            if (ReferenceEquals(y, null))
            {
                return 1;
            }
            return x.Nome.CompareTo(y.Nome);//questo è il CompareTo di string
        }
    }
}
