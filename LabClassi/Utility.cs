using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClassi
{
    public class Utility<T>
    {
        //public void Swap(Object obj1 , Object obj2)
        //{
        //    Object temp = obj1;
        //    obj1 = temp;
        //    temp = obj2;
        //}
        public void Swap(ref T obj1, ref T obj2)
        {
            T temp = obj1;
            obj1 = temp;
            temp = obj2;
        }
    }
}
