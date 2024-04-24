using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClassi
{
    public interface IReproducible<T> where T : Felidae
    {
        T[] Reproduce(T mate);
    }
}
