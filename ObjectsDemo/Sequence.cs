using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsDemo
{
    public class Sequence
    {
        // Static field, holding the current sequence value
        private static int currentValue = 0;
        // Intentionally deny instantiation of this class
        //costruttore privato --> impedisce alle altre classi di creare un oggetto di questo tipo
        private Sequence()
        {
        }
        // Static method for taking the next sequence value
        //i metodi statici possono accedere solo a campi statici e si invocano sulla classe e non sull'istanza (reference)
        public static int NextValue()
        {
            currentValue++;
            return currentValue;
        }
    }
}
