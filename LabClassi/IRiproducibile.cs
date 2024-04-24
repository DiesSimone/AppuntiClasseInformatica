using LabClassi.FaunaGreppi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClassi
{
    namespace FaunaGreppi
    {
        public interface IRiproducibile<T> where T : Animale
        {
            T[]? Riproduci(T mate);
        }
    }
    
}
