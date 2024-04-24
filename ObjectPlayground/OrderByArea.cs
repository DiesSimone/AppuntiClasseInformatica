using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPlayground
{
    //stiamo estendendo la classe astratta Comparer
    public class OrderByArea : Comparer<Box>
    {
        public override int Compare(Box? x, Box? y)
        {
            if (x == null && y == null)
            {
                return 0;
            }
            else if (x == null)
            {
                return -1;
            }
            else if (y == null)
            {
                return 1;
            }
            else
            {
                return x.TotalArea.CompareTo(y.TotalArea);
            }
        }
    }
}
