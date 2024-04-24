using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIpassoInterfaccie
{
    public interface IUsb
    {
        public void Trasmetti(string messaggio);
        public string Ricevi();

    }
}
